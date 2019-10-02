using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace Server.SistemskeOperacije.SOGovornik
{
    public class ObrisiGovornika : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            return Broker.dajSesiju().delete(odo as OpstiDomenskiObjekat);
        }
    }
}
