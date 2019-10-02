using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Korisnik : OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return imeKorisnika + " " + prezimeKorisnika;
        }

        int sifraKorisnika;
        string imeKorisnika;
        string prezimeKorisnika;
        string username;
        string password;

        public int SifraKorisnika { get => sifraKorisnika; set => sifraKorisnika = value; }
        public string ImeKorisnika { get => imeKorisnika; set => imeKorisnika = value; }
        public string PrezimeKorisnika { get => prezimeKorisnika; set => prezimeKorisnika = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        #region OpstiDomenskiObjekat

        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Korisnik";
            }
        }

        public string Uslovi;
        [Browsable(false)]
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
                return "SifraKorisnika";
            }
        }



        [Browsable(false)]
        public string Insert
        {
            get
            {
                return "(SifraKorisnika) values (" + SifraKorisnika + ")";
            }
        }

        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "SifraKorisnika=" + SifraKorisnika;
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return "SifraKorisnika=" + SifraKorisnika + ",ImeKorisnika='" + ImeKorisnika + "', PrezimeKorisnika='" + PrezimeKorisnika + "',Username='" + Username + "',Password='" + Password + "'";
            }
        }

        

        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Korisnik k = new Korisnik();
            k.SifraKorisnika = Convert.ToInt32(red["SifraKorisnika"]);
            k.ImeKorisnika = red["ImeKorisnika"].ToString();
            k.PrezimeKorisnika = red["PrezimeKorisnika"].ToString();

            k.Username = red["Username"].ToString();
            k.Password = red["Password"].ToString();
            return k;
        }
        #endregion
    }
}
