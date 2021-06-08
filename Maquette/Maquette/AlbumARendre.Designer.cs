
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
            this.btnEtendre = new System.Windows.Forms.Button();
            this.btnRendre = new System.Windows.Forms.Button();
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
            // btnEtendre
            // 
            this.btnEtendre.BackColor = System.Drawing.Color.Teal;
            this.btnEtendre.BackgroundImage = global::Maquette.Properties.Resources.hourglass;
            this.btnEtendre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEtendre.Location = new System.Drawing.Point(265, 10);
            this.btnEtendre.Name = "btnEtendre";
            this.btnEtendre.Size = new System.Drawing.Size(100, 100);
            this.btnEtendre.TabIndex = 4;
            this.btnEtendre.UseVisualStyleBackColor = false;
            this.btnEtendre.Click += new System.EventHandler(this.btnEtendre_Click);
            // 
            // btnRendre
            // 
            this.btnRendre.BackColor = System.Drawing.Color.Teal;
            this.btnRendre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRendre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRendre.Location = new System.Drawing.Point(394, 10);
            this.btnRendre.Name = "btnRendre";
            this.btnRendre.Size = new System.Drawing.Size(100, 100);
            this.btnRendre.TabIndex = 5;
            this.btnRendre.Text = "Rendre l\'album";
            this.btnRendre.UseVisualStyleBackColor = false;
            this.btnRendre.Click += new System.EventHandler(this.btnRendre_Click);
            // 
            // AlbumARendre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRendre);
            this.Controls.Add(this.btnEtendre);
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
        private System.Windows.Forms.Button btnEtendre;
        private System.Windows.Forms.Button btnRendre;
    }
}
