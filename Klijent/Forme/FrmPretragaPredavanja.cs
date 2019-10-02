using Klijent.Forme;
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
    public partial class FrmPretragaPredavanja : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public FrmPretragaPredavanja()
        {
            InitializeComponent();
        }

        private void FrmPretragaPredavanja_Load(object sender, EventArgs e)
        {
            kki.pretraziPredavanja(txtFilter, dgvPredavanja);
            dgvPredavanja.Columns["Trajanje"].DefaultCellStyle.Format = "H:mm";
            dgvPredavanja.Columns["Satnica"].DefaultCellStyle.Format = "HH:mm";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (kki.pronadjiPredavanje(dgvPredavanja)) new FrmDetaljiPredavanja().ShowDialog();
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            kki.pretraziPredavanja(txtFilter, dgvPredavanja);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            kki.obrisiPredavanje(dgvPredavanja);
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
