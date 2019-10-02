using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SistemskeOperacije.SOGovornik
{
    public class KreirajNovogGovornika : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            Govornik g = new Govornik();
            g.SifraGovornika = Sesija.Broker.dajSesiju().vratiSifru(g);
            Sesija.Broker.dajSesiju().insert(g);
            return g;
        }
    }
}
