
namespace Maquette
{
    partial class AlbumARendre
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
            this.pochette = new System.Windows.Forms.PictureBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblRendre = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pochette)).BeginInit();
            this.SuspendLayout();
            // 
            // pochette
            // 
            this.pochette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pochette.Location = new System.Drawing.Point(4, 4);
            this.pochette.Name = "pochette";
            this.pochette.Size = new System.Drawing.Size(100, 100);
            this.pochette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pochette.TabIndex = 0;
            this.pochette.TabStop = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(110, 4);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(59, 13);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Titre album";
            // 
            // lblRendre
            // 
            this.lblRendre.AutoSize = true;
            this.lblRendre.Location = new System.Drawing.Point(110, 54);
            this.lblRendre.Name = "lblRendre";
            this.lblRendre.Size = new System.Drawing.Size(64, 13);
            this.lblRendre.TabIndex = 2;
            this.lblRendre.Text = "À rendre le :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(110, 81);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // AlbumARendre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblRendre);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pochette);
            this.Name = "AlbumARendre";
            this.Size = new System.Drawing.Size(528, 118);
            ((System.ComponentModel.ISupportInitialize)(this.pochette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pochette;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblRendre;
        private System.Windows.Forms.Label lblDate;
    }
}
