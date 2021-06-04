
namespace Maquette
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.mdp = new System.Windows.Forms.TextBox();
            this.log2 = new System.Windows.Forms.TextBox();
            this.mdp2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(21, 46);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 0;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(21, 93);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(100, 20);
            this.prenom.TabIndex = 1;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(21, 216);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 2;
            // 
            // mdp
            // 
            this.mdp.Location = new System.Drawing.Point(21, 242);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(100, 20);
            this.mdp.TabIndex = 3;
            // 
            // log2
            // 
            this.log2.Location = new System.Drawing.Point(496, 73);
            this.log2.Name = "log2";
            this.log2.Size = new System.Drawing.Size(100, 20);
            this.log2.TabIndex = 4;
            // 
            // mdp2
            // 
            this.mdp2.Location = new System.Drawing.Point(496, 138);
            this.mdp2.Name = "mdp2";
            this.mdp2.Size = new System.Drawing.Size(100, 20);
            this.mdp2.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(477, 238);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 186);
            this.listBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mdp2);
            this.Controls.Add(this.log2);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.login);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Name = "Form1";
            this.Text = "  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox mdp;
        private System.Windows.Forms.TextBox log2;
        private System.Windows.Forms.TextBox mdp2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

