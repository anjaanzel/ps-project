using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domen
{
    [Serializable]
    public class Predavanje:OpstiDomenskiObjekat
    {


        Govornik govornik;
        Sala sala;
        DateTime satnica;
        string tema;
        DateTime trajanje;
        Raspored raspored;

        
        public Govornik Govornik { get => govornik; set => govornik = value; }

       
        public Sala Sala { get => sala; set => sala = value; }
        public string Tema { get => tema; set => tema = value; }


        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:ss}")]
        public DateTime Satnica { get => satnica; set => satnica = value; }


        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:ss}")]
        public DateTime Trajanje { get => trajanje; set => trajanje = value; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public Raspored Raspored { get => raspored; set => raspored = value; }


        #region ODO
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Predavanje";
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
                return "VALUES (" + Govornik.SifraGovornika + "," + Sala.SifraSale + ",'" + Satnica.ToString("HH:mm") + "','" + Tema + "','" + Trajanje.ToString("HH:mm") + "'," + Raspored.SifraRasporeda + ")";
            }
        }

        [Browsable(false)]
        public string ID
        {
            get
            {
                return null;
            }
        }

        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "SifraGovornika=" + Govornik.SifraGovornika + "and SifraSale=" + Sala.SifraSale;
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return "SifraGovornika=" + Govornik.SifraGovornika + ", SifraSale=" + Sala.SifraSale + ",Satnica='" + Satnica.ToString("HH:mm") + "', Tema='" + Tema + "', Trajanje='" + Trajanje.ToString("HH:mm") + "', SifraRasporeda=" + Raspored.SifraRasporeda;
            }
        }

        

        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Predavanje p = new Predavanje();
            p.Govornik = new Govornik();
            p.Govornik.SifraGovornika = Convert.ToInt32(red["SifraGovornika"]);
            p.Sala = new Sala();
            p.Sala.SifraSale = Convert.ToInt32(red["SifraSale"]);
            p.Satnica = Convert.ToDateTime(red["Satnica"]);
            p.Tema = red["Tema"].ToString();
            p.Trajanje = Convert.ToDateTime(red["Trajanje"]);
            p.Raspored = new Raspored();
            p.Raspored.SifraRasporeda = Convert.ToInt32(red["SifraRasporeda"]);
            
            return p;
        }


        #endregion ODO
    }
}
