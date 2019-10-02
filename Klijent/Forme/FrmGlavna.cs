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
    public partial class FrmGlavna : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public FrmGlavna()
        {
            InitializeComponent();
            panel3.Hide();
            panel6.Hide();
           
            
        }

      

        private void BtnRaspored_Click(object sender, EventArgs e)
        {
            new FrmDodajRaspored().ShowDialog();
            panel3.Hide();
            panel6.Hide();

        }

        private void BtnPredavanja_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel6.Show();
        }

        private void BtnSala_Click(object sender, EventArgs e)
        {
            new FrmDodavanjeSale().ShowDialog();
            panel3.Hide();
            panel6.Hide();



        }


       
        private void BtnPredavaci_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel6.Hide();



        }


       

        private void BtnDodajPredavaca_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel6.Hide();
        }

        private void BtnPretragaPredavaca_Click_1(object sender, EventArgs e)
        {
            panel3.Hide();
            panel6.Hide();


        }

        private void BtnPretragaPredavaca_Click(object sender, EventArgs e)
        {
            new FrmPretragaPredavaca().ShowDialog();
            panel3.Hide();
        }

        private void BtnDodajPredavaca_Click_1(object sender, EventArgs e)
        {
            new FrmDodavanjePredavaca().ShowDialog();
            panel3.Hide();
        }

        private void BtnPretraziPredavanja_Click(object sender, EventArgs e)
        {
            new FrmPretragaPredavanja().ShowDialog();
            panel6.Hide();
        }

        private void BtnDodajPredavanja_Click(object sender, EventArgs e)
        {
            new FrmDodavanjePredavanja().ShowDialog();
            panel6.Hide();
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            this.Close();
            kki.kraj();
        }
    }
}
