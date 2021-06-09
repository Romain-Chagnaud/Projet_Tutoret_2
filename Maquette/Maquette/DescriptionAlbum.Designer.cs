
namespace Maquette
{
    partial class DescriptionAlbum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DescriptionAlbum));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btnEmprunt = new System.Windows.Forms.Button();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblAnnée = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(521, 13);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblPrix);
            this.panel1.Controls.Add(this.lblAnnée);
            this.panel1.Controls.Add(this.lblEdit);
            this.panel1.Controls.Add(this.btnEmprunt);
            this.panel1.Controls.Add(this.lblGenre);
            this.panel1.Controls.Add(this.lblTitre);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnQuitter);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 575);
            this.panel1.TabIndex = 3;
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
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(174, 62);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
            // 
            // btnEmprunt
            // 
            this.btnEmprunt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEmprunt.Location = new System.Drawing.Point(464, 546);
            this.btnEmprunt.Name = "btnEmprunt";
            this.btnEmprunt.Size = new System.Drawing.Size(75, 23);
            this.btnEmprunt.TabIndex = 5;
            this.btnEmprunt.Text = "Emprunter";
            this.btnEmprunt.UseVisualStyleBackColor = true;
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
            // lblAnnée
            // 
            this.lblAnnée.AutoSize = true;
            this.lblAnnée.Location = new System.Drawing.Point(11, 263);
            this.lblAnnée.Name = "lblAnnée";
            this.lblAnnée.Size = new System.Drawing.Size(47, 13);
            this.lblAnnée.TabIndex = 7;
            this.lblAnnée.Text = "Année : ";
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
            // DescriptionAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(636, 597);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DescriptionAlbum";
            this.Text = "DescriptionAlbum";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmprunt;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblAnnée;
        private System.Windows.Forms.Label lblEdit;
    }
}