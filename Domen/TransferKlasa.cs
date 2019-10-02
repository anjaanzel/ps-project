using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Operacije { Kraj=1, PronadjiKorisnika, KreirajPredavaca, VratiSveZemlje, ZapamtiPredavaca, KreirajSalu, ZapamtiSalu, KreirajRaspored, ZapamtiRaspored, PretraziGovornike, PronadjiGovornika, ZapamtiPredavanje, VratiSvePredavace, VratiSveSale, VratiSveRasporede, PretraziPredavanja, PronadjiPredavanje, AzurirajPredavanje, ObrisiGovornika, ObrisiPredavanje}
    [Serializable]
    public class TransferKlasa
    {
        public Operacije Operacija;
        public Object TransferObjekat;
        public Object Rezultat;

    }
}
