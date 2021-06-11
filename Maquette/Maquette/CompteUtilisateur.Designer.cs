
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
            this.bltFinPage = new System.Windows.Forms.Button();
            this.imgUtil = new System.Windows.Forms.Panel();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrénom = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.AncMdp = new System.Windows.Forms.Label();
            this.NvMdp = new System.Windows.Forms.Label();
            this.confMdp = new System.Windows.Forms.Label();
            this.ancienMDP = new System.Windows.Forms.TextBox();
            this.nouveauMDP = new System.Windows.Forms.TextBox();
            this.confirmedMDP = new System.Windows.Forms.TextBox();
            this.comboPays = new System.Windows.Forms.ComboBox();
            this.lblPays = new System.Windows.Forms.Label();
            this.changerPays = new System.Windows.Forms.Button();
            this.compteUtil = new System.Windows.Forms.GroupBox();
            this.lblConfMdp = new System.Windows.Forms.Button();
            this.lblNvMdp = new System.Windows.Forms.Button();
            this.lblAncMdp = new System.Windows.Forms.Button();
            this.changeMDP = new System.Windows.Forms.Button();
            this.contour = new System.Windows.Forms.GroupBox();
            this.compteUtil.SuspendLayout();
            this.SuspendLayout();
            // 
            // bltFinPage
            // 
            this.bltFinPage.BackColor = System.Drawing.Color.Teal;
            this.bltFinPage.BackgroundImage = global::Maquette.Properties.Resources.quitter;
            this.bltFinPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bltFinPage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bltFinPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bltFinPage.ForeColor = System.Drawing.Color.Teal;
            this.bltFinPage.Location = new System.Drawing.Point(559, 8);
            this.bltFinPage.Name = "bltFinPage";
            this.bltFinPage.Size = new System.Drawing.Size(41, 35);
            this.bltFinPage.TabIndex = 0;
            this.bltFinPage.UseVisualStyleBackColor = false;
            // 
            // imgUtil
            // 
            this.imgUtil.BackgroundImage = global::Maquette.Properties.Resources.user;
            this.imgUtil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgUtil.Location = new System.Drawing.Point(12, 21);
            this.imgUtil.Name = "imgUtil";
            this.imgUtil.Size = new System.Drawing.Size(81, 102);
            this.imgUtil.TabIndex = 1;
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
            // AncMdp
            // 
            this.AncMdp.AutoSize = true;
            this.AncMdp.BackColor = System.Drawing.Color.Teal;
            this.AncMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.AncMdp.ForeColor = System.Drawing.Color.Black;
            this.AncMdp.Location = new System.Drawing.Point(15, 173);
            this.AncMdp.Name = "AncMdp";
            this.AncMdp.Size = new System.Drawing.Size(187, 20);
            this.AncMdp.TabIndex = 5;
            this.AncMdp.Text = "Ancien mot de passe :";
            // 
            // NvMdp
            // 
            this.NvMdp.AutoSize = true;
            this.NvMdp.BackColor = System.Drawing.Color.Teal;
            this.NvMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.NvMdp.Location = new System.Drawing.Point(15, 239);
            this.NvMdp.Name = "NvMdp";
            this.NvMdp.Size = new System.Drawing.Size(202, 20);
            this.NvMdp.TabIndex = 6;
            this.NvMdp.Text = "Nouveau mot de passe :";
            // 
            // confMdp
            // 
            this.confMdp.AutoSize = true;
            this.confMdp.BackColor = System.Drawing.Color.Teal;
            this.confMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.confMdp.Location = new System.Drawing.Point(15, 309);
            this.confMdp.Name = "confMdp";
            this.confMdp.Size = new System.Drawing.Size(332, 20);
            this.confMdp.TabIndex = 7;
            this.confMdp.Text = "Confirmation du nouveau mot de passe :";
            // 
            // ancienMDP
            // 
            this.ancienMDP.BackColor = System.Drawing.Color.White;
            this.ancienMDP.ForeColor = System.Drawing.Color.Black;
            this.ancienMDP.Location = new System.Drawing.Point(19, 208);
            this.ancienMDP.MaxLength = 32;
            this.ancienMDP.Name = "ancienMDP";
            this.ancienMDP.PasswordChar = '●';
            this.ancienMDP.Size = new System.Drawing.Size(162, 20);
            this.ancienMDP.TabIndex = 8;
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
            // compteUtil
            // 
            this.compteUtil.BackColor = System.Drawing.Color.Teal;
            this.compteUtil.Controls.Add(this.lblConfMdp);
            this.compteUtil.Controls.Add(this.lblNvMdp);
            this.compteUtil.Controls.Add(this.lblAncMdp);
            this.compteUtil.Controls.Add(this.bltFinPage);
            this.compteUtil.Controls.Add(this.changeMDP);
            this.compteUtil.Controls.Add(this.changerPays);
            this.compteUtil.Controls.Add(this.labelLogin);
            this.compteUtil.Location = new System.Drawing.Point(4, 6);
            this.compteUtil.Name = "compteUtil";
            this.compteUtil.Size = new System.Drawing.Size(626, 434);
            this.compteUtil.TabIndex = 15;
            this.compteUtil.TabStop = false;
            // 
            // lblConfMdp
            // 
            this.lblConfMdp.BackgroundImage = global::Maquette.Properties.Resources.visibility;
            this.lblConfMdp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lblConfMdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConfMdp.Location = new System.Drawing.Point(187, 334);
            this.lblConfMdp.Name = "lblConfMdp";
            this.lblConfMdp.Size = new System.Drawing.Size(26, 23);
            this.lblConfMdp.TabIndex = 19;
            this.lblConfMdp.UseVisualStyleBackColor = true;
            this.lblConfMdp.Click += new System.EventHandler(this.ConfMdp_Click);
            // 
            // lblNvMdp
            // 
            this.lblNvMdp.BackgroundImage = global::Maquette.Properties.Resources.visibility;
            this.lblNvMdp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lblNvMdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNvMdp.Location = new System.Drawing.Point(187, 266);
            this.lblNvMdp.Name = "lblNvMdp";
            this.lblNvMdp.Size = new System.Drawing.Size(26, 23);
            this.lblNvMdp.TabIndex = 18;
            this.lblNvMdp.UseVisualStyleBackColor = true;
            this.lblNvMdp.Click += new System.EventHandler(this.NvMdp_Click);
            // 
            // lblAncMdp
            // 
            this.lblAncMdp.BackgroundImage = global::Maquette.Properties.Resources.visibility;
            this.lblAncMdp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lblAncMdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAncMdp.Location = new System.Drawing.Point(187, 200);
            this.lblAncMdp.Name = "lblAncMdp";
            this.lblAncMdp.Size = new System.Drawing.Size(26, 23);
            this.lblAncMdp.TabIndex = 17;
            this.lblAncMdp.UseVisualStyleBackColor = true;
            this.lblAncMdp.Click += new System.EventHandler(this.AncMdp_Click);
            // 
            // changeMDP
            // 
            this.changeMDP.BackColor = System.Drawing.Color.Teal;
            this.changeMDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeMDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changeMDP.Location = new System.Drawing.Point(49, 377);
            this.changeMDP.Name = "changeMDP";
            this.changeMDP.Size = new System.Drawing.Size(75, 26);
            this.changeMDP.TabIndex = 11;
            this.changeMDP.Text = "Changer";
            this.changeMDP.UseVisualStyleBackColor = false;
            this.changeMDP.Click += new System.EventHandler(this.ChangeMDP_Click);
            // 
            // contour
            // 
            this.contour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contour.ForeColor = System.Drawing.Color.Black;
            this.contour.Location = new System.Drawing.Point(-2, -7);
            this.contour.Name = "contour";
            this.contour.Size = new System.Drawing.Size(638, 453);
            this.contour.TabIndex = 15;
            this.contour.TabStop = false;
            this.contour.Text = "groupBox2";
            // 
            // CompteUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(633, 445);
            this.Controls.Add(this.imgUtil);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelPrénom);
            this.Controls.Add(this.confirmedMDP);
            this.Controls.Add(this.confMdp);
            this.Controls.Add(this.nouveauMDP);
            this.Controls.Add(this.NvMdp);
            this.Controls.Add(this.ancienMDP);
            this.Controls.Add(this.AncMdp);
            this.Controls.Add(this.comboPays);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.compteUtil);
            this.Controls.Add(this.contour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompteUtilisateur";
            this.Text = "CompteUtilisateur";
            this.compteUtil.ResumeLayout(false);
            this.compteUtil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bltFinPage;
        private System.Windows.Forms.Panel imgUtil;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrénom;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label AncMdp;
        private System.Windows.Forms.Label NvMdp;
        private System.Windows.Forms.Label confMdp;
        private System.Windows.Forms.TextBox ancienMDP;
        private System.Windows.Forms.TextBox nouveauMDP;
        private System.Windows.Forms.TextBox confirmedMDP;
        private System.Windows.Forms.ComboBox comboPays;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.Button changerPays;
        private System.Windows.Forms.GroupBox compteUtil;
        private System.Windows.Forms.Button changeMDP;
        private System.Windows.Forms.GroupBox contour;
        private System.Windows.Forms.Button lblConfMdp;
        private System.Windows.Forms.Button lblNvMdp;
        private System.Windows.Forms.Button lblAncMdp;
    }
}