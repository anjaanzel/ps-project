using Domen;
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
    public partial class FrmPretragaPredavaca : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public FrmPretragaPredavaca()
        {
            InitializeComponent();
        }

        private void FrmPretragaPredavaca_Load(object sender, EventArgs e)
        {
            kki.pretraziPredavace(txtFilter, dgvPredavac);
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            kki.pretraziPredavace(txtFilter, dgvPredavac);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            if(kki.pronadjiPredavaca(dgvPredavac)) new FrmDetaljiPredavaca().ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
            kki.obrisiGovornika(dgvPredavac);
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
