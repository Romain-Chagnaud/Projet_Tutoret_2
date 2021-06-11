
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrénom = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.lblMdpActuel = new System.Windows.Forms.Label();
            this.lblNvMdp = new System.Windows.Forms.Label();
            this.lblCoNvMdp = new System.Windows.Forms.Label();
            this.nouveauMDP = new System.Windows.Forms.TextBox();
            this.confirmedMDP = new System.Windows.Forms.TextBox();
            this.comboPays = new System.Windows.Forms.ComboBox();
            this.lblPays = new System.Windows.Forms.Label();
            this.changerPays = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mdpLabel = new System.Windows.Forms.Label();
            this.btnCoNvMdp = new System.Windows.Forms.Button();
            this.btnNvMdp = new System.Windows.Forms.Button();
            this.changeMDP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgPortrait = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPortrait)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Teal;
            this.btnQuitter.BackgroundImage = global::Maquette.Properties.Resources.quitter;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.ForeColor = System.Drawing.Color.Teal;
            this.btnQuitter.Location = new System.Drawing.Point(559, 8);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(41, 35);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.UseVisualStyleBackColor = false;
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
            // lblMdpActuel
            // 
            this.lblMdpActuel.AutoSize = true;
            this.lblMdpActuel.BackColor = System.Drawing.Color.Teal;
            this.lblMdpActuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMdpActuel.ForeColor = System.Drawing.Color.Black;
            this.lblMdpActuel.Location = new System.Drawing.Point(11, 150);
            this.lblMdpActuel.Name = "lblMdpActuel";
            this.lblMdpActuel.Size = new System.Drawing.Size(181, 20);
            this.lblMdpActuel.TabIndex = 5;
            this.lblMdpActuel.Text = "Mot de passe actuel :";
            // 
            // lblNvMdp
            // 
            this.lblNvMdp.AutoSize = true;
            this.lblNvMdp.BackColor = System.Drawing.Color.Teal;
            this.lblNvMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNvMdp.Location = new System.Drawing.Point(15, 239);
            this.lblNvMdp.Name = "lblNvMdp";
            this.lblNvMdp.Size = new System.Drawing.Size(202, 20);
            this.lblNvMdp.TabIndex = 6;
            this.lblNvMdp.Text = "Nouveau mot de passe :";
            // 
            // lblCoNvMdp
            // 
            this.lblCoNvMdp.AutoSize = true;
            this.lblCoNvMdp.BackColor = System.Drawing.Color.Teal;
            this.lblCoNvMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCoNvMdp.Location = new System.Drawing.Point(15, 309);
            this.lblCoNvMdp.Name = "lblCoNvMdp";
            this.lblCoNvMdp.Size = new System.Drawing.Size(332, 20);
            this.lblCoNvMdp.TabIndex = 7;
            this.lblCoNvMdp.Text = "Confirmation du nouveau mot de passe :";
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
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.BackColor = System.Drawing.Color.Teal;
            this.lblPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPays.Location = new System.Drawing.Point(372, 173);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(57, 20);
            this.lblPays.TabIndex = 13;
            this.lblPays.Text = "Pays :";
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
            this.changerPays.Click += new System.EventHandler(this.ChangerPays_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.imgPortrait);
            this.groupBox1.Controls.Add(this.mdpLabel);
            this.groupBox1.Controls.Add(this.btnCoNvMdp);
            this.groupBox1.Controls.Add(this.btnNvMdp);
            this.groupBox1.Controls.Add(this.btnQuitter);
            this.groupBox1.Controls.Add(this.changeMDP);
            this.groupBox1.Controls.Add(this.changerPays);
            this.groupBox1.Controls.Add(this.labelLogin);
            this.groupBox1.Controls.Add(this.lblMdpActuel);
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
            // btnCoNvMdp
            // 
            this.btnCoNvMdp.BackgroundImage = global::Maquette.Properties.Resources.visibility;
            this.btnCoNvMdp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCoNvMdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoNvMdp.Location = new System.Drawing.Point(187, 334);
            this.btnCoNvMdp.Name = "btnCoNvMdp";
            this.btnCoNvMdp.Size = new System.Drawing.Size(26, 23);
            this.btnCoNvMdp.TabIndex = 19;
            this.btnCoNvMdp.UseVisualStyleBackColor = true;
            this.btnCoNvMdp.Click += new System.EventHandler(this.BtnCoNvMdp_Click);
            // 
            // btnNvMdp
            // 
            this.btnNvMdp.BackgroundImage = global::Maquette.Properties.Resources.visibility;
            this.btnNvMdp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNvMdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNvMdp.Location = new System.Drawing.Point(187, 266);
            this.btnNvMdp.Name = "btnNvMdp";
            this.btnNvMdp.Size = new System.Drawing.Size(26, 23);
            this.btnNvMdp.TabIndex = 18;
            this.btnNvMdp.UseVisualStyleBackColor = true;
            this.btnNvMdp.Click += new System.EventHandler(this.BtnNvMdp_Click);
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
            this.changeMDP.Click += new System.EventHandler(this.ChangeMDP_Click);
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
            // imgPortrait
            // 
            this.imgPortrait.Image = global::Maquette.Properties.Resources.user;
            this.imgPortrait.Location = new System.Drawing.Point(9, 20);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.Size = new System.Drawing.Size(100, 105);
            this.imgPortrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPortrait.TabIndex = 21;
            this.imgPortrait.TabStop = false;
            // 
            // CompteUtilisateurPourAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(633, 445);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelPrénom);
            this.Controls.Add(this.confirmedMDP);
            this.Controls.Add(this.lblCoNvMdp);
            this.Controls.Add(this.nouveauMDP);
            this.Controls.Add(this.lblNvMdp);
            this.Controls.Add(this.comboPays);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompteUtilisateurPourAdmin";
            this.Text = "CompteUtilisateur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPortrait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrénom;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label lblMdpActuel;
        private System.Windows.Forms.Label lblNvMdp;
        private System.Windows.Forms.Label lblCoNvMdp;
        private System.Windows.Forms.TextBox nouveauMDP;
        private System.Windows.Forms.TextBox confirmedMDP;
        private System.Windows.Forms.ComboBox comboPays;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.Button changerPays;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button changeMDP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCoNvMdp;
        private System.Windows.Forms.Button btnNvMdp;
        private System.Windows.Forms.Label mdpLabel;
        private System.Windows.Forms.PictureBox imgPortrait;
    }
}