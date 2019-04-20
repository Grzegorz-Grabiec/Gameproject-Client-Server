using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Drawing;

namespace Gameservice
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {

        Dictionary<string, Gracz> gracze;
        public Service1()
        {
            gracze = new Dictionary<string, Gracz>();
        }
      
        public void idz(string nick, int dx, int dy)
        {
            if (gracze.ContainsKey(nick))
            {
                //gracze[nick].Przesun(dx, dy);
                gracze[nick].Ustaw(dx, dy);
                Console.WriteLine("gracz{0} przemiescił sie do [{1},{2}", nick, dx, dy);
            }
            else
            {
                Console.WriteLine("{0} się nie zarejestrował!", nick);
            }
        }

        public Gracz[] ListaGraczy()
        {
            return gracze.Values.ToArray();
        }

        public void Rejestruj(string nick)
        {
            if (!gracze.ContainsKey(nick))
            {
                gracze[nick] = new Gracz() { Nick = nick };
                Console.WriteLine("nowy Gracz {0} Dołączył do gry", nick);
            }
            else
            {
                Console.WriteLine("{0} już sie zarejestrował!", nick);
            }
        }

    }
}
