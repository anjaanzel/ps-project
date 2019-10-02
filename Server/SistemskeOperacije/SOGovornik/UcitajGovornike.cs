using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.SOGovornik
{
    public class UcitajGovornike : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {

        List<Govornik> lista = Broker.dajSesiju().vratiSve(odo as OpstiDomenskiObjekat).OfType<Govornik>().ToList<Govornik>();

            return lista;

        }
    }
}
