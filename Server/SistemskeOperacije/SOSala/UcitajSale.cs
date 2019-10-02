using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.SOSala
{
    public class UcitajSale : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {

            List<Domen.Sala> lista = Broker.dajSesiju().vratiSve(odo as OpstiDomenskiObjekat).OfType<Domen.Sala>().ToList<Domen.Sala>();

            return lista;

        }
    }
}
