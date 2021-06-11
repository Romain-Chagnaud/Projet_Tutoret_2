
namespace Maquette
{
    partial class PresentationAbonne
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.btnVoir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Maquette.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(39, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(168, 37);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(168, 90);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom";
            // 
            // btnVoir
            // 
            this.btnVoir.BackColor = System.Drawing.Color.Teal;
            this.btnVoir.BackgroundImage = global::Maquette.Properties.Resources.visibility;
            this.btnVoir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoir.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnVoir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoir.Location = new System.Drawing.Point(451, 27);
            this.btnVoir.Name = "btnVoir";
            this.btnVoir.Size = new System.Drawing.Size(100, 100);
            this.btnVoir.TabIndex = 3;
            this.btnVoir.UseVisualStyleBackColor = false;
            this.btnVoir.Click += new System.EventHandler(this.btnVoir_Click);
            // 
            // PresentationAbonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btnVoir);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PresentationAbonne";
            this.Size = new System.Drawing.Size(586, 166);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Button btnVoir;
    }
}
