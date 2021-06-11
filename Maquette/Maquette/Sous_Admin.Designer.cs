
namespace Maquette
{
    partial class Sous_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sous_Admin));
            this.lblFanto = new System.Windows.Forms.Label();
            this.pnlFanto = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnSuiFan = new System.Windows.Forms.Button();
            this.btnPreFan = new System.Windows.Forms.Button();
            this.lblPageFan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFanto
            // 
            this.lblFanto.BackColor = System.Drawing.Color.Teal;
            this.lblFanto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFanto.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblFanto.Location = new System.Drawing.Point(187, 20);
            this.lblFanto.Name = "lblFanto";
            this.lblFanto.Size = new System.Drawing.Size(289, 61);
            this.lblFanto.TabIndex = 0;
            this.lblFanto.Text = "Abonnés Fantômes";
            this.lblFanto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFanto
            // 
            this.pnlFanto.BackColor = System.Drawing.Color.Teal;
            this.pnlFanto.Location = new System.Drawing.Point(12, 120);
            this.pnlFanto.Name = "pnlFanto";
            this.pnlFanto.Size = new System.Drawing.Size(549, 362);
            this.pnlFanto.TabIndex = 1;
            // 
            // btnSuppr
            // 
            this.btnSuppr.BackColor = System.Drawing.Color.Teal;
            this.btnSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppr.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnSuppr.Location = new System.Drawing.Point(12, 61);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(107, 34);
            this.btnSuppr.TabIndex = 2;
            this.btnSuppr.Text = "Suppression";
            this.btnSuppr.UseVisualStyleBackColor = false;
            this.btnSuppr.Click += new System.EventHandler(this.BtnSuppr_Click);
            // 
            // btnSuiFan
            // 
            this.btnSuiFan.BackgroundImage = global::Maquette.Properties.Resources.fleche_droite;
            this.btnSuiFan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuiFan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnSuiFan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuiFan.Location = new System.Drawing.Point(486, 506);
            this.btnSuiFan.Name = "btnSuiFan";
            this.btnSuiFan.Size = new System.Drawing.Size(75, 23);
            this.btnSuiFan.TabIndex = 8;
            this.btnSuiFan.UseVisualStyleBackColor = true;
            this.btnSuiFan.Click += new System.EventHandler(this.BtnSuiFan_Click);
            // 
            // btnPreFan
            // 
            this.btnPreFan.BackgroundImage = global::Maquette.Properties.Resources.fleche_gauche;
            this.btnPreFan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreFan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnPreFan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreFan.Location = new System.Drawing.Point(12, 506);
            this.btnPreFan.Name = "btnPreFan";
            this.btnPreFan.Size = new System.Drawing.Size(75, 23);
            this.btnPreFan.TabIndex = 9;
            this.btnPreFan.UseVisualStyleBackColor = true;
            this.btnPreFan.Click += new System.EventHandler(this.BtnPreFan_Click);
            // 
            // lblPageFan
            // 
            this.lblPageFan.AutoSize = true;
            this.lblPageFan.BackColor = System.Drawing.Color.Transparent;
            this.lblPageFan.ForeColor = System.Drawing.Color.White;
            this.lblPageFan.Location = new System.Drawing.Point(263, 516);
            this.lblPageFan.Name = "lblPageFan";
            this.lblPageFan.Size = new System.Drawing.Size(32, 13);
            this.lblPageFan.TabIndex = 10;
            this.lblPageFan.Text = "Page";
            // 
            // Sous_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::Maquette.Properties.Resources.flou1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.lblPageFan);
            this.Controls.Add(this.btnPreFan);
            this.Controls.Add(this.btnSuiFan);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.pnlFanto);
            this.Controls.Add(this.lblFanto);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sous_Admin";
            this.Text = "Sous_Admin";
            this.Load += new System.EventHandler(this.SousAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFanto;
        private System.Windows.Forms.FlowLayoutPanel pnlFanto;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnSuiFan;
        private System.Windows.Forms.Button btnPreFan;
        private System.Windows.Forms.Label lblPageFan;
    }
}