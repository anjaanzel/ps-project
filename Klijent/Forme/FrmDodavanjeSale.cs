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
    public partial class FrmDodavanjeSale : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public FrmDodavanjeSale()
        {
            InitializeComponent();
        }


        private void BtnKreirajSalu_Click(object sender, EventArgs e)
        {
            kki.kreirajSalu(txtID, btnKreirajSalu, groupBox1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (kki.zapamtiSalu(txtImeSale, txtHotel, txtSprat, txtSponzor)) this.Close();
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
