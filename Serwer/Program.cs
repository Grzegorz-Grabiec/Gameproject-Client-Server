using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Gameservice;
namespace Serwer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1 gra = new Service1();
            ServiceHost host = new ServiceHost(gra);
            host.Open();
            Console.WriteLine("serwer gry dziala ....");
            Console.ReadKey();
            
        }
    }
}
