
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnVoir = new System.Windows.Forms.Button();
            this.pochette = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pochette)).BeginInit();
            this.SuspendLayout();
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
            // btnVoir
            // 
            this.btnVoir.BackColor = System.Drawing.Color.Teal;
            this.btnVoir.BackgroundImage = global::Maquette.Properties.Resources.visibility;
            this.btnVoir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoir.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnVoir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoir.Location = new System.Drawing.Point(394, 10);
            this.btnVoir.Name = "btnVoir";
            this.btnVoir.Size = new System.Drawing.Size(100, 100);
            this.btnVoir.TabIndex = 2;
            this.btnVoir.UseVisualStyleBackColor = false;
            this.btnVoir.Click += new System.EventHandler(this.btnVoir_Click);
            // 
            // pochette
            // 
            this.pochette.Image = global::Maquette.Properties.Resources.pas_image_tr;
            this.pochette.Location = new System.Drawing.Point(3, 3);
            this.pochette.Name = "pochette";
            this.pochette.Size = new System.Drawing.Size(100, 100);
            this.pochette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pochette.TabIndex = 0;
            this.pochette.TabStop = false;
            // 
            // AlbumEmpruntable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btnVoir);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pochette);
            this.Name = "AlbumEmpruntable";
            this.Size = new System.Drawing.Size(528, 112);
            ((System.ComponentModel.ISupportInitialize)(this.pochette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pochette;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnVoir;
    }
}
