
namespace Maquette
{
    partial class DescriptionAlbumAdmin
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
            this.pnlElement = new System.Windows.Forms.Panel();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblAnnée = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pochette = new System.Windows.Forms.PictureBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pnlElement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pochette)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlElement
            // 
            this.pnlElement.BackColor = System.Drawing.Color.Teal;
            this.pnlElement.Controls.Add(this.lblPrix);
            this.pnlElement.Controls.Add(this.lblAnnée);
            this.pnlElement.Controls.Add(this.lblEdit);
            this.pnlElement.Controls.Add(this.lblGenre);
            this.pnlElement.Controls.Add(this.lblTitre);
            this.pnlElement.Controls.Add(this.pochette);
            this.pnlElement.Controls.Add(this.btnQuitter);
            this.pnlElement.Location = new System.Drawing.Point(10, 10);
            this.pnlElement.Margin = new System.Windows.Forms.Padding(1);
            this.pnlElement.Name = "pnlElement";
            this.pnlElement.Size = new System.Drawing.Size(616, 577);
            this.pnlElement.TabIndex = 4;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(14, 396);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(33, 13);
            this.lblPrix.TabIndex = 8;
            this.lblPrix.Text = "Prix : ";
            // 
            // lblAnnée
            // 
            this.lblAnnée.AutoSize = true;
            this.lblAnnée.Location = new System.Drawing.Point(11, 263);
            this.lblAnnée.Name = "lblAnnée";
            this.lblAnnée.Size = new System.Drawing.Size(47, 13);
            this.lblAnnée.TabIndex = 7;
            this.lblAnnée.Text = "Année : ";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(11, 182);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(46, 13);
            this.lblEdit.TabIndex = 6;
            this.lblEdit.Text = "Éditeur :";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(174, 62);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(171, 13);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(28, 13);
            this.lblTitre.TabIndex = 3;
            this.lblTitre.Text = "Titre";
            // 
            // pochette
            // 
            this.pochette.Image = global::Maquette.Properties.Resources.pas_image_tr;
            this.pochette.Location = new System.Drawing.Point(14, 13);
            this.pochette.Name = "pochette";
            this.pochette.Size = new System.Drawing.Size(150, 150);
            this.pochette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pochette.TabIndex = 1;
            this.pochette.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackgroundImage = global::Maquette.Properties.Resources.quitter;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Location = new System.Drawing.Point(533, 13);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(50, 50);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // DescriptionAlbumAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(636, 597);
            this.Controls.Add(this.pnlElement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DescriptionAlbumAdmin";
            this.Text = "DescriptionAlbumAdmin";
            this.TopMost = true;
            this.pnlElement.ResumeLayout(false);
            this.pnlElement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pochette)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlElement;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblAnnée;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox pochette;
        private System.Windows.Forms.Button btnQuitter;
    }
}