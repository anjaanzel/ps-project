using System;
using System.ComponentModel;
using System.Data;

namespace Domen
{
    [Serializable]
    public class Raspored : OpstiDomenskiObjekat
    {

        public override string ToString()
        {
            return datum.ToString("dd-MM-yyyy");
        }

        int sifraRasporeda;
        DateTime datum;
        string vodjaPrograma;
        DateTime pauzaZaRucak;

        public int SifraRasporeda { get => sifraRasporeda; set => sifraRasporeda = value; }
        
        public DateTime Datum { get => datum; set => datum = value; }
        public string VodjaPrograma { get => vodjaPrograma; set => vodjaPrograma = value; }
        public DateTime PauzaZaRucak { get => pauzaZaRucak; set => pauzaZaRucak = value; }

        #region ODO
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Raspored";
            }
        }

        public string Uslovi;

        public string UslovOpsti
        {
            get
            {
                return Uslovi;
            }
        }

        [Browsable(false)]
        public string ID
        {
            get
            {
                return "SifraRasporeda";
            }
        }

        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "SifraRasporeda=" + SifraRasporeda;
            }
        }

        [Browsable(false)]
        public string Insert
        {
            get
            {
                return "(SifraRasporeda) VALUES (" + SifraRasporeda + ")";
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return " Datum='" + Datum.ToString("MM-dd-yyyy") + "', VodjaPrograma='" + VodjaPrograma + "', PauzaZaRucak='" + PauzaZaRucak.ToString("HH:mm") + "'";
            }
        }


        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Raspored r = new Raspored();
            r.SifraRasporeda = Convert.ToInt32(red["SifraRasporeda"]);
            r.Datum = Convert.ToDateTime(red["Datum"]);
            r.VodjaPrograma = red["VodjaPrograma"].ToString();
            r.PauzaZaRucak = Convert.ToDateTime(red["PauzaZaRucak"]);
            return r;
        }

        #endregion ODO

    }
}
