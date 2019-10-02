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
    public partial class FrmDetaljiPredavanja : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public FrmDetaljiPredavanja()
        {
            InitializeComponent();
        }

        private void FrmDetaljiPredavanja_Load(object sender, EventArgs e)
        {
            kki.popuniPoljaPredavanje(txtTema, cmbPredavac, cmbSala, txtTrajanje, txtVremePocetka, cmbRaspored);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (kki.azurirajPredavanje(txtTema, cmbPredavac, cmbSala, txtTrajanje, txtVremePocetka, cmbRaspored)) this.Close();
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
