
namespace Maquette
{
    partial class CompteUtilisateur
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrénom = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ancienMDP = new System.Windows.Forms.TextBox();
            this.nouveauMDP = new System.Windows.Forms.TextBox();
            this.confirmedMDP = new System.Windows.Forms.TextBox();
            this.changeMDP = new System.Windows.Forms.Button();
            this.comboPays = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.changerPays = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Maquette.Properties.Resources.quitter;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(571, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Maquette.Properties.Resources.user;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 111);
            this.panel1.TabIndex = 1;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelNom.Location = new System.Drawing.Point(122, 21);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(62, 26);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom";
            // 
            // labelPrénom
            // 
            this.labelPrénom.AutoSize = true;
            this.labelPrénom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelPrénom.Location = new System.Drawing.Point(122, 59);
            this.labelPrénom.Name = "labelPrénom";
            this.labelPrénom.Size = new System.Drawing.Size(95, 26);
            this.labelPrénom.TabIndex = 3;
            this.labelPrénom.Text = "Prénom";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelLogin.Location = new System.Drawing.Point(122, 97);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(70, 26);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(15, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ancien mot de passe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(15, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nouveau mot de passe :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(15, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Confirmation du nouveau mot de passe :";
            // 
            // ancienMDP
            // 
            this.ancienMDP.Location = new System.Drawing.Point(19, 208);
            this.ancienMDP.MaxLength = 32;
            this.ancienMDP.Name = "ancienMDP";
            this.ancienMDP.Size = new System.Drawing.Size(162, 20);
            this.ancienMDP.TabIndex = 8;
            // 
            // nouveauMDP
            // 
            this.nouveauMDP.Location = new System.Drawing.Point(19, 274);
            this.nouveauMDP.MaxLength = 32;
            this.nouveauMDP.Name = "nouveauMDP";
            this.nouveauMDP.Size = new System.Drawing.Size(162, 20);
            this.nouveauMDP.TabIndex = 9;
            // 
            // confirmedMDP
            // 
            this.confirmedMDP.Location = new System.Drawing.Point(19, 343);
            this.confirmedMDP.MaxLength = 32;
            this.confirmedMDP.Name = "confirmedMDP";
            this.confirmedMDP.Size = new System.Drawing.Size(162, 20);
            this.confirmedMDP.TabIndex = 10;
            // 
            // changeMDP
            // 
            this.changeMDP.BackColor = System.Drawing.Color.Teal;
            this.changeMDP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.changeMDP.Location = new System.Drawing.Point(40, 390);
            this.changeMDP.Name = "changeMDP";
            this.changeMDP.Size = new System.Drawing.Size(75, 23);
            this.changeMDP.TabIndex = 11;
            this.changeMDP.Text = "Changer";
            this.changeMDP.UseVisualStyleBackColor = false;
            this.changeMDP.Click += new System.EventHandler(this.changeMDP_Click);
            // 
            // comboPays
            // 
            this.comboPays.FormattingEnabled = true;
            this.comboPays.Location = new System.Drawing.Point(376, 208);
            this.comboPays.Name = "comboPays";
            this.comboPays.Size = new System.Drawing.Size(162, 21);
            this.comboPays.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(372, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pays :";
            // 
            // changerPays
            // 
            this.changerPays.BackColor = System.Drawing.Color.Teal;
            this.changerPays.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.changerPays.Location = new System.Drawing.Point(376, 274);
            this.changerPays.Name = "changerPays";
            this.changerPays.Size = new System.Drawing.Size(75, 23);
            this.changerPays.TabIndex = 14;
            this.changerPays.Text = "Changer";
            this.changerPays.UseVisualStyleBackColor = false;
            this.changerPays.Click += new System.EventHandler(this.changerPays_Click);
            // 
            // CompteUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(633, 440);
            this.Controls.Add(this.changerPays);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboPays);
            this.Controls.Add(this.changeMDP);
            this.Controls.Add(this.confirmedMDP);
            this.Controls.Add(this.nouveauMDP);
            this.Controls.Add(this.ancienMDP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPrénom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompteUtilisateur";
            this.Text = "CompteUtilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrénom;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ancienMDP;
        private System.Windows.Forms.TextBox nouveauMDP;
        private System.Windows.Forms.TextBox confirmedMDP;
        private System.Windows.Forms.Button changeMDP;
        private System.Windows.Forms.ComboBox comboPays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button changerPays;
    }
}