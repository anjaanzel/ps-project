using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public abstract class OpstaSistemskaOperacija
    {
        public Object IzvrsiSO(object odo)
        {
            Object rez = null;
            try
            {
                Broker.dajSesiju().otvoriKonekciju();
                Broker.dajSesiju().zapocniTransakciju();
                rez = Izvrsi(odo);
                Broker.dajSesiju().potvrdiTransakciju();
            }
            catch (Exception)
            {
                Broker.dajSesiju().ponistiTransakciju();

            }
            finally { Broker.dajSesiju().zatvoriKonekciju(); }
            return rez;
        }
        public abstract Object Izvrsi(object odo);
    }
}
