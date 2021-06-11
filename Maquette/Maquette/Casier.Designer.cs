
namespace Maquette
{
    partial class Casier
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
            this.lblAllee = new System.Windows.Forms.Label();
            this.lblCasier = new System.Windows.Forms.Label();
            this.txtAllee = new System.Windows.Forms.TextBox();
            this.pnlAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPageCas = new System.Windows.Forms.Label();
            this.btnSuiCas = new System.Windows.Forms.Button();
            this.btnPreCas = new System.Windows.Forms.Button();
            this.btnChargement = new System.Windows.Forms.Button();
            this.numCasier = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numCasier)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAllee
            // 
            this.lblAllee.AutoSize = true;
            this.lblAllee.BackColor = System.Drawing.Color.Teal;
            this.lblAllee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllee.Location = new System.Drawing.Point(56, 13);
            this.lblAllee.Name = "lblAllee";
            this.lblAllee.Size = new System.Drawing.Size(44, 20);
            this.lblAllee.TabIndex = 0;
            this.lblAllee.Text = "Allée";
            // 
            // lblCasier
            // 
            this.lblCasier.AutoSize = true;
            this.lblCasier.BackColor = System.Drawing.Color.Teal;
            this.lblCasier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasier.Location = new System.Drawing.Point(267, 13);
            this.lblCasier.Name = "lblCasier";
            this.lblCasier.Size = new System.Drawing.Size(54, 20);
            this.lblCasier.TabIndex = 1;
            this.lblCasier.Text = "Casier";
            // 
            // txtAllee
            // 
            this.txtAllee.Location = new System.Drawing.Point(124, 13);
            this.txtAllee.Name = "txtAllee";
            this.txtAllee.Size = new System.Drawing.Size(25, 20);
            this.txtAllee.TabIndex = 2;
            // 
            // pnlAlbums
            // 
            this.pnlAlbums.BackColor = System.Drawing.Color.Teal;
            this.pnlAlbums.Location = new System.Drawing.Point(13, 53);
            this.pnlAlbums.Name = "pnlAlbums";
            this.pnlAlbums.Size = new System.Drawing.Size(836, 420);
            this.pnlAlbums.TabIndex = 4;
            // 
            // lblPageCas
            // 
            this.lblPageCas.AutoSize = true;
            this.lblPageCas.BackColor = System.Drawing.Color.Transparent;
            this.lblPageCas.ForeColor = System.Drawing.Color.White;
            this.lblPageCas.Location = new System.Drawing.Point(418, 479);
            this.lblPageCas.Name = "lblPageCas";
            this.lblPageCas.Size = new System.Drawing.Size(32, 13);
            this.lblPageCas.TabIndex = 20;
            this.lblPageCas.Text = "Page";
            // 
            // btnSuiCas
            // 
            this.btnSuiCas.BackColor = System.Drawing.Color.Teal;
            this.btnSuiCas.BackgroundImage = global::Maquette.Properties.Resources.fleche_droite;
            this.btnSuiCas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuiCas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnSuiCas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuiCas.Location = new System.Drawing.Point(774, 479);
            this.btnSuiCas.Name = "btnSuiCas";
            this.btnSuiCas.Size = new System.Drawing.Size(75, 23);
            this.btnSuiCas.TabIndex = 19;
            this.btnSuiCas.UseVisualStyleBackColor = false;
            this.btnSuiCas.Click += new System.EventHandler(this.btnSuiCas_Click);
            // 
            // btnPreCas
            // 
            this.btnPreCas.BackColor = System.Drawing.Color.Teal;
            this.btnPreCas.BackgroundImage = global::Maquette.Properties.Resources.fleche_gauche;
            this.btnPreCas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreCas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnPreCas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreCas.Location = new System.Drawing.Point(13, 479);
            this.btnPreCas.Name = "btnPreCas";
            this.btnPreCas.Size = new System.Drawing.Size(75, 23);
            this.btnPreCas.TabIndex = 18;
            this.btnPreCas.UseVisualStyleBackColor = false;
            this.btnPreCas.Click += new System.EventHandler(this.btnPreCas_Click);
            // 
            // btnChargement
            // 
            this.btnChargement.BackColor = System.Drawing.Color.Teal;
            this.btnChargement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnChargement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChargement.Location = new System.Drawing.Point(741, 15);
            this.btnChargement.Name = "btnChargement";
            this.btnChargement.Size = new System.Drawing.Size(75, 23);
            this.btnChargement.TabIndex = 21;
            this.btnChargement.Text = "Charger";
            this.btnChargement.UseVisualStyleBackColor = false;
            this.btnChargement.Click += new System.EventHandler(this.btnChargement_Click);
            // 
            // numCasier
            // 
            this.numCasier.Location = new System.Drawing.Point(328, 12);
            this.numCasier.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCasier.Name = "numCasier";
            this.numCasier.Size = new System.Drawing.Size(44, 20);
            this.numCasier.TabIndex = 22;
            // 
            // Casier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maquette.Properties.Resources.flou1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 527);
            this.Controls.Add(this.numCasier);
            this.Controls.Add(this.btnChargement);
            this.Controls.Add(this.lblPageCas);
            this.Controls.Add(this.btnSuiCas);
            this.Controls.Add(this.btnPreCas);
            this.Controls.Add(this.pnlAlbums);
            this.Controls.Add(this.txtAllee);
            this.Controls.Add(this.lblCasier);
            this.Controls.Add(this.lblAllee);
            this.DoubleBuffered = true;
            this.Name = "Casier";
            this.Text = "Casier";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numCasier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAllee;
        private System.Windows.Forms.Label lblCasier;
        private System.Windows.Forms.TextBox txtAllee;
        private System.Windows.Forms.FlowLayoutPanel pnlAlbums;
        private System.Windows.Forms.Label lblPageCas;
        private System.Windows.Forms.Button btnSuiCas;
        private System.Windows.Forms.Button btnPreCas;
        private System.Windows.Forms.Button btnChargement;
        private System.Windows.Forms.NumericUpDown numCasier;
    }
}