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

namespace Klijent
{
    public partial class FrmDodavanjePredavanja : Form
    {
        KontrolerKI kki = new KontrolerKI();
        BindingList<Predavanje> predavanja = new BindingList<Predavanje>();
        public FrmDodavanjePredavanja()
        {
            InitializeComponent();
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            
            
            predavanja.Add(kki.zapamtiPredavanje(txtTema, cmbPredavac, cmbSala, txtTrajanje, txtVremePocetka, cmbRaspored, dataGridView1));
           
            
            dataGridView1.Refresh();
            
        



        }

        private void FrmDodavanjePredavanja_Load(object sender, EventArgs e)
        {
            kki.ucitajListuPredavaca(cmbPredavac);
            cmbPredavac.Text = "Izaberite predavača";

            kki.ucitajListuSala(cmbSala);
            cmbSala.Text = "Izaberite salu";

            kki.ucitajListuRasporeda(cmbRaspored);
            cmbRaspored.Text = "Izaberite raspored";
            dataGridView1.DataSource = predavanja;

        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(kki.zapamtiSvaPredavanja(predavanja.ToList()))
            { 
            this.Close();
            }
        }
    }
}
