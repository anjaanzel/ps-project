using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.SOPredavanje
{
    public class ObrisiPredavanje : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            return Broker.dajSesiju().delete(odo as OpstiDomenskiObjekat);
        }
    }
}
