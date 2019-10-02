using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmDodavanjePredavaca : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public FrmDodavanjePredavaca()
        {
            InitializeComponent();
        }

        private void BtnKreirajP_Click(object sender, EventArgs e)
        {
            kki.kreirajPredavaca(txtID, btnKreirajP, gbDetaljiP, cmbZemlja);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          if (kki.zapamtiPredavaca(txtImeP, txtPrezimeP, txtSSS, txtEmail, txtKompanija, cmbZemlja, rbMuski, rbZenski)) this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void GbDetaljiP_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void RbMuski_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbZenski_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDodavanjePredavaca_Load(object sender, EventArgs e)
        {
            cmbZemlja.Text = "Izaberite zemlju";
        }
    }
}
