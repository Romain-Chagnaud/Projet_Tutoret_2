
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblRendre = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnRendre = new System.Windows.Forms.Button();
            this.btnEtendre = new System.Windows.Forms.Button();
            this.pochette = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pochette)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(110, 4);
            this.lblTitre.MaximumSize = new System.Drawing.Size(149, 0);
            this.lblTitre.MinimumSize = new System.Drawing.Size(250, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(250, 24);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Titre album";
            // 
            // lblRendre
            // 
            this.lblRendre.AutoSize = true;
            this.lblRendre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRendre.Location = new System.Drawing.Point(111, 53);
            this.lblRendre.Name = "lblRendre";
            this.lblRendre.Size = new System.Drawing.Size(79, 16);
            this.lblRendre.TabIndex = 2;
            this.lblRendre.Text = "À rendre le :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(111, 69);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 15);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // btnRendre
            // 
            this.btnRendre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.btnRendre.BackgroundImage = global::Maquette.Properties.Resources.rendre_album_v2;
            this.btnRendre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRendre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRendre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.btnRendre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRendre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRendre.Location = new System.Drawing.Point(453, 10);
            this.btnRendre.Name = "btnRendre";
            this.btnRendre.Size = new System.Drawing.Size(60, 60);
            this.btnRendre.TabIndex = 5;
            this.btnRendre.UseVisualStyleBackColor = false;
            this.btnRendre.Click += new System.EventHandler(this.btnRendre_Click);
            // 
            // btnEtendre
            // 
            this.btnEtendre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.btnEtendre.BackgroundImage = global::Maquette.Properties.Resources.hourglass;
            this.btnEtendre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEtendre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEtendre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.btnEtendre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtendre.Location = new System.Drawing.Point(377, 10);
            this.btnEtendre.Name = "btnEtendre";
            this.btnEtendre.Size = new System.Drawing.Size(60, 60);
            this.btnEtendre.TabIndex = 4;
            this.btnEtendre.UseVisualStyleBackColor = false;
            this.btnEtendre.Click += new System.EventHandler(this.btnEtendre_Click);
            // 
            // pochette
            // 
            this.pochette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pochette.Location = new System.Drawing.Point(4, 4);
            this.pochette.Name = "pochette";
            this.pochette.Size = new System.Drawing.Size(80, 80);
            this.pochette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pochette.TabIndex = 0;
            this.pochette.TabStop = false;
            // 
            // AlbumARendre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.btnRendre);
            this.Controls.Add(this.btnEtendre);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblRendre);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pochette);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.Name = "AlbumARendre";
            this.Size = new System.Drawing.Size(528, 88);
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
