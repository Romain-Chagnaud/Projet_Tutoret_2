
namespace Maquette
{
    partial class NonEmprunte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NonEmprunte));
            this.btnDeco = new System.Windows.Forms.Button();
            this.pnlNonEmp = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPageReco = new System.Windows.Forms.Label();
            this.btnPreCon = new System.Windows.Forms.Button();
            this.btnSuiCon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeco
            // 
            this.btnDeco.BackColor = System.Drawing.Color.Teal;
            this.btnDeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeco.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnDeco.Location = new System.Drawing.Point(12, 23);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(258, 67);
            this.btnDeco.TabIndex = 8;
            this.btnDeco.Text = "Non emprunté depuis + d\'1 an";
            this.btnDeco.UseVisualStyleBackColor = false;
            // 
            // pnlNonEmp
            // 
            this.pnlNonEmp.BackColor = System.Drawing.Color.Teal;
            this.pnlNonEmp.Location = new System.Drawing.Point(13, 97);
            this.pnlNonEmp.Name = "pnlNonEmp";
            this.pnlNonEmp.Size = new System.Drawing.Size(559, 402);
            this.pnlNonEmp.TabIndex = 9;
            // 
            // lblPageReco
            // 
            this.lblPageReco.AutoSize = true;
            this.lblPageReco.BackColor = System.Drawing.Color.Transparent;
            this.lblPageReco.ForeColor = System.Drawing.Color.White;
            this.lblPageReco.Location = new System.Drawing.Point(265, 529);
            this.lblPageReco.Name = "lblPageReco";
            this.lblPageReco.Size = new System.Drawing.Size(32, 13);
            this.lblPageReco.TabIndex = 13;
            this.lblPageReco.Text = "Page";
            // 
            // btnPreCon
            // 
            this.btnPreCon.BackColor = System.Drawing.Color.Teal;
            this.btnPreCon.BackgroundImage = global::Maquette.Properties.Resources.fleche_gauche;
            this.btnPreCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreCon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnPreCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreCon.Location = new System.Drawing.Point(12, 519);
            this.btnPreCon.Name = "btnPreCon";
            this.btnPreCon.Size = new System.Drawing.Size(75, 23);
            this.btnPreCon.TabIndex = 12;
            this.btnPreCon.UseVisualStyleBackColor = false;
            this.btnPreCon.Click += new System.EventHandler(this.btnPreCon_Click);
            // 
            // btnSuiCon
            // 
            this.btnSuiCon.BackColor = System.Drawing.Color.Teal;
            this.btnSuiCon.BackgroundImage = global::Maquette.Properties.Resources.fleche_droite;
            this.btnSuiCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuiCon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnSuiCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuiCon.Location = new System.Drawing.Point(497, 519);
            this.btnSuiCon.Name = "btnSuiCon";
            this.btnSuiCon.Size = new System.Drawing.Size(75, 23);
            this.btnSuiCon.TabIndex = 11;
            this.btnSuiCon.UseVisualStyleBackColor = false;
            this.btnSuiCon.Click += new System.EventHandler(this.btnSuiCon_Click);
            // 
            // NonEmprunte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maquette.Properties.Resources.flou1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.lblPageReco);
            this.Controls.Add(this.btnPreCon);
            this.Controls.Add(this.btnSuiCon);
            this.Controls.Add(this.pnlNonEmp);
            this.Controls.Add(this.btnDeco);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NonEmprunte";
            this.Text = "NonEmprunte";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeco;
        private System.Windows.Forms.FlowLayoutPanel pnlNonEmp;
        private System.Windows.Forms.Label lblPageReco;
        private System.Windows.Forms.Button btnPreCon;
        private System.Windows.Forms.Button btnSuiCon;
    }
}