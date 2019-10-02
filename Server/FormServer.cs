using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FormServer : Form
    {
        Server s;
        public FormServer()
        {
            
            InitializeComponent();
            btnZaustavi.Enabled = false;
            label2.Text = "Server je isključen!";
        }

        

        private void BtnPower_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPokreni_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.pokreniServer())
            {
                label2.Text = "Server je pokrenut!";
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
            }
        }

        private void BtnZaustavi_Click(object sender, EventArgs e)
        {
            if (s.zaustaviServer())
            {
                label2.Text = "Server je isključen!";
                btnPokreni.Enabled = true;
                btnZaustavi.Enabled = false;
            }
        }

        
    }
}
