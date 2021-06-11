
namespace Maquette
{
    partial class Magasin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Magasin));
            this.menu = new System.Windows.Forms.ToolStrip();
            this.lblEspace = new System.Windows.Forms.ToolStripLabel();
            this.barreMenu = new System.Windows.Forms.ToolStripSeparator();
            this.lblMagasin = new System.Windows.Forms.ToolStripLabel();
            this.barreRecherche = new System.Windows.Forms.TextBox();
            this.panelGrandDispo = new System.Windows.Forms.Panel();
            this.lblPageDispo = new System.Windows.Forms.Label();
            this.btnSuiDis = new System.Windows.Forms.Button();
            this.btnPreDis = new System.Windows.Forms.Button();
            this.panelDispo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDispo = new System.Windows.Forms.Label();
            this.pnlRecherche = new System.Windows.Forms.Panel();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.panelGrandDispo.SuspendLayout();
            this.pnlRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Teal;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEspace,
            this.barreMenu,
            this.lblMagasin});
            this.menu.Location = new System.Drawing.Point(41, 38);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(333, 48);
            this.menu.TabIndex = 10;
            this.menu.Text = "toolStrip1";
            // 
            // lblEspace
            // 
            this.lblEspace.ActiveLinkColor = System.Drawing.Color.Red;
            this.lblEspace.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEspace.Name = "lblEspace";
            this.lblEspace.Padding = new System.Windows.Forms.Padding(75, 25, 0, 0);
            this.lblEspace.Size = new System.Drawing.Size(167, 45);
            this.lblEspace.Text = "Mon espace";
            this.lblEspace.Click += new System.EventHandler(this.LblEspace_Click);
            // 
            // barreMenu
            // 
            this.barreMenu.BackColor = System.Drawing.Color.Yellow;
            this.barreMenu.ForeColor = System.Drawing.Color.Maroon;
            this.barreMenu.Name = "barreMenu";
            this.barreMenu.Size = new System.Drawing.Size(6, 48);
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
            // 
            // barreRecherche
            // 
            this.barreRecherche.Location = new System.Drawing.Point(41, 16);
            this.barreRecherche.Name = "barreRecherche";
            this.barreRecherche.Size = new System.Drawing.Size(236, 20);
            this.barreRecherche.TabIndex = 11;
            // 
            // panelGrandDispo
            // 
            this.panelGrandDispo.BackColor = System.Drawing.Color.Teal;
            this.panelGrandDispo.Controls.Add(this.lblPageDispo);
            this.panelGrandDispo.Controls.Add(this.btnSuiDis);
            this.panelGrandDispo.Controls.Add(this.btnPreDis);
            this.panelGrandDispo.Controls.Add(this.panelDispo);
            this.panelGrandDispo.Controls.Add(this.lblDispo);
            this.panelGrandDispo.Location = new System.Drawing.Point(41, 104);
            this.panelGrandDispo.Name = "panelGrandDispo";
            this.panelGrandDispo.Size = new System.Drawing.Size(1107, 548);
            this.panelGrandDispo.TabIndex = 16;
            // 
            // lblPageDispo
            // 
            this.lblPageDispo.AutoSize = true;
            this.lblPageDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageDispo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.lblPageDispo.Location = new System.Drawing.Point(532, 525);
            this.lblPageDispo.Name = "lblPageDispo";
            this.lblPageDispo.Size = new System.Drawing.Size(36, 13);
            this.lblPageDispo.TabIndex = 4;
            this.lblPageDispo.Text = "Page";
            // 
            // btnSuiDis
            // 
            this.btnSuiDis.BackgroundImage = global::Maquette.Properties.Resources.fleche_droite;
            this.btnSuiDis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuiDis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnSuiDis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuiDis.Location = new System.Drawing.Point(1029, 520);
            this.btnSuiDis.Name = "btnSuiDis";
            this.btnSuiDis.Size = new System.Drawing.Size(75, 23);
            this.btnSuiDis.TabIndex = 3;
            this.btnSuiDis.UseVisualStyleBackColor = true;
            this.btnSuiDis.Click += new System.EventHandler(this.BtnSuiDis_Click);
            // 
            // btnPreDis
            // 
            this.btnPreDis.BackgroundImage = global::Maquette.Properties.Resources.fleche_gauche;
            this.btnPreDis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreDis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnPreDis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreDis.Location = new System.Drawing.Point(3, 520);
            this.btnPreDis.Name = "btnPreDis";
            this.btnPreDis.Size = new System.Drawing.Size(75, 23);
            this.btnPreDis.TabIndex = 2;
            this.btnPreDis.UseVisualStyleBackColor = true;
            this.btnPreDis.Click += new System.EventHandler(this.BtnPreDis_Click);
            // 
            // panelDispo
            // 
            this.panelDispo.Location = new System.Drawing.Point(3, 40);
            this.panelDispo.Name = "panelDispo";
            this.panelDispo.Size = new System.Drawing.Size(1101, 474);
            this.panelDispo.TabIndex = 1;
            // 
            // lblDispo
            // 
            this.lblDispo.AutoSize = true;
            this.lblDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.lblDispo.Location = new System.Drawing.Point(3, 11);
            this.lblDispo.Name = "lblDispo";
            this.lblDispo.Size = new System.Drawing.Size(233, 26);
            this.lblDispo.TabIndex = 0;
            this.lblDispo.Text = "Albums disponibles :";
            // 
            // pnlRecherche
            // 
            this.pnlRecherche.BackColor = System.Drawing.Color.Teal;
            this.pnlRecherche.Controls.Add(this.btnRecherche);
            this.pnlRecherche.Controls.Add(this.barreRecherche);
            this.pnlRecherche.Location = new System.Drawing.Point(660, 38);
            this.pnlRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRecherche.Name = "pnlRecherche";
            this.pnlRecherche.Size = new System.Drawing.Size(358, 48);
            this.pnlRecherche.TabIndex = 17;
            // 
            // btnRecherche
            // 
            this.btnRecherche.BackColor = System.Drawing.Color.Teal;
            this.btnRecherche.BackgroundImage = global::Maquette.Properties.Resources.loupe;
            this.btnRecherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecherche.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecherche.Location = new System.Drawing.Point(303, 13);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(26, 25);
            this.btnRecherche.TabIndex = 12;
            this.btnRecherche.UseVisualStyleBackColor = false;
            this.btnRecherche.Click += new System.EventHandler(this.BtnRecherche_Click);
            // 
            // Magasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maquette.Properties.Resources.flou;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.pnlRecherche);
            this.Controls.Add(this.panelGrandDispo);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 720);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "Magasin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magasin";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panelGrandDispo.ResumeLayout(false);
            this.panelGrandDispo.PerformLayout();
            this.pnlRecherche.ResumeLayout(false);
            this.pnlRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripLabel lblEspace;
        private System.Windows.Forms.ToolStripSeparator barreMenu;
        private System.Windows.Forms.ToolStripLabel lblMagasin;
        private System.Windows.Forms.TextBox barreRecherche;
        private System.Windows.Forms.Panel panelGrandDispo;
        private System.Windows.Forms.Label lblPageDispo;
        private System.Windows.Forms.Button btnSuiDis;
        private System.Windows.Forms.Button btnPreDis;
        private System.Windows.Forms.FlowLayoutPanel panelDispo;
        private System.Windows.Forms.Label lblDispo;
        private System.Windows.Forms.Panel pnlRecherche;
        private System.Windows.Forms.Button btnRecherche;
    }
}