
namespace Maquette
{
    partial class AlbumNonEmprunte
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
            this.btnVoir = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pochette = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pochette)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoir
            // 
            this.btnVoir.BackColor = System.Drawing.Color.Teal;
            this.btnVoir.BackgroundImage = global::Maquette.Properties.Resources.visibility;
            this.btnVoir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoir.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnVoir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoir.Location = new System.Drawing.Point(410, 10);
            this.btnVoir.Name = "btnVoir";
            this.btnVoir.Size = new System.Drawing.Size(100, 100);
            this.btnVoir.TabIndex = 5;
            this.btnVoir.UseVisualStyleBackColor = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(140, 3);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(28, 13);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "Titre";
            // 
            // pochette
            // 
            this.pochette.Location = new System.Drawing.Point(19, 3);
            this.pochette.Name = "pochette";
            this.pochette.Size = new System.Drawing.Size(100, 100);
            this.pochette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pochette.TabIndex = 3;
            this.pochette.TabStop = false;
            // 
            // AlbumNonEmprunte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btnVoir);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pochette);
            this.Name = "AlbumNonEmprunte";
            this.Size = new System.Drawing.Size(528, 112);
            ((System.ComponentModel.ISupportInitialize)(this.pochette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoir;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox pochette;
    }
}
