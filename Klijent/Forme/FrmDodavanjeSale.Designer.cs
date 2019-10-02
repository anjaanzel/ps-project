namespace Klijent
{
    partial class FrmDodavanjeSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodavanjeSale));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnKreirajSalu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtImeSale = new System.Windows.Forms.TextBox();
            this.txtSprat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSponzor = new System.Windows.Forms.TextBox();
            this.txtHotel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDodavanjeRasporeda = new System.Windows.Forms.Panel();
            this.btnPower = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlDodavanjeRasporeda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btnPower);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 34);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(47, 85);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(137, 20);
            this.txtID.TabIndex = 20;
            // 
            // btnKreirajSalu
            // 
            this.btnKreirajSalu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnKreirajSalu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajSalu.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajSalu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKreirajSalu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKreirajSalu.Location = new System.Drawing.Point(251, 70);
            this.btnKreirajSalu.Margin = new System.Windows.Forms.Padding(2);
            this.btnKreirajSalu.Name = "btnKreirajSalu";
            this.btnKreirajSalu.Size = new System.Drawing.Size(278, 47);
            this.btnKreirajSalu.TabIndex = 21;
            this.btnKreirajSalu.Text = "Kreiraj novu salu";
            this.btnKreirajSalu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKreirajSalu.UseVisualStyleBackColor = false;
            this.btnKreirajSalu.Click += new System.EventHandler(this.BtnKreirajSalu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.groupBox1.Controls.Add(this.txtImeSale);
            this.groupBox1.Controls.Add(this.txtSprat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSponzor);
            this.groupBox1.Controls.Add(this.txtHotel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(11, 121);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(518, 313);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalji o rasporedu";
            // 
            // txtImeSale
            // 
            this.txtImeSale.Location = new System.Drawing.Point(176, 56);
            this.txtImeSale.Margin = new System.Windows.Forms.Padding(2);
            this.txtImeSale.Name = "txtImeSale";
            this.txtImeSale.Size = new System.Drawing.Size(310, 22);
            this.txtImeSale.TabIndex = 24;
            // 
            // txtSprat
            // 
            this.txtSprat.Location = new System.Drawing.Point(176, 135);
            this.txtSprat.Margin = new System.Windows.Forms.Padding(2);
            this.txtSprat.Name = "txtSprat";
            this.txtSprat.Size = new System.Drawing.Size(310, 22);
            this.txtSprat.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(27, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sprat:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(31, 236);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(455, 47);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sačuvaj salu";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtSponzor
            // 
            this.txtSponzor.Location = new System.Drawing.Point(176, 176);
            this.txtSponzor.Margin = new System.Windows.Forms.Padding(2);
            this.txtSponzor.Name = "txtSponzor";
            this.txtSponzor.Size = new System.Drawing.Size(310, 22);
            this.txtSponzor.TabIndex = 21;
            // 
            // txtHotel
            // 
            this.txtHotel.Location = new System.Drawing.Point(176, 96);
            this.txtHotel.Margin = new System.Windows.Forms.Padding(2);
            this.txtHotel.Name = "txtHotel";
            this.txtHotel.Size = new System.Drawing.Size(310, 22);
            this.txtHotel.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ime sale:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(27, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hotel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(27, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sponzor:";
            // 
            // pnlDodavanjeRasporeda
            // 
            this.pnlDodavanjeRasporeda.Controls.Add(this.groupBox1);
            this.pnlDodavanjeRasporeda.Controls.Add(this.btnKreirajSalu);
            this.pnlDodavanjeRasporeda.Controls.Add(this.txtID);
            this.pnlDodavanjeRasporeda.Controls.Add(this.label1);
            this.pnlDodavanjeRasporeda.Location = new System.Drawing.Point(0, 8);
            this.pnlDodavanjeRasporeda.Name = "pnlDodavanjeRasporeda";
            this.pnlDodavanjeRasporeda.Size = new System.Drawing.Size(540, 449);
            this.pnlDodavanjeRasporeda.TabIndex = 4;
            // 
            // btnPower
            // 
            this.btnPower.FlatAppearance.BorderSize = 0;
            this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPower.Image = ((System.Drawing.Image)(resources.GetObject("btnPower.Image")));
            this.btnPower.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPower.Location = new System.Drawing.Point(503, -3);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(46, 40);
            this.btnPower.TabIndex = 1;
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.BtnPower_Click);
            // 
            // FrmDodavanjeSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(540, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDodavanjeRasporeda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDodavanjeSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDodavanjeSale";
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlDodavanjeRasporeda.ResumeLayout(false);
            this.pnlDodavanjeRasporeda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Button btnKreirajSalu;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtImeSale;
        public System.Windows.Forms.TextBox txtSprat;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtSponzor;
        public System.Windows.Forms.TextBox txtHotel;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDodavanjeRasporeda;
        private System.Windows.Forms.Button btnPower;
    }
}