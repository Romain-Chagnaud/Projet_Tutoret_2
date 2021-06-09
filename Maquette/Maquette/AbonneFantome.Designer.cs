
namespace Maquette
{
    partial class AbonneFantome
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
            this.Admin_Name = new System.Windows.Forms.Label();
            this.Admin_Prenom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin_Name
            // 
            this.Admin_Name.AutoSize = true;
            this.Admin_Name.Location = new System.Drawing.Point(214, 23);
            this.Admin_Name.Name = "Admin_Name";
            this.Admin_Name.Size = new System.Drawing.Size(29, 13);
            this.Admin_Name.TabIndex = 1;
            this.Admin_Name.Text = "Nom";
            // 
            // Admin_Prenom
            // 
            this.Admin_Prenom.AutoSize = true;
            this.Admin_Prenom.Location = new System.Drawing.Point(214, 84);
            this.Admin_Prenom.Name = "Admin_Prenom";
            this.Admin_Prenom.Size = new System.Drawing.Size(43, 13);
            this.Admin_Prenom.TabIndex = 2;
            this.Admin_Prenom.Text = "Prénom";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(33, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AbonneFantome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.Admin_Prenom);
            this.Controls.Add(this.Admin_Name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AbonneFantome";
            this.Size = new System.Drawing.Size(600, 141);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Admin_Name;
        private System.Windows.Forms.Label Admin_Prenom;
    }
}
