using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SistemskeOperacije.SOGovornik
{
    public class PronadjiGovornika: OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            Govornik g = odo as Govornik;
            g.Zemlja = Sesija.Broker.dajSesiju().vratiJedanZaID(g.Zemlja) as Zemlja;
            return g;
        }
    }
}
