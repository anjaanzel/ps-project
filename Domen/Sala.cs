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
    public class Sala: OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return imeSale; 
        }

        int sifraSale;
        string imeSale;
        string hotel;
        int sprat;
        string sponzor;

        public int SifraSale { get => sifraSale; set => sifraSale = value; }
        public string ImeSale { get => imeSale; set => imeSale = value; }
        public string Hotel { get => hotel; set => hotel = value; }
        public int Sprat { get => sprat; set => sprat = value; }
        public string Sponzor { get => sponzor; set => sponzor = value; }

        string sala;
        [DisplayName("Sala")]
        public string Sala1 { get => this.ToString(); set => sala = value; }

        #region ODO
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Sala";
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
                return "SifraSale";
            }
        }

        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "SifraSale=" + SifraSale;
            }
        }

        [Browsable(false)]
        public string Insert
        {
            get
            {
             
                return "(SifraSale) VALUES (" + SifraSale + ")";
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return " ImeSale='" + ImeSale + "', Hotel='" + Hotel + "', Sprat=" + Sprat + ", Sponzor='" + Sponzor + "'";
            }
        }

       

        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Sala s = new Sala();
            s.SifraSale= Convert.ToInt32(red["SifraSale"]);
            s.ImeSale = red["ImeSale"].ToString();
            s.Hotel = red["Hotel"].ToString();
            s.Sprat = Convert.ToInt32(red["Sprat"]);
            s.Sponzor = red["Sponzor"].ToString();
            return s;
        }

        #endregion ODO

    }
}
