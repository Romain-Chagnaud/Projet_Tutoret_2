
namespace Maquette
{
    partial class Prologation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prologation));
            this.pnlEmp = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrePro = new System.Windows.Forms.Button();
            this.btnSuiPro = new System.Windows.Forms.Button();
            this.lblPagePro = new System.Windows.Forms.Label();
            this.lblProlo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlEmp
            // 
            this.pnlEmp.Location = new System.Drawing.Point(21, 135);
            this.pnlEmp.Name = "pnlEmp";
            this.pnlEmp.Size = new System.Drawing.Size(579, 375);
            this.pnlEmp.TabIndex = 5;
            // 
            // btnPrePro
            // 
            this.btnPrePro.BackgroundImage = global::Maquette.Properties.Resources.fleche_gauche;
            this.btnPrePro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrePro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnPrePro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrePro.Location = new System.Drawing.Point(21, 516);
            this.btnPrePro.Name = "btnPrePro";
            this.btnPrePro.Size = new System.Drawing.Size(75, 23);
            this.btnPrePro.TabIndex = 6;
            this.btnPrePro.UseVisualStyleBackColor = true;
            this.btnPrePro.Click += new System.EventHandler(this.btnPreCon_Click);
            // 
            // btnSuiPro
            // 
            this.btnSuiPro.BackgroundImage = global::Maquette.Properties.Resources.fleche_droite;
            this.btnSuiPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuiPro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnSuiPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuiPro.Location = new System.Drawing.Point(525, 516);
            this.btnSuiPro.Name = "btnSuiPro";
            this.btnSuiPro.Size = new System.Drawing.Size(75, 23);
            this.btnSuiPro.TabIndex = 7;
            this.btnSuiPro.UseVisualStyleBackColor = true;
            this.btnSuiPro.Click += new System.EventHandler(this.btnSuiCon_Click);
            // 
            // lblPagePro
            // 
            this.lblPagePro.AutoSize = true;
            this.lblPagePro.BackColor = System.Drawing.Color.Transparent;
            this.lblPagePro.ForeColor = System.Drawing.Color.White;
            this.lblPagePro.Location = new System.Drawing.Point(283, 521);
            this.lblPagePro.Name = "lblPagePro";
            this.lblPagePro.Size = new System.Drawing.Size(32, 13);
            this.lblPagePro.TabIndex = 8;
            this.lblPagePro.Text = "Page";
            // 
            // lblProlo
            // 
            this.lblProlo.BackColor = System.Drawing.Color.Teal;
            this.lblProlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProlo.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblProlo.Location = new System.Drawing.Point(156, 33);
            this.lblProlo.Name = "lblProlo";
            this.lblProlo.Size = new System.Drawing.Size(289, 61);
            this.lblProlo.TabIndex = 9;
            this.lblProlo.Text = "Vérifier prolongation";
            this.lblProlo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prologation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::Maquette.Properties.Resources.flou1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(612, 561);
            this.Controls.Add(this.lblProlo);
            this.Controls.Add(this.lblPagePro);
            this.Controls.Add(this.btnSuiPro);
            this.Controls.Add(this.btnPrePro);
            this.Controls.Add(this.pnlEmp);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prologation";
            this.Text = "Prologation";
            this.Load += new System.EventHandler(this.Prologation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnlEmp;
        private System.Windows.Forms.Button btnPrePro;
        private System.Windows.Forms.Button btnSuiPro;
        private System.Windows.Forms.Label lblPagePro;
        private System.Windows.Forms.Label lblProlo;
    }
}