using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.SOSala
{
    public class ZapamtiSalu : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            return Sesija.Broker.dajSesiju().update(odo as OpstiDomenskiObjekat);
        }
    }
}
