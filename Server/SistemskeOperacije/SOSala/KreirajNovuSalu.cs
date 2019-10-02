using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.Sala
{
    public class KreirajNovuSalu : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            Domen.Sala s = new Domen.Sala();
            s.SifraSale = Broker.dajSesiju().vratiSifru(s);
            Broker.dajSesiju().insert(s);
            return s;
        }
    }
}
