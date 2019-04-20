using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Drawing;

namespace Gameservice
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IService1” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void Rejestruj(string nick);
        [OperationContract]
        void idz(string nick, int dx, int dy);
        [OperationContract]
        Gracz[] ListaGraczy();

        // TODO: dodaj tutaj operacje usługi
    }

    // Użyj kontraktu danych, jak pokazano w poniższym przykładzie, aby dodać typy złożone do operacji usługi.
    // Możesz dodać pliki XSD do projektu. Po skompilowaniu projektu możesz bezpośrednio użyć zdefiniowanych w nim typów danych w przestrzeni nazw „Gameservice.ContractType”.
    [DataContract]
    public class Gracz
    {
        private int y;
        public string nick;
        private int x;
       

        [DataMember]
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        [DataMember]
        public string Nick
        {
            get { return nick; }
            set { nick= value; }
        }


        [DataMember]
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public void Przesun(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public void Ustaw(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }



    }
}
