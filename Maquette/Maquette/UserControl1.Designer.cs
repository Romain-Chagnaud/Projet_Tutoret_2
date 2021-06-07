
namespace Maquette
{
    partial class UserControl1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomLbl = new System.Windows.Forms.Label();
            this.anneeLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 203);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nomLbl
            // 
            this.nomLbl.AutoSize = true;
            this.nomLbl.Location = new System.Drawing.Point(242, 21);
            this.nomLbl.Name = "nomLbl";
            this.nomLbl.Size = new System.Drawing.Size(35, 13);
            this.nomLbl.TabIndex = 1;
            this.nomLbl.Text = "label1";
            // 
            // anneeLbl
            // 
            this.anneeLbl.AutoSize = true;
            this.anneeLbl.Location = new System.Drawing.Point(245, 177);
            this.anneeLbl.Name = "anneeLbl";
            this.anneeLbl.Size = new System.Drawing.Size(35, 13);
            this.anneeLbl.TabIndex = 2;
            this.anneeLbl.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 89);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.anneeLbl);
            this.Controls.Add(this.nomLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(844, 257);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nomLbl;
        private System.Windows.Forms.Label anneeLbl;
        private System.Windows.Forms.Button button1;
    }
}
