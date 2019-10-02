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
    public class Zemlja : OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return nazivZemlje;
        }

        int sifraZemlje;
        string nazivZemlje;

        public int SifraZemlje { get => sifraZemlje; set => sifraZemlje = value; }
        public string NazivZemlje { get => nazivZemlje; set => nazivZemlje = value; }


        #region ODO
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Zemlja";
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
        public string Insert
        {
            get
            {
                return "(SifraZemlje) values (" + SifraZemlje + ")";
            }
        }

        [Browsable(false)]
        public string ID
        {
            get
            {
                return "SifraZemlje";
            }
        }

        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "SifraZemlje=" + SifraZemlje;
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return "SifraZemlje=" + SifraZemlje + ",NazivZemlje='" + NazivZemlje + "'";
            }
        }

       

        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Zemlja z = new Zemlja();
            z.SifraZemlje = Convert.ToInt32(red["SifraZemlje"]);
            z.NazivZemlje = red["NazivZemlje"].ToString();
            return z;
        }


        #endregion ODO
    }
}
