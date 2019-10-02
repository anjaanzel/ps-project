using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.Korisnik
{
    public class PronadjiKorisnika : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            return Broker.dajSesiju().vratiJedanZaOpstiUslov(odo as OpstiDomenskiObjekat) as Domen.Korisnik;
        }
    }
}
