
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSuiCon = new System.Windows.Forms.Button();
            this.btnPreCon = new System.Windows.Forms.Button();
            this.lblPageReco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(187, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abonnés Fantômes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Teal;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(549, 362);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(12, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Supression";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSuiCon
            // 
            this.btnSuiCon.BackgroundImage = global::Maquette.Properties.Resources.fleche_droite;
            this.btnSuiCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuiCon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnSuiCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuiCon.Location = new System.Drawing.Point(486, 506);
            this.btnSuiCon.Name = "btnSuiCon";
            this.btnSuiCon.Size = new System.Drawing.Size(75, 23);
            this.btnSuiCon.TabIndex = 8;
            this.btnSuiCon.UseVisualStyleBackColor = true;
            this.btnSuiCon.Click += new System.EventHandler(this.btnSuiCon_Click);
            // 
            // btnPreCon
            // 
            this.btnPreCon.BackgroundImage = global::Maquette.Properties.Resources.fleche_gauche;
            this.btnPreCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreCon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnPreCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreCon.Location = new System.Drawing.Point(12, 506);
            this.btnPreCon.Name = "btnPreCon";
            this.btnPreCon.Size = new System.Drawing.Size(75, 23);
            this.btnPreCon.TabIndex = 9;
            this.btnPreCon.UseVisualStyleBackColor = true;
            this.btnPreCon.Click += new System.EventHandler(this.btnPreCon_Click);
            // 
            // lblPageReco
            // 
            this.lblPageReco.AutoSize = true;
            this.lblPageReco.BackColor = System.Drawing.Color.Transparent;
            this.lblPageReco.ForeColor = System.Drawing.Color.White;
            this.lblPageReco.Location = new System.Drawing.Point(263, 516);
            this.lblPageReco.Name = "lblPageReco";
            this.lblPageReco.Size = new System.Drawing.Size(32, 13);
            this.lblPageReco.TabIndex = 10;
            this.lblPageReco.Text = "Page";
            // 
            // Sous_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::Maquette.Properties.Resources.flou1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.lblPageReco);
            this.Controls.Add(this.btnPreCon);
            this.Controls.Add(this.btnSuiCon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sous_Admin";
            this.Text = "Sous_Admin";
            this.Load += new System.EventHandler(this.SousAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSuiCon;
        private System.Windows.Forms.Button btnPreCon;
        private System.Windows.Forms.Label lblPageReco;
    }
}