using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.SOPredavanje
{
    public class ZapamtiPredavanje: OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            List<Predavanje> predavanja = odo as List<Predavanje>;

            foreach (Predavanje p in predavanja)
            {

            Sesija.Broker.dajSesiju().insert(p);

            }

            return true;
        }


    }
}
