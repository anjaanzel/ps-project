using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.SOPredavanje
{
    public class PronadjiPredavanje : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            Predavanje p = odo as Predavanje;
            p.Govornik = Sesija.Broker.dajSesiju().vratiJedanZaID(p.Govornik) as Govornik;
            p.Sala = Sesija.Broker.dajSesiju().vratiJedanZaID(p.Sala) as Domen.Sala;
            p.Raspored = Sesija.Broker.dajSesiju().vratiJedanZaID(p.Raspored) as Raspored;

            return p;
        }
    }
}
