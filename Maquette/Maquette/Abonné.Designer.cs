
namespace Maquette
{
    partial class Abonné
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblEspace = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblMagasin = new System.Windows.Forms.ToolStripLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPageSui = new System.Windows.Forms.Button();
            this.btnPagePre = new System.Windows.Forms.Button();
            this.panelEmprunts = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmprunt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblConseil = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblBvn = new System.Windows.Forms.Label();
            this.lblPageEmp = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(967, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(967, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(852, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Allonger délai";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(852, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Allonger tous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(970, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Emprunter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(852, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 23);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Teal;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEspace,
            this.toolStripSeparator1,
            this.lblMagasin});
            this.toolStrip1.Location = new System.Drawing.Point(41, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(333, 48);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblEspace
            // 
            this.lblEspace.ActiveLinkColor = System.Drawing.Color.Red;
            this.lblEspace.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.lblEspace.Name = "lblEspace";
            this.lblEspace.Padding = new System.Windows.Forms.Padding(75, 25, 0, 0);
            this.lblEspace.Size = new System.Drawing.Size(167, 45);
            this.lblEspace.Text = "Mon espace";
            this.lblEspace.Click += new System.EventHandler(this.lblEspace_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Yellow;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // lblMagasin
            // 
            this.lblMagasin.AutoSize = false;
            this.lblMagasin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMagasin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.lblMagasin.Name = "lblMagasin";
            this.lblMagasin.Padding = new System.Windows.Forms.Padding(75, 25, 0, 0);
            this.lblMagasin.Size = new System.Drawing.Size(148, 40);
            this.lblMagasin.Text = "Magasin";
            this.lblMagasin.Click += new System.EventHandler(this.lblMagasin_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(440, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(579, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 11;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(717, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 95);
            this.listBox3.TabIndex = 12;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 681);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 681);
            this.splitter2.TabIndex = 14;
            this.splitter2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblPageEmp);
            this.panel1.Controls.Add(this.btnPageSui);
            this.panel1.Controls.Add(this.btnPagePre);
            this.panel1.Controls.Add(this.panelEmprunts);
            this.panel1.Controls.Add(this.lblEmprunt);
            this.panel1.Location = new System.Drawing.Point(41, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 548);
            this.panel1.TabIndex = 15;
            // 
            // btnPageSui
            // 
            this.btnPageSui.Location = new System.Drawing.Point(441, 520);
            this.btnPageSui.Name = "btnPageSui";
            this.btnPageSui.Size = new System.Drawing.Size(75, 23);
            this.btnPageSui.TabIndex = 3;
            this.btnPageSui.Text = "Suivant";
            this.btnPageSui.UseVisualStyleBackColor = true;
            this.btnPageSui.Click += new System.EventHandler(this.btnPageSui_Click);
            // 
            // btnPagePre
            // 
            this.btnPagePre.Location = new System.Drawing.Point(8, 520);
            this.btnPagePre.Name = "btnPagePre";
            this.btnPagePre.Size = new System.Drawing.Size(75, 23);
            this.btnPagePre.TabIndex = 2;
            this.btnPagePre.Text = "Précédent";
            this.btnPagePre.UseVisualStyleBackColor = true;
            this.btnPagePre.Click += new System.EventHandler(this.btnPagePre_Click);
            // 
            // panelEmprunts
            // 
            this.panelEmprunts.Location = new System.Drawing.Point(3, 40);
            this.panelEmprunts.Name = "panelEmprunts";
            this.panelEmprunts.Size = new System.Drawing.Size(513, 474);
            this.panelEmprunts.TabIndex = 1;
            // 
            // lblEmprunt
            // 
            this.lblEmprunt.AutoSize = true;
            this.lblEmprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmprunt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.lblEmprunt.Location = new System.Drawing.Point(3, 11);
            this.lblEmprunt.Name = "lblEmprunt";
            this.lblEmprunt.Size = new System.Drawing.Size(225, 26);
            this.lblEmprunt.TabIndex = 0;
            this.lblEmprunt.Text = "Albums empruntés :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.lblConseil);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblNom);
            this.panel2.Controls.Add(this.lblBvn);
            this.panel2.Location = new System.Drawing.Point(625, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 548);
            this.panel2.TabIndex = 16;
            // 
            // lblConseil
            // 
            this.lblConseil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConseil.Location = new System.Drawing.Point(17, 82);
            this.lblConseil.Name = "lblConseil";
            this.lblConseil.Size = new System.Drawing.Size(164, 59);
            this.lblConseil.TabIndex = 3;
            this.lblConseil.Text = "Conseils de la maison :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Maquette.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(284, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(49)))), ((int)(((byte)(0)))));
            this.lblNom.Location = new System.Drawing.Point(147, 34);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(62, 26);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // lblBvn
            // 
            this.lblBvn.AutoSize = true;
            this.lblBvn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBvn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.lblBvn.Location = new System.Drawing.Point(17, 34);
            this.lblBvn.Name = "lblBvn";
            this.lblBvn.Size = new System.Drawing.Size(124, 26);
            this.lblBvn.TabIndex = 0;
            this.lblBvn.Text = "Bienvenue";
            // 
            // lblPageEmp
            // 
            this.lblPageEmp.AutoSize = true;
            this.lblPageEmp.Location = new System.Drawing.Point(214, 525);
            this.lblPageEmp.Name = "lblPageEmp";
            this.lblPageEmp.Size = new System.Drawing.Size(32, 13);
            this.lblPageEmp.TabIndex = 4;
            this.lblPageEmp.Text = "Page";
            // 
            // Abonné
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maquette.Properties.Resources.flou;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "Abonné";
            this.Text = "Abonné";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblEspace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblMagasin;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmprunt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblConseil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblBvn;
        private System.Windows.Forms.FlowLayoutPanel panelEmprunts;
        private System.Windows.Forms.Button btnPageSui;
        private System.Windows.Forms.Button btnPagePre;
        private System.Windows.Forms.Label lblPageEmp;
    }
}