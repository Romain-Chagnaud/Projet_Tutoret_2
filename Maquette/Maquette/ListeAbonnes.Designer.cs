
namespace Maquette
{
    partial class ListeAbonnes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeAbonnes));
            this.lblListe = new System.Windows.Forms.Label();
            this.pnlAbo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPageAbo = new System.Windows.Forms.Label();
            this.btnSuiAbo = new System.Windows.Forms.Button();
            this.btnPreAbo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblListe
            // 
            this.lblListe.BackColor = System.Drawing.Color.Teal;
            this.lblListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListe.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblListe.Location = new System.Drawing.Point(129, 9);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(289, 61);
            this.lblListe.TabIndex = 10;
            this.lblListe.Text = "Liste des abonnés";
            this.lblListe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAbo
            // 
            this.pnlAbo.BackColor = System.Drawing.Color.Teal;
            this.pnlAbo.Location = new System.Drawing.Point(12, 84);
            this.pnlAbo.Name = "pnlAbo";
            this.pnlAbo.Size = new System.Drawing.Size(560, 636);
            this.pnlAbo.TabIndex = 11;
            // 
            // lblPageAbo
            // 
            this.lblPageAbo.AutoSize = true;
            this.lblPageAbo.BackColor = System.Drawing.Color.Transparent;
            this.lblPageAbo.ForeColor = System.Drawing.Color.White;
            this.lblPageAbo.Location = new System.Drawing.Point(272, 736);
            this.lblPageAbo.Name = "lblPageAbo";
            this.lblPageAbo.Size = new System.Drawing.Size(32, 13);
            this.lblPageAbo.TabIndex = 18;
            this.lblPageAbo.Text = "Page";
            // 
            // btnSuiAbo
            // 
            this.btnSuiAbo.BackgroundImage = global::Maquette.Properties.Resources.fleche_droite;
            this.btnSuiAbo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuiAbo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnSuiAbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuiAbo.Location = new System.Drawing.Point(497, 726);
            this.btnSuiAbo.Name = "btnSuiAbo";
            this.btnSuiAbo.Size = new System.Drawing.Size(75, 23);
            this.btnSuiAbo.TabIndex = 17;
            this.btnSuiAbo.UseVisualStyleBackColor = true;
            this.btnSuiAbo.Click += new System.EventHandler(this.BtnSuiAbo_Click);
            // 
            // btnPreAbo
            // 
            this.btnPreAbo.BackgroundImage = global::Maquette.Properties.Resources.fleche_gauche;
            this.btnPreAbo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreAbo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnPreAbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreAbo.Location = new System.Drawing.Point(12, 726);
            this.btnPreAbo.Name = "btnPreAbo";
            this.btnPreAbo.Size = new System.Drawing.Size(75, 23);
            this.btnPreAbo.TabIndex = 16;
            this.btnPreAbo.UseVisualStyleBackColor = true;
            this.btnPreAbo.Click += new System.EventHandler(this.BtnPreAbo_Click);
            // 
            // ListeAbonnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maquette.Properties.Resources.flou;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.lblPageAbo);
            this.Controls.Add(this.btnSuiAbo);
            this.Controls.Add(this.btnPreAbo);
            this.Controls.Add(this.pnlAbo);
            this.Controls.Add(this.lblListe);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListeAbonnes";
            this.Text = "ListeAbonnes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListe;
        private System.Windows.Forms.FlowLayoutPanel pnlAbo;
        private System.Windows.Forms.Label lblPageAbo;
        private System.Windows.Forms.Button btnSuiAbo;
        private System.Windows.Forms.Button btnPreAbo;
    }
}