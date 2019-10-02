using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.SORaspored
{
    public class UcitajRasporede : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {

            List<Raspored> lista = Broker.dajSesiju().vratiSve(odo as OpstiDomenskiObjekat).OfType<Raspored>().ToList<Raspored>();

            return lista;

        }
    }
}
