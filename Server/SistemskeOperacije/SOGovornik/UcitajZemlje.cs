using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.SOGovornik
{
    public class UcitajZemlje : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            
            List<Zemlja> lista = Sesija.Broker.dajSesiju().vratiSve(odo as OpstiDomenskiObjekat).OfType<Zemlja>().ToList<Zemlja>();

            return lista;
        }
    }
}
