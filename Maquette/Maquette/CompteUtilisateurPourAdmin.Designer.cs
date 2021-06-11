
namespace Maquette
{
    partial class CompteUtilisateurPourAdmin
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
            this.nouveauMDP = new System.Windows.Forms.TextBox();
            this.confirmedMDP = new System.Windows.Forms.TextBox();
            this.comboPays = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.changerPays = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mdpLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.changeMDP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.BackgroundImage = global::Maquette.Properties.Resources.quitter;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(559, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Maquette.Properties.Resources.user;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 102);
            this.panel1.TabIndex = 1;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.Color.Teal;
            this.labelNom.Font = new System.Drawing.Font("Monotype Corsiva", 19F, System.Drawing.FontStyle.Bold);
            this.labelNom.Location = new System.Drawing.Point(122, 21);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(61, 31);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom";
            // 
            // labelPrénom
            // 
            this.labelPrénom.AutoSize = true;
            this.labelPrénom.BackColor = System.Drawing.Color.Teal;
            this.labelPrénom.Font = new System.Drawing.Font("Monotype Corsiva", 19F, System.Drawing.FontStyle.Bold);
            this.labelPrénom.Location = new System.Drawing.Point(122, 59);
            this.labelPrénom.Name = "labelPrénom";
            this.labelPrénom.Size = new System.Drawing.Size(89, 31);
            this.labelPrénom.TabIndex = 3;
            this.labelPrénom.Text = "Prénom";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Teal;
            this.labelLogin.Font = new System.Drawing.Font("Monotype Corsiva", 19F, System.Drawing.FontStyle.Bold);
            this.labelLogin.Location = new System.Drawing.Point(119, 94);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(73, 31);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mot de passe actuel :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(15, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nouveau mot de passe :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(15, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Confirmation du nouveau mot de passe :";
            // 
            // nouveauMDP
            // 
            this.nouveauMDP.BackColor = System.Drawing.Color.White;
            this.nouveauMDP.ForeColor = System.Drawing.Color.Black;
            this.nouveauMDP.Location = new System.Drawing.Point(19, 274);
            this.nouveauMDP.MaxLength = 32;
            this.nouveauMDP.Name = "nouveauMDP";
            this.nouveauMDP.PasswordChar = '●';
            this.nouveauMDP.Size = new System.Drawing.Size(162, 20);
            this.nouveauMDP.TabIndex = 9;
            // 
            // confirmedMDP
            // 
            this.confirmedMDP.BackColor = System.Drawing.Color.White;
            this.confirmedMDP.ForeColor = System.Drawing.Color.Black;
            this.confirmedMDP.Location = new System.Drawing.Point(19, 343);
            this.confirmedMDP.MaxLength = 32;
            this.confirmedMDP.Name = "confirmedMDP";
            this.confirmedMDP.PasswordChar = '●';
            this.confirmedMDP.Size = new System.Drawing.Size(162, 20);
            this.confirmedMDP.TabIndex = 10;
            // 
            // comboPays
            // 
            this.comboPays.BackColor = System.Drawing.Color.White;
            this.comboPays.ForeColor = System.Drawing.Color.Black;
            this.comboPays.FormattingEnabled = true;
            this.comboPays.Location = new System.Drawing.Point(376, 208);
            this.comboPays.Name = "comboPays";
            this.comboPays.Size = new System.Drawing.Size(162, 21);
            this.comboPays.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(372, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pays :";
            // 
            // changerPays
            // 
            this.changerPays.BackColor = System.Drawing.Color.Teal;
            this.changerPays.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changerPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changerPays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changerPays.Location = new System.Drawing.Point(407, 250);
            this.changerPays.Name = "changerPays";
            this.changerPays.Size = new System.Drawing.Size(75, 27);
            this.changerPays.TabIndex = 14;
            this.changerPays.Text = "Changer";
            this.changerPays.UseVisualStyleBackColor = false;
            this.changerPays.Click += new System.EventHandler(this.changerPays_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.mdpLabel);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.changeMDP);
            this.groupBox1.Controls.Add(this.changerPays);
            this.groupBox1.Controls.Add(this.labelLogin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 434);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // mdpLabel
            // 
            this.mdpLabel.AutoSize = true;
            this.mdpLabel.BackColor = System.Drawing.Color.Teal;
            this.mdpLabel.Font = new System.Drawing.Font("Monotype Corsiva", 19F, System.Drawing.FontStyle.Bold);
            this.mdpLabel.Location = new System.Drawing.Point(9, 181);
            this.mdpLabel.Name = "mdpLabel";
            this.mdpLabel.Size = new System.Drawing.Size(61, 31);
            this.mdpLabel.TabIndex = 20;
            this.mdpLabel.Text = "Mdp";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Maquette.Properties.Resources.visibility;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(187, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 23);
            this.button4.TabIndex = 19;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Maquette.Properties.Resources.visibility;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(187, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // changeMDP
            // 
            this.changeMDP.BackColor = System.Drawing.Color.Teal;
            this.changeMDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeMDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changeMDP.Location = new System.Drawing.Point(50, 379);
            this.changeMDP.Name = "changeMDP";
            this.changeMDP.Size = new System.Drawing.Size(75, 26);
            this.changeMDP.TabIndex = 11;
            this.changeMDP.Text = "Changer";
            this.changeMDP.UseVisualStyleBackColor = false;
            this.changeMDP.Click += new System.EventHandler(this.changeMDP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(-2, -7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 453);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // CompteUtilisateurPourAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(633, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelPrénom);
            this.Controls.Add(this.confirmedMDP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nouveauMDP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboPays);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompteUtilisateurPourAdmin";
            this.Text = "CompteUtilisateur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox nouveauMDP;
        private System.Windows.Forms.TextBox confirmedMDP;
        private System.Windows.Forms.ComboBox comboPays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button changerPays;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button changeMDP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label mdpLabel;
    }
}