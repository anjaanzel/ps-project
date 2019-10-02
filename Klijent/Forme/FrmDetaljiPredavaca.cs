using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Forme
{
    
    public partial class FrmDetaljiPredavaca : Form
    {
        private KontrolerKI kki = new KontrolerKI();
        //private Govornik govornik;
       
        public FrmDetaljiPredavaca()
        {
            InitializeComponent();
           // this.govornik = govornik;
    
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (kki.zapamtiPredavaca(txtImeP, txtPrezimeP, txtSSS, txtEmail, txtKompanija, cmbZemlja, rbMuski, rbZenski)) this.Close();
        }

        private void FrmDetaljiPredavaca_Load(object sender, EventArgs e)
        {
            kki.popuniPoljaPredavac(txtImeP, txtPrezimeP, txtID, txtSSS, cmbZemlja, txtKompanija, txtEmail, rbMuski, rbZenski);

        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
