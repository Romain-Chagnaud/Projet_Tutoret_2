
namespace Maquette
{
    partial class AlbumEmpruntable
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
            ((System.ComponentModel.ISupportInitialize)(this.pochette)).BeginInit();
            this.SuspendLayout();
            // 
            // pochette
            // 
            this.pochette.Location = new System.Drawing.Point(3, 3);
            this.pochette.Name = "pochette";
            this.pochette.Size = new System.Drawing.Size(100, 100);
            this.pochette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pochette.TabIndex = 0;
            this.pochette.TabStop = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(124, 3);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(28, 13);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Titre";
            // 
            // AlbumEmpruntable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pochette);
            this.Name = "AlbumEmpruntable";
            this.Size = new System.Drawing.Size(851, 293);
            ((System.ComponentModel.ISupportInitialize)(this.pochette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pochette;
        private System.Windows.Forms.Label lblTitre;
    }
}
