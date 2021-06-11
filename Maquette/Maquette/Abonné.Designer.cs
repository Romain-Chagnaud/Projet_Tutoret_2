
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abonné));
            this.btnToutAlg = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.ToolStrip();
            this.lblEspace = new System.Windows.Forms.ToolStripLabel();
            this.separeMenu = new System.Windows.Forms.ToolStripSeparator();
            this.lblMagasin = new System.Windows.Forms.ToolStripLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelGrandEmprunt = new System.Windows.Forms.Panel();
            this.lblPageEmp = new System.Windows.Forms.Label();
            this.btnSuiEmp = new System.Windows.Forms.Button();
            this.btnPreEmp = new System.Windows.Forms.Button();
            this.panelEmprunts = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmprunt = new System.Windows.Forms.Label();
            this.panelGrandConseils = new System.Windows.Forms.Panel();
            this.panelConseil = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPageReco = new System.Windows.Forms.Label();
            this.btnSuiCon = new System.Windows.Forms.Button();
            this.btnPreCon = new System.Windows.Forms.Button();
            this.lblConseil = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblBvn = new System.Windows.Forms.Label();
            this.lblPasSugg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCompte = new System.Windows.Forms.Button();
            this.lblCompte = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.panelGrandEmprunt.SuspendLayout();
            this.panelGrandConseils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToutAlg
            // 
            this.btnToutAlg.BackColor = System.Drawing.Color.Teal;
            this.btnToutAlg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToutAlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToutAlg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnToutAlg.Location = new System.Drawing.Point(399, 8);
            this.btnToutAlg.Name = "btnToutAlg";
            this.btnToutAlg.Size = new System.Drawing.Size(117, 29);
            this.btnToutAlg.TabIndex = 5;
            this.btnToutAlg.Text = "Allonger tous";
            this.btnToutAlg.UseVisualStyleBackColor = false;
            this.btnToutAlg.Click += new System.EventHandler(this.BtnToutAlg_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Teal;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEspace,
            this.separeMenu,
            this.lblMagasin});
            this.menu.Location = new System.Drawing.Point(41, 38);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(333, 48);
            this.menu.TabIndex = 9;
            this.menu.Text = "toolStrip1";
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
            // 
            // separeMenu
            // 
            this.separeMenu.BackColor = System.Drawing.Color.Yellow;
            this.separeMenu.ForeColor = System.Drawing.Color.Maroon;
            this.separeMenu.Name = "separeMenu";
            this.separeMenu.Size = new System.Drawing.Size(6, 48);
            // 
            // lblMagasin
            // 
            this.lblMagasin.AutoSize = false;
            this.lblMagasin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMagasin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMagasin.Name = "lblMagasin";
            this.lblMagasin.Padding = new System.Windows.Forms.Padding(75, 25, 0, 0);
            this.lblMagasin.Size = new System.Drawing.Size(148, 40);
            this.lblMagasin.Text = "Magasin";
            this.lblMagasin.Click += new System.EventHandler(this.LblMagasin_Click);
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
            // panelGrandEmprunt
            // 
            this.panelGrandEmprunt.BackColor = System.Drawing.Color.Teal;
            this.panelGrandEmprunt.Controls.Add(this.lblPageEmp);
            this.panelGrandEmprunt.Controls.Add(this.btnSuiEmp);
            this.panelGrandEmprunt.Controls.Add(this.btnPreEmp);
            this.panelGrandEmprunt.Controls.Add(this.panelEmprunts);
            this.panelGrandEmprunt.Controls.Add(this.lblEmprunt);
            this.panelGrandEmprunt.Controls.Add(this.btnToutAlg);
            this.panelGrandEmprunt.Location = new System.Drawing.Point(41, 105);
            this.panelGrandEmprunt.Name = "panelGrandEmprunt";
            this.panelGrandEmprunt.Size = new System.Drawing.Size(519, 548);
            this.panelGrandEmprunt.TabIndex = 15;
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
            // btnSuiEmp
            // 
            this.btnSuiEmp.BackgroundImage = global::Maquette.Properties.Resources.fleche_droite;
            this.btnSuiEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuiEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnSuiEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuiEmp.Location = new System.Drawing.Point(441, 520);
            this.btnSuiEmp.Name = "btnSuiEmp";
            this.btnSuiEmp.Size = new System.Drawing.Size(75, 23);
            this.btnSuiEmp.TabIndex = 3;
            this.btnSuiEmp.UseVisualStyleBackColor = true;
            this.btnSuiEmp.Click += new System.EventHandler(this.BtnPageSui_Click);
            // 
            // btnPreEmp
            // 
            this.btnPreEmp.BackgroundImage = global::Maquette.Properties.Resources.fleche_gauche;
            this.btnPreEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnPreEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreEmp.Location = new System.Drawing.Point(8, 520);
            this.btnPreEmp.Name = "btnPreEmp";
            this.btnPreEmp.Size = new System.Drawing.Size(75, 23);
            this.btnPreEmp.TabIndex = 2;
            this.btnPreEmp.UseVisualStyleBackColor = true;
            this.btnPreEmp.Click += new System.EventHandler(this.BtnPagePre_Click);
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
            // panelGrandConseils
            // 
            this.panelGrandConseils.BackColor = System.Drawing.Color.Teal;
            this.panelGrandConseils.Controls.Add(this.panelConseil);
            this.panelGrandConseils.Controls.Add(this.lblPageReco);
            this.panelGrandConseils.Controls.Add(this.btnSuiCon);
            this.panelGrandConseils.Controls.Add(this.btnPreCon);
            this.panelGrandConseils.Controls.Add(this.lblConseil);
            this.panelGrandConseils.Controls.Add(this.imgLogo);
            this.panelGrandConseils.Controls.Add(this.lblNom);
            this.panelGrandConseils.Controls.Add(this.lblBvn);
            this.panelGrandConseils.Location = new System.Drawing.Point(625, 105);
            this.panelGrandConseils.Name = "panelGrandConseils";
            this.panelGrandConseils.Size = new System.Drawing.Size(519, 548);
            this.panelGrandConseils.TabIndex = 16;
            // 
            // panelConseil
            // 
            this.panelConseil.Location = new System.Drawing.Point(3, 147);
            this.panelConseil.Name = "panelConseil";
            this.panelConseil.Size = new System.Drawing.Size(513, 369);
            this.panelConseil.TabIndex = 6;
            // 
            // lblPageReco
            // 
            this.lblPageReco.AutoSize = true;
            this.lblPageReco.Location = new System.Drawing.Point(265, 525);
            this.lblPageReco.Name = "lblPageReco";
            this.lblPageReco.Size = new System.Drawing.Size(32, 13);
            this.lblPageReco.TabIndex = 5;
            this.lblPageReco.Text = "Page";
            // 
            // btnSuiCon
            // 
            this.btnSuiCon.BackgroundImage = global::Maquette.Properties.Resources.fleche_droite;
            this.btnSuiCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuiCon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnSuiCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuiCon.Location = new System.Drawing.Point(428, 520);
            this.btnSuiCon.Name = "btnSuiCon";
            this.btnSuiCon.Size = new System.Drawing.Size(75, 23);
            this.btnSuiCon.TabIndex = 5;
            this.btnSuiCon.UseVisualStyleBackColor = true;
            this.btnSuiCon.Click += new System.EventHandler(this.BtnSuiCon_Click);
            // 
            // btnPreCon
            // 
            this.btnPreCon.BackgroundImage = global::Maquette.Properties.Resources.fleche_gauche;
            this.btnPreCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreCon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnPreCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreCon.Location = new System.Drawing.Point(13, 520);
            this.btnPreCon.Name = "btnPreCon";
            this.btnPreCon.Size = new System.Drawing.Size(75, 23);
            this.btnPreCon.TabIndex = 5;
            this.btnPreCon.UseVisualStyleBackColor = true;
            this.btnPreCon.Click += new System.EventHandler(this.BtnPreCon_Click);
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
            // imgLogo
            // 
            this.imgLogo.ErrorImage = null;
            this.imgLogo.Image = global::Maquette.Properties.Resources.logo;
            this.imgLogo.Location = new System.Drawing.Point(284, -6);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(175, 147);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
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
            // lblPasSugg
            // 
            this.lblPasSugg.BackColor = System.Drawing.Color.Teal;
            this.lblPasSugg.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasSugg.Location = new System.Drawing.Point(598, 630);
            this.lblPasSugg.Name = "lblPasSugg";
            this.lblPasSugg.Size = new System.Drawing.Size(24, 23);
            this.lblPasSugg.TabIndex = 0;
            this.lblPasSugg.Text = "Aucun album emprunté, aucune suggestion possible";
            this.lblPasSugg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPasSugg.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnCompte);
            this.panel1.Controls.Add(this.lblCompte);
            this.panel1.Location = new System.Drawing.Point(865, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 55);
            this.panel1.TabIndex = 17;
            // 
            // btnCompte
            // 
            this.btnCompte.BackgroundImage = global::Maquette.Properties.Resources.user;
            this.btnCompte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompte.ForeColor = System.Drawing.Color.Teal;
            this.btnCompte.Location = new System.Drawing.Point(177, 4);
            this.btnCompte.Name = "btnCompte";
            this.btnCompte.Size = new System.Drawing.Size(42, 49);
            this.btnCompte.TabIndex = 1;
            this.btnCompte.UseVisualStyleBackColor = true;
            this.btnCompte.Click += new System.EventHandler(this.BtnCompte_Click);
            // 
            // lblCompte
            // 
            this.lblCompte.AutoSize = true;
            this.lblCompte.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCompte.Location = new System.Drawing.Point(24, 17);
            this.lblCompte.Name = "lblCompte";
            this.lblCompte.Size = new System.Drawing.Size(106, 20);
            this.lblCompte.TabIndex = 0;
            this.lblCompte.Text = "Mon compte :";
            // 
            // Abonné
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maquette.Properties.Resources.flou;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPasSugg);
            this.Controls.Add(this.panelGrandConseils);
            this.Controls.Add(this.panelGrandEmprunt);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Abonné";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abonné";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panelGrandEmprunt.ResumeLayout(false);
            this.panelGrandEmprunt.PerformLayout();
            this.panelGrandConseils.ResumeLayout(false);
            this.panelGrandConseils.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnToutAlg;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripLabel lblEspace;
        private System.Windows.Forms.ToolStripSeparator separeMenu;
        private System.Windows.Forms.ToolStripLabel lblMagasin;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panelGrandEmprunt;
        private System.Windows.Forms.Label lblEmprunt;
        private System.Windows.Forms.Panel panelGrandConseils;
        private System.Windows.Forms.Label lblConseil;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblBvn;
        private System.Windows.Forms.FlowLayoutPanel panelEmprunts;
        private System.Windows.Forms.Button btnSuiEmp;
        private System.Windows.Forms.Button btnPreEmp;
        private System.Windows.Forms.Label lblPageEmp;
        private System.Windows.Forms.Label lblPageReco;
        private System.Windows.Forms.Button btnSuiCon;
        private System.Windows.Forms.Button btnPreCon;
        private System.Windows.Forms.Label lblPasSugg;
        private System.Windows.Forms.FlowLayoutPanel panelConseil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCompte;
        private System.Windows.Forms.Button btnCompte;
    }
}