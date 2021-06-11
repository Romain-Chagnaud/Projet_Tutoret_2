
namespace Maquette
{
    partial class ProlongationAbo
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
            this.portrait = new System.Windows.Forms.PictureBox();
            this.Admin_Prenom = new System.Windows.Forms.Label();
            this.Admin_Name = new System.Windows.Forms.Label();
            this.pochette = new System.Windows.Forms.PictureBox();
            this.TitreAlbum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.portrait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pochette)).BeginInit();
            this.SuspendLayout();
            // 
            // portrait
            // 
            this.portrait.BackgroundImage = global::Maquette.Properties.Resources.user;
            this.portrait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.portrait.Location = new System.Drawing.Point(27, 34);
            this.portrait.Name = "portrait";
            this.portrait.Size = new System.Drawing.Size(84, 80);
            this.portrait.TabIndex = 2;
            this.portrait.TabStop = false;
            // 
            // Admin_Prenom
            // 
            this.Admin_Prenom.AutoSize = true;
            this.Admin_Prenom.Location = new System.Drawing.Point(162, 95);
            this.Admin_Prenom.Name = "Admin_Prenom";
            this.Admin_Prenom.Size = new System.Drawing.Size(43, 13);
            this.Admin_Prenom.TabIndex = 6;
            this.Admin_Prenom.Text = "Prénom";
            // 
            // Admin_Name
            // 
            this.Admin_Name.AutoSize = true;
            this.Admin_Name.Location = new System.Drawing.Point(162, 34);
            this.Admin_Name.Name = "Admin_Name";
            this.Admin_Name.Size = new System.Drawing.Size(29, 13);
            this.Admin_Name.TabIndex = 5;
            this.Admin_Name.Text = "Nom";
            // 
            // pochette
            // 
            this.pochette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pochette.Location = new System.Drawing.Point(286, 34);
            this.pochette.Name = "pochette";
            this.pochette.Size = new System.Drawing.Size(93, 80);
            this.pochette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pochette.TabIndex = 8;
            this.pochette.TabStop = false;
            // 
            // TitreAlbum
            // 
            this.TitreAlbum.AutoSize = true;
            this.TitreAlbum.Location = new System.Drawing.Point(385, 66);
            this.TitreAlbum.Name = "TitreAlbum";
            this.TitreAlbum.Size = new System.Drawing.Size(60, 13);
            this.TitreAlbum.TabIndex = 9;
            this.TitreAlbum.Text = "Titre Album";
            // 
            // ProlongationAbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.TitreAlbum);
            this.Controls.Add(this.pochette);
            this.Controls.Add(this.Admin_Prenom);
            this.Controls.Add(this.Admin_Name);
            this.Controls.Add(this.portrait);
            this.Name = "ProlongationAbo";
            this.Size = new System.Drawing.Size(590, 161);
            ((System.ComponentModel.ISupportInitialize)(this.portrait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pochette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox portrait;
        private System.Windows.Forms.Label Admin_Prenom;
        private System.Windows.Forms.Label Admin_Name;
        private System.Windows.Forms.PictureBox pochette;
        private System.Windows.Forms.Label TitreAlbum;
    }
}
