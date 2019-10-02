using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.SORaspored
{
    public class KreirajNoviRaspored : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            Raspored r = new Raspored();
            r.SifraRasporeda = Broker.dajSesiju().vratiSifru(r);
            Broker.dajSesiju().insert(r);
            return r;
        }
    }
}
