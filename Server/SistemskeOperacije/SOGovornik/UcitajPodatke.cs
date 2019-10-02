using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.SOGovornik
{
    public class UcitajPodatke : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            Govornik g = odo as Govornik;

            g.Zemlja = Broker.dajSesiju().vratiJedanZaID(g.Zemlja) as Zemlja;
            return g;
        }
    }
}
