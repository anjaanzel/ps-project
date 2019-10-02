using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.ComponentModel;

namespace Server
{
    public class Server
    {
        Socket soket;
        Thread nit;
        public static List<NetworkStream> listaTokovaKlijenata = new List<NetworkStream>();
        public bool pokreniServer()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 20000);
                soket.Bind(ep);

                ThreadStart ts = osluskujKlijenta;
                nit = new Thread(ts);
                nit.Start();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool zaustaviServer()
        {
            try
            {
                soket.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        void osluskujKlijenta()
        {
            try
            {

                while (true)
                {
                    soket.Listen(8);

                    Socket klijent = soket.Accept();
                    NetworkStream tok = new NetworkStream(klijent);
                    new NitKlijenta(tok);
                    listaTokovaKlijenata.Add(tok);
                }
            }
            catch (Exception) { }
        }
    }
    
}
