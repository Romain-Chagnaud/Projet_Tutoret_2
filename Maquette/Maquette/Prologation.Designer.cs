
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPreCon = new System.Windows.Forms.Button();
            this.btnSuiCon = new System.Windows.Forms.Button();
            this.lblPageReco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(579, 375);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnPreCon
            // 
            this.btnPreCon.BackgroundImage = global::Maquette.Properties.Resources.fleche_gauche;
            this.btnPreCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreCon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnPreCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreCon.Location = new System.Drawing.Point(21, 516);
            this.btnPreCon.Name = "btnPreCon";
            this.btnPreCon.Size = new System.Drawing.Size(75, 23);
            this.btnPreCon.TabIndex = 6;
            this.btnPreCon.UseVisualStyleBackColor = true;
            this.btnPreCon.Click += new System.EventHandler(this.btnPreCon_Click);
            // 
            // btnSuiCon
            // 
            this.btnSuiCon.BackgroundImage = global::Maquette.Properties.Resources.fleche_droite;
            this.btnSuiCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuiCon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnSuiCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuiCon.Location = new System.Drawing.Point(525, 516);
            this.btnSuiCon.Name = "btnSuiCon";
            this.btnSuiCon.Size = new System.Drawing.Size(75, 23);
            this.btnSuiCon.TabIndex = 7;
            this.btnSuiCon.UseVisualStyleBackColor = true;
            this.btnSuiCon.Click += new System.EventHandler(this.btnSuiCon_Click);
            // 
            // lblPageReco
            // 
            this.lblPageReco.AutoSize = true;
            this.lblPageReco.BackColor = System.Drawing.Color.Transparent;
            this.lblPageReco.ForeColor = System.Drawing.Color.White;
            this.lblPageReco.Location = new System.Drawing.Point(283, 521);
            this.lblPageReco.Name = "lblPageReco";
            this.lblPageReco.Size = new System.Drawing.Size(32, 13);
            this.lblPageReco.TabIndex = 8;
            this.lblPageReco.Text = "Page";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(156, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 61);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vérifier prolongation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prologation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::Maquette.Properties.Resources.flou1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(612, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPageReco);
            this.Controls.Add(this.btnSuiCon);
            this.Controls.Add(this.btnPreCon);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prologation";
            this.Text = "Prologation";
            this.Load += new System.EventHandler(this.Prologation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPreCon;
        private System.Windows.Forms.Button btnSuiCon;
        private System.Windows.Forms.Label lblPageReco;
        private System.Windows.Forms.Label label1;
    }
}