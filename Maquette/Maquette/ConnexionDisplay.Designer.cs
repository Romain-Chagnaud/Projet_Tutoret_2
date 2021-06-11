
namespace Maquette
{
    partial class ConnexionDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnexionDisplay));
            this.ConnexionPanel = new System.Windows.Forms.Panel();
            this.afficherCoMdp = new System.Windows.Forms.Button();
            this.logoBoutique = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.lblInsIdentifiant = new System.Windows.Forms.Label();
            this.lblCoIdentifiant = new System.Windows.Forms.Label();
            this.inscription = new System.Windows.Forms.Label();
            this.lblConnexion = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.InscriptionPannel = new System.Windows.Forms.Panel();
            this.afficherInsConfMdp = new System.Windows.Forms.Button();
            this.afficherInsNvMdp = new System.Windows.Forms.Button();
            this.lblInsConfMdp = new System.Windows.Forms.Label();
            this.PassConfirm = new System.Windows.Forms.TextBox();
            this.lblInsPays = new System.Windows.Forms.Label();
            this.comboBoxP = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.lblInsNom = new System.Windows.Forms.Label();
            this.lblInsNvMdp = new System.Windows.Forms.Label();
            this.lblInsPrenom = new System.Windows.Forms.Label();
            this.lblInsId = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.prenomBox = new System.Windows.Forms.TextBox();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.SignButton = new System.Windows.Forms.Button();
            this.ConnexionPanel.SuspendLayout();
            this.InscriptionPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnexionPanel
            // 
            this.ConnexionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.ConnexionPanel.Controls.Add(this.afficherCoMdp);
            this.ConnexionPanel.Controls.Add(this.logoBoutique);
            this.ConnexionPanel.Controls.Add(this.textBoxPass);
            this.ConnexionPanel.Controls.Add(this.lblInsIdentifiant);
            this.ConnexionPanel.Controls.Add(this.lblCoIdentifiant);
            this.ConnexionPanel.Controls.Add(this.inscription);
            this.ConnexionPanel.Controls.Add(this.lblConnexion);
            this.ConnexionPanel.Controls.Add(this.textBoxId);
            this.ConnexionPanel.Location = new System.Drawing.Point(437, 150);
            this.ConnexionPanel.Name = "ConnexionPanel";
            this.ConnexionPanel.Size = new System.Drawing.Size(349, 400);
            this.ConnexionPanel.TabIndex = 0;
            // 
            // afficherCoMdp
            // 
            this.afficherCoMdp.BackgroundImage = global::Maquette.Properties.Resources.visibility;
            this.afficherCoMdp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.afficherCoMdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afficherCoMdp.Location = new System.Drawing.Point(279, 183);
            this.afficherCoMdp.Name = "afficherCoMdp";
            this.afficherCoMdp.Size = new System.Drawing.Size(26, 23);
            this.afficherCoMdp.TabIndex = 15;
            this.afficherCoMdp.UseVisualStyleBackColor = true;
            this.afficherCoMdp.Click += new System.EventHandler(this.AfficherCoMdp_Click);
            // 
            // logoBoutique
            // 
            this.logoBoutique.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoBoutique.BackgroundImage")));
            this.logoBoutique.Location = new System.Drawing.Point(131, 0);
            this.logoBoutique.Name = "logoBoutique";
            this.logoBoutique.Size = new System.Drawing.Size(100, 100);
            this.logoBoutique.TabIndex = 14;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.textBoxPass.Location = new System.Drawing.Point(23, 183);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '●';
            this.textBoxPass.Size = new System.Drawing.Size(250, 23);
            this.textBoxPass.TabIndex = 1;
            // 
            // lblInsIdentifiant
            // 
            this.lblInsIdentifiant.AutoSize = true;
            this.lblInsIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsIdentifiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.lblInsIdentifiant.Location = new System.Drawing.Point(19, 160);
            this.lblInsIdentifiant.Name = "lblInsIdentifiant";
            this.lblInsIdentifiant.Size = new System.Drawing.Size(105, 20);
            this.lblInsIdentifiant.TabIndex = 12;
            this.lblInsIdentifiant.Text = "Mot de passe";
            // 
            // lblCoIdentifiant
            // 
            this.lblCoIdentifiant.AutoSize = true;
            this.lblCoIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoIdentifiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.lblCoIdentifiant.Location = new System.Drawing.Point(19, 102);
            this.lblCoIdentifiant.Name = "lblCoIdentifiant";
            this.lblCoIdentifiant.Size = new System.Drawing.Size(80, 20);
            this.lblCoIdentifiant.TabIndex = 11;
            this.lblCoIdentifiant.Text = "Identifiant";
            // 
            // inscription
            // 
            this.inscription.AutoSize = true;
            this.inscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.inscription.Location = new System.Drawing.Point(20, 209);
            this.inscription.Name = "inscription";
            this.inscription.Size = new System.Drawing.Size(182, 16);
            this.inscription.TabIndex = 3;
            this.inscription.Text = "Pas encore inscrit ? S\'inscrire";
            this.inscription.Click += new System.EventHandler(this.Inscription_Click);
            this.inscription.MouseLeave += new System.EventHandler(this.Inscription_MouseLeave);
            this.inscription.MouseHover += new System.EventHandler(this.Inscription_MouseHover);
            // 
            // lblConnexion
            // 
            this.lblConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.lblConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConnexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.lblConnexion.FlatAppearance.BorderSize = 0;
            this.lblConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblConnexion.Location = new System.Drawing.Point(102, 252);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(150, 35);
            this.lblConnexion.TabIndex = 2;
            this.lblConnexion.Text = "Connexion";
            this.lblConnexion.UseVisualStyleBackColor = false;
            this.lblConnexion.Click += new System.EventHandler(this.LblConnexion_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.textBoxId.Location = new System.Drawing.Point(23, 125);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(250, 23);
            this.textBoxId.TabIndex = 0;
            // 
            // InscriptionPannel
            // 
            this.InscriptionPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.InscriptionPannel.Controls.Add(this.afficherInsConfMdp);
            this.InscriptionPannel.Controls.Add(this.afficherInsNvMdp);
            this.InscriptionPannel.Controls.Add(this.lblInsConfMdp);
            this.InscriptionPannel.Controls.Add(this.PassConfirm);
            this.InscriptionPannel.Controls.Add(this.lblInsPays);
            this.InscriptionPannel.Controls.Add(this.comboBoxP);
            this.InscriptionPannel.Controls.Add(this.button2);
            this.InscriptionPannel.Controls.Add(this.passBox);
            this.InscriptionPannel.Controls.Add(this.lblInsNom);
            this.InscriptionPannel.Controls.Add(this.lblInsNvMdp);
            this.InscriptionPannel.Controls.Add(this.lblInsPrenom);
            this.InscriptionPannel.Controls.Add(this.lblInsId);
            this.InscriptionPannel.Controls.Add(this.idBox);
            this.InscriptionPannel.Controls.Add(this.prenomBox);
            this.InscriptionPannel.Controls.Add(this.nomBox);
            this.InscriptionPannel.Controls.Add(this.SignButton);
            this.InscriptionPannel.Location = new System.Drawing.Point(415, 124);
            this.InscriptionPannel.Name = "InscriptionPannel";
            this.InscriptionPannel.Size = new System.Drawing.Size(380, 452);
            this.InscriptionPannel.TabIndex = 2;
            // 
            // afficherInsConfMdp
            // 
            this.afficherInsConfMdp.BackgroundImage = global::Maquette.Properties.Resources.visibility;
            this.afficherInsConfMdp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.afficherInsConfMdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afficherInsConfMdp.Location = new System.Drawing.Point(324, 356);
            this.afficherInsConfMdp.Name = "afficherInsConfMdp";
            this.afficherInsConfMdp.Size = new System.Drawing.Size(26, 23);
            this.afficherInsConfMdp.TabIndex = 17;
            this.afficherInsConfMdp.UseVisualStyleBackColor = true;
            this.afficherInsConfMdp.Click += new System.EventHandler(this.AfficherInsConfMdp_Click);
            // 
            // afficherInsNvMdp
            // 
            this.afficherInsNvMdp.BackgroundImage = global::Maquette.Properties.Resources.visibility;
            this.afficherInsNvMdp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.afficherInsNvMdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afficherInsNvMdp.Location = new System.Drawing.Point(324, 289);
            this.afficherInsNvMdp.Name = "afficherInsNvMdp";
            this.afficherInsNvMdp.Size = new System.Drawing.Size(26, 23);
            this.afficherInsNvMdp.TabIndex = 16;
            this.afficherInsNvMdp.UseVisualStyleBackColor = true;
            this.afficherInsNvMdp.Click += new System.EventHandler(this.AfficherInsNvMdp_Click);
            // 
            // lblInsConfMdp
            // 
            this.lblInsConfMdp.AutoSize = true;
            this.lblInsConfMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsConfMdp.Location = new System.Drawing.Point(19, 333);
            this.lblInsConfMdp.Name = "lblInsConfMdp";
            this.lblInsConfMdp.Size = new System.Drawing.Size(194, 20);
            this.lblInsConfMdp.TabIndex = 13;
            this.lblInsConfMdp.Text = "Confirmer le mot de passe";
            // 
            // PassConfirm
            // 
            this.PassConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.PassConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.PassConfirm.Location = new System.Drawing.Point(21, 356);
            this.PassConfirm.Name = "PassConfirm";
            this.PassConfirm.PasswordChar = '●';
            this.PassConfirm.Size = new System.Drawing.Size(297, 23);
            this.PassConfirm.TabIndex = 12;
            // 
            // lblInsPays
            // 
            this.lblInsPays.AutoSize = true;
            this.lblInsPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsPays.Location = new System.Drawing.Point(19, 205);
            this.lblInsPays.Name = "lblInsPays";
            this.lblInsPays.Size = new System.Drawing.Size(43, 20);
            this.lblInsPays.TabIndex = 11;
            this.lblInsPays.Text = "Pays";
            // 
            // comboBoxP
            // 
            this.comboBoxP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.comboBoxP.FormattingEnabled = true;
            this.comboBoxP.ItemHeight = 13;
            this.comboBoxP.Location = new System.Drawing.Point(23, 228);
            this.comboBoxP.MaxDropDownItems = 5;
            this.comboBoxP.Name = "comboBoxP";
            this.comboBoxP.Size = new System.Drawing.Size(295, 21);
            this.comboBoxP.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Coral;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(324, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 35);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.RetourPgConnexion_Click);
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.passBox.Location = new System.Drawing.Point(21, 289);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '●';
            this.passBox.Size = new System.Drawing.Size(297, 23);
            this.passBox.TabIndex = 7;
            // 
            // lblInsNom
            // 
            this.lblInsNom.AutoSize = true;
            this.lblInsNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsNom.Location = new System.Drawing.Point(17, 15);
            this.lblInsNom.Name = "lblInsNom";
            this.lblInsNom.Size = new System.Drawing.Size(42, 20);
            this.lblInsNom.TabIndex = 10;
            this.lblInsNom.Text = "Nom";
            // 
            // lblInsNvMdp
            // 
            this.lblInsNvMdp.AutoSize = true;
            this.lblInsNvMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsNvMdp.Location = new System.Drawing.Point(17, 266);
            this.lblInsNvMdp.Name = "lblInsNvMdp";
            this.lblInsNvMdp.Size = new System.Drawing.Size(172, 20);
            this.lblInsNvMdp.TabIndex = 7;
            this.lblInsNvMdp.Text = "Nouveau mot de passe";
            // 
            // lblInsPrenom
            // 
            this.lblInsPrenom.AutoSize = true;
            this.lblInsPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsPrenom.Location = new System.Drawing.Point(17, 80);
            this.lblInsPrenom.Name = "lblInsPrenom";
            this.lblInsPrenom.Size = new System.Drawing.Size(64, 20);
            this.lblInsPrenom.TabIndex = 9;
            this.lblInsPrenom.Text = "Prénom";
            // 
            // lblInsId
            // 
            this.lblInsId.AutoSize = true;
            this.lblInsId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsId.Location = new System.Drawing.Point(17, 140);
            this.lblInsId.Name = "lblInsId";
            this.lblInsId.Size = new System.Drawing.Size(80, 20);
            this.lblInsId.TabIndex = 8;
            this.lblInsId.Text = "Identifiant";
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.idBox.Location = new System.Drawing.Point(21, 163);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(297, 23);
            this.idBox.TabIndex = 6;
            // 
            // prenomBox
            // 
            this.prenomBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.prenomBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prenomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.prenomBox.Location = new System.Drawing.Point(21, 106);
            this.prenomBox.Name = "prenomBox";
            this.prenomBox.Size = new System.Drawing.Size(297, 23);
            this.prenomBox.TabIndex = 5;
            // 
            // nomBox
            // 
            this.nomBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.nomBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.nomBox.Location = new System.Drawing.Point(21, 41);
            this.nomBox.Name = "nomBox";
            this.nomBox.Size = new System.Drawing.Size(297, 23);
            this.nomBox.TabIndex = 4;
            // 
            // SignButton
            // 
            this.SignButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.SignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.SignButton.FlatAppearance.BorderSize = 0;
            this.SignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SignButton.Location = new System.Drawing.Point(102, 400);
            this.SignButton.Name = "SignButton";
            this.SignButton.Size = new System.Drawing.Size(150, 35);
            this.SignButton.TabIndex = 8;
            this.SignButton.Text = "S\'inscrire";
            this.SignButton.UseVisualStyleBackColor = false;
            this.SignButton.Click += new System.EventHandler(this.SignButton_Click);
            // 
            // ConnexionDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.InscriptionPannel);
            this.Controls.Add(this.ConnexionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnexionDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnexionDisplay";
            this.ConnexionPanel.ResumeLayout(false);
            this.ConnexionPanel.PerformLayout();
            this.InscriptionPannel.ResumeLayout(false);
            this.InscriptionPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ConnexionPanel;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button lblConnexion;
        private System.Windows.Forms.Label inscription;
        private System.Windows.Forms.Label lblInsIdentifiant;
        private System.Windows.Forms.Label lblCoIdentifiant;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.FlowLayoutPanel logoBoutique;
        private System.Windows.Forms.Panel InscriptionPannel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblInsNom;
        private System.Windows.Forms.Label lblInsPrenom;
        private System.Windows.Forms.Label lblInsId;
        private System.Windows.Forms.Label lblInsNvMdp;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox prenomBox;
        private System.Windows.Forms.TextBox nomBox;
        private System.Windows.Forms.Button SignButton;
        private System.Windows.Forms.ComboBox comboBoxP;
        private System.Windows.Forms.Label lblInsPays;
        private System.Windows.Forms.Label lblInsConfMdp;
        private System.Windows.Forms.TextBox PassConfirm;
        private System.Windows.Forms.Button afficherCoMdp;
        private System.Windows.Forms.Button afficherInsConfMdp;
        private System.Windows.Forms.Button afficherInsNvMdp;
    }
}