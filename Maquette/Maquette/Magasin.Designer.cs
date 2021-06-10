
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblEspace = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblMagasin = new System.Windows.Forms.ToolStripLabel();
            this.barreRecherche = new System.Windows.Forms.TextBox();
            this.panelGrandEmprunt = new System.Windows.Forms.Panel();
            this.lblPageDispo = new System.Windows.Forms.Label();
            this.btnSuiDis = new System.Windows.Forms.Button();
            this.btnPreDis = new System.Windows.Forms.Button();
            this.panelDispo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDispo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panelGrandEmprunt.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
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
            // 
            // barreRecherche
            // 
            this.barreRecherche.Location = new System.Drawing.Point(41, 16);
            this.barreRecherche.Name = "barreRecherche";
            this.barreRecherche.Size = new System.Drawing.Size(236, 20);
            this.barreRecherche.TabIndex = 11;
            // 
            // panelGrandEmprunt
            // 
            this.panelGrandEmprunt.BackColor = System.Drawing.Color.Teal;
            this.panelGrandEmprunt.Controls.Add(this.lblPageDispo);
            this.panelGrandEmprunt.Controls.Add(this.btnSuiDis);
            this.panelGrandEmprunt.Controls.Add(this.btnPreDis);
            this.panelGrandEmprunt.Controls.Add(this.panelDispo);
            this.panelGrandEmprunt.Controls.Add(this.lblDispo);
            this.panelGrandEmprunt.Location = new System.Drawing.Point(41, 104);
            this.panelGrandEmprunt.Name = "panelGrandEmprunt";
            this.panelGrandEmprunt.Size = new System.Drawing.Size(1107, 548);
            this.panelGrandEmprunt.TabIndex = 16;
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
            this.btnSuiDis.Click += new System.EventHandler(this.btnSuiDis_Click);
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
            this.btnPreDis.Click += new System.EventHandler(this.btnPreDis_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnRecherche);
            this.panel1.Controls.Add(this.barreRecherche);
            this.panel1.Location = new System.Drawing.Point(660, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 48);
            this.panel1.TabIndex = 17;
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
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // Magasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maquette.Properties.Resources.flou;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGrandEmprunt);
            this.Controls.Add(this.toolStrip1);
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelGrandEmprunt.ResumeLayout(false);
            this.panelGrandEmprunt.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblEspace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblMagasin;
        private System.Windows.Forms.TextBox barreRecherche;
        private System.Windows.Forms.Panel panelGrandEmprunt;
        private System.Windows.Forms.Label lblPageDispo;
        private System.Windows.Forms.Button btnSuiDis;
        private System.Windows.Forms.Button btnPreDis;
        private System.Windows.Forms.FlowLayoutPanel panelDispo;
        private System.Windows.Forms.Label lblDispo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRecherche;
    }
}