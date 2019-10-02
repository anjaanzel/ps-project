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
    public class Govornik : OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return imeGovornika + " " + prezimeGovornika;
        }

        int sifraGovornika;
        string imeGovornika;
        string prezimeGovornika;
        string pol;
        int stepenStrucneSpreme;
        string kompanija;
        string email;
        Zemlja zemlja;

        [Browsable(false)]
        public int SifraGovornika { get => sifraGovornika; set => sifraGovornika = value; }
        [DisplayName("Ime")]
        public string ImeGovornika { get => imeGovornika; set => imeGovornika = value; }
        [DisplayName("Prezime")]
        public string PrezimeGovornika { get => prezimeGovornika; set => prezimeGovornika = value; }
        public string Pol { get => pol; set => pol = value; }
        [DisplayName("SSS")]
        public int StepenStrucneSpreme { get => stepenStrucneSpreme; set => stepenStrucneSpreme = value; }
        public string Kompanija { get => kompanija; set => kompanija = value; }
        public string Email { get => email; set => email = value; }
      
        public Zemlja Zemlja { get => zemlja; set => zemlja = value; }


        #region ODO
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Govornik";
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
        public string Insert
        {
            get
            {
                return "(SifraGovornika) VALUES (" + SifraGovornika + ")";
            }
        }

        [Browsable(false)]
        public string ID
        {
            get
            {
                return "SifraGovornika";
            }
        }

        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "SifraGovornika=" + SifraGovornika;
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return " ImeGovornika='" + ImeGovornika + "',PrezimeGovornika='" + PrezimeGovornika + "',Pol='" + Pol + "',StepenStrucneSpreme=" + StepenStrucneSpreme + ",Kompanija='" + Kompanija + "',Email='" + Email + "',SifraZemlje='" + Zemlja.SifraZemlje + "'";
            }
        }

        

        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Govornik g = new Govornik();
            g.SifraGovornika = Convert.ToInt32(red["SifraGovornika"]);
            g.ImeGovornika = red["ImeGovornika"].ToString();
            g.PrezimeGovornika = red["PrezimeGovornika"].ToString();
            g.Pol = red["Pol"].ToString();
            g.StepenStrucneSpreme = Convert.ToInt32(red["StepenStrucneSpreme"]);
            g.Kompanija = red["Kompanija"].ToString();
            g.Email = red["Email"].ToString();

            g.Zemlja = new Zemlja();
            g.Zemlja.SifraZemlje = Convert.ToInt32(red["SifraZemlje"]);
            return g;
        }


        #endregion ODO
    }
}
