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
    public partial class FrmDodajRaspored : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public FrmDodajRaspored()
        {
            InitializeComponent();
        }

       
        private void Button2_Click(object sender, EventArgs e)
        {
            kki.kreirajRaspored(txtID, button2, groupBox1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (kki.zapamtiRaspored(dateTimePicker1, textBox1, textBox2)) this.Close();
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
