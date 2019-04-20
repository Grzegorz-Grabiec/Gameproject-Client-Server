using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klient.Serwer;
using System.IO;
using System.Reflection;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Klient
{
    public partial class Form1 : Form
    {
        bool goleft = false;
        bool goright = false;
        bool jumping = false;
        int jumpspeed = 10;
        int force = 8;
        
        int quick = 0;
        Boolean move,falling;
        Service1Client client;
        SqlCommand cmd;
        SqlConnection con;
        

        Gracz[]             gracze = new Gracz[0];
        List<PictureBox>    graczePic;
        Gracz               gracz = new Gracz();
        List<string>        aktualniGracze = new List<string>();
        String              playerName;
        PictureBox          myPlayer,otherPlayers;
        Rectangle           playerBottom;

        public string Nick { get; }

        public Form1(string nick)
        {
            InitializeComponent();
            Nick = nick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            client = new Service1Client();
            graczePic = new List<PictureBox>();
            playerName = Nick;
            client.Rejestruj(playerName);
        }

        private void createPictureBoxPlayer(string _nick)
        {
            PictureBox newPlayer = new PictureBox();
            newPlayer.Location = new Point(400, 528);

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            string[] names = myAssembly.GetManifestResourceNames();
            Stream myStream = myAssembly.GetManifestResourceStream("Klient.ludek.png");
            Bitmap bmp = new Bitmap(myStream);
            //newPlayer.Image = Image.FromFile("ludek.png");
            newPlayer.Image = bmp;
            newPlayer.Size = new Size(25, 35);
            newPlayer.BackColor = Color.Transparent;
            newPlayer.Name = _nick;
            newPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            newPlayer.Tag = _nick;
            newPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(newPlayer);
            graczePic.Add(newPlayer);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            client = new Service1Client();
            gracze = client.ListaGraczy();
            for(int i=0;i<gracze.Length;i++)
            {
                if (!aktualniGracze.Exists(x => x == gracze[i].Nick))
                {
                    aktualniGracze.Add(gracze[i].Nick);
                    this.createPictureBoxPlayer(gracze[i].Nick);
                }
                else
                {
                    if(gracze[i].Nick != playerName)
                    {
                        otherPlayers = graczePic.Find(x => (string)x.Tag == gracze[i].Nick);
                        otherPlayers.Location = new Point(gracze[i].X, gracze[i].Y);
                    }
                }
            }
            myPlayer = graczePic.Find(x => (string)x.Tag == playerName);
            this.Refresh();
          
            quick += 2;
            countdown.Text = quick / 60 + " : " + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
            
            //
            move = true;
            playerBottom = new Rectangle(myPlayer.Location.X, myPlayer.Location.Y + myPlayer.Size.Height, myPlayer.Size.Width, 1);
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Platform")
                {
                    //if (myPlayer.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    
                    if (playerBottom.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        move = false;
                        falling = false;
                        myPlayer.Top = (x.Top) - myPlayer.Height;
                    }

                }
            }

            if(move)
                myPlayer.Top += jumpspeed;

            if (jumping && force < 0)
                {
                    jumping = false;
                }
            if (goleft)
                {
                myPlayer.Left -= 9;
                }
            if (goright)
                {
                myPlayer.Left += 9;
                }
            if (jumping)
                {
                    jumpspeed = -11;
                    force -= 1;
                    if (force == 0)
                        falling = true;
                }
            else
                {
                    jumpspeed = 10;
                    //jumpspeed = 6;
                }

           
            client.idz((string)myPlayer.Tag, myPlayer.Location.X, myPlayer.Location.Y);
            if (myPlayer.Bounds.IntersectsWith(Door.Bounds))
            {

                timer1.Stop();
                dodawanko(countdown.Text);
               
                        MessageBox.Show("You Win" + " Your Time: " + countdown.Text);
            }
            
        }
        public void dodawanko(string czas)
        {
            con = new SqlConnection("Data Source=abd.wwsi.edu.pl;Initial Catalog=WarSamochody;Persist Security Info=True;User ID=samochody;Password=gabgrzjul");
            con.Open();
            cmd = new SqlCommand("INSERT INTO Wyniki (Czas,PlayerName) VALUES (@Czas,@PlayerName)", con);
            SqlParameterCollection parameters = cmd.Parameters;
#pragma warning disable CS0618 // Typ lub składowa jest przestarzała
            parameters.Add("@Czas", czas);
            parameters.Add("@PlayerName", playerName);
#pragma warning restore CS0618 // Typ lub składowa jest przestarzała
            cmd.ExecuteNonQuery();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Service1Client client = new Service1Client();
           
            
        

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Service1Client client = new Service1Client();
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                if(!falling)
                    jumping = true;
            }

        }

        private void Keyup(object sender, KeyEventArgs e)
        {
           
                if (e.KeyCode == Keys.Left)
                {
                    goleft = false;
                }
                if (e.KeyCode == Keys.Right)
                {
                    goright = false;
                }
                if (e.KeyCode == Keys.Space && !jumping)
                {
                    if(!falling)
                        jumping = false;
                }
        }

        private void Player_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
