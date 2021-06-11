
namespace Maquette
{
    partial class Sous_Admin2cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sous_Admin2cs));
            this.pnlRetards = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRetard = new System.Windows.Forms.Label();
            this.btnPreRe = new System.Windows.Forms.Button();
            this.btnSuiRe = new System.Windows.Forms.Button();
            this.lblPageRe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlRetards
            // 
            this.pnlRetards.Location = new System.Drawing.Point(12, 124);
            this.pnlRetards.Name = "pnlRetards";
            this.pnlRetards.Size = new System.Drawing.Size(560, 335);
            this.pnlRetards.TabIndex = 8;
            // 
            // lblRetard
            // 
            this.lblRetard.BackColor = System.Drawing.Color.Teal;
            this.lblRetard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetard.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblRetard.Location = new System.Drawing.Point(150, 47);
            this.lblRetard.Name = "lblRetard";
            this.lblRetard.Size = new System.Drawing.Size(289, 61);
            this.lblRetard.TabIndex = 9;
            this.lblRetard.Text = "Retards supérieurs à 10 jours";
            this.lblRetard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPreRe
            // 
            this.btnPreRe.BackgroundImage = global::Maquette.Properties.Resources.fleche_gauche;
            this.btnPreRe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreRe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnPreRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreRe.Location = new System.Drawing.Point(12, 480);
            this.btnPreRe.Name = "btnPreRe";
            this.btnPreRe.Size = new System.Drawing.Size(75, 23);
            this.btnPreRe.TabIndex = 13;
            this.btnPreRe.UseVisualStyleBackColor = true;
            this.btnPreRe.Click += new System.EventHandler(this.BtnPreRe_Click);
            // 
            // btnSuiRe
            // 
            this.btnSuiRe.BackgroundImage = global::Maquette.Properties.Resources.fleche_droite;
            this.btnSuiRe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuiRe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnSuiRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuiRe.Location = new System.Drawing.Point(497, 480);
            this.btnSuiRe.Name = "btnSuiRe";
            this.btnSuiRe.Size = new System.Drawing.Size(75, 23);
            this.btnSuiRe.TabIndex = 14;
            this.btnSuiRe.UseVisualStyleBackColor = true;
            this.btnSuiRe.Click += new System.EventHandler(this.BtnSuiRe_Click);
            // 
            // lblPageRe
            // 
            this.lblPageRe.AutoSize = true;
            this.lblPageRe.BackColor = System.Drawing.Color.Transparent;
            this.lblPageRe.ForeColor = System.Drawing.Color.White;
            this.lblPageRe.Location = new System.Drawing.Point(272, 490);
            this.lblPageRe.Name = "lblPageRe";
            this.lblPageRe.Size = new System.Drawing.Size(32, 13);
            this.lblPageRe.TabIndex = 15;
            this.lblPageRe.Text = "Page";
            // 
            // Sous_Admin2cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::Maquette.Properties.Resources.flou1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 527);
            this.Controls.Add(this.lblPageRe);
            this.Controls.Add(this.btnSuiRe);
            this.Controls.Add(this.btnPreRe);
            this.Controls.Add(this.lblRetard);
            this.Controls.Add(this.pnlRetards);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sous_Admin2cs";
            this.Text = "Sous_Admin2cs";
            this.Load += new System.EventHandler(this.Sous_Admin2cs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnlRetards;
        private System.Windows.Forms.Label lblRetard;
        private System.Windows.Forms.Button btnPreRe;
        private System.Windows.Forms.Button btnSuiRe;
        private System.Windows.Forms.Label lblPageRe;
    }
}