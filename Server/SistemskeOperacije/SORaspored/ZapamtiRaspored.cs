using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.SORaspored
{
    public class ZapamtiRaspored : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            return Sesija.Broker.dajSesiju().update(odo as OpstiDomenskiObjekat);
        }
    }
}
