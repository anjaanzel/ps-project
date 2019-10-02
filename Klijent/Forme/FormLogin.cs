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
    public partial class FormLogin : Form
    {
        KontrolerKI kontroler = new KontrolerKI();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void TextBox8_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            textBox8.PasswordChar = '●';

        }

       

        

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Text = KontrolerKI.poveziSeNaServer();
            
            if (kontroler.pronadjiKorisnika(textBox1, textBox8))
            {
                new FrmGlavna().ShowDialog();
                this.Hide();
            }
        }
    }
}
