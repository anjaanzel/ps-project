using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.SOGovornik
{
    public class PronadjiGovornike : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            List<Govornik> lista = Sesija.Broker.dajSesiju().vratiSveZaOpstiUslov(odo as OpstiDomenskiObjekat).OfType<Govornik>().ToList<Govornik>();

            foreach (Govornik g in lista)
            {
                g.Zemlja = Sesija.Broker.dajSesiju().vratiJedanZaID(g.Zemlja) as Zemlja;
            }

            return lista;
        }
    }
}
