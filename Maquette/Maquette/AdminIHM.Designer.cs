
namespace Maquette
{
    partial class AdminIHM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminIHM));
            this.pnlBtn = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.imgAbo = new System.Windows.Forms.PictureBox();
            this.btnAbo = new System.Windows.Forms.Button();
            this.boxFantome = new System.Windows.Forms.GroupBox();
            this.imgFantome = new System.Windows.Forms.PictureBox();
            this.btnFantome = new System.Windows.Forms.Button();
            this.boxRetard = new System.Windows.Forms.GroupBox();
            this.imgRetard = new System.Windows.Forms.PictureBox();
            this.btnRetard = new System.Windows.Forms.Button();
            this.boxProlo = new System.Windows.Forms.GroupBox();
            this.imgProlo = new System.Windows.Forms.PictureBox();
            this.btnProlo = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.ToolStrip();
            this.lblAbo = new System.Windows.Forms.ToolStripLabel();
            this.barreMenu = new System.Windows.Forms.ToolStripSeparator();
            this.lblAlbum = new System.Windows.Forms.ToolStripLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlBtn.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbo)).BeginInit();
            this.boxFantome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFantome)).BeginInit();
            this.boxRetard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRetard)).BeginInit();
            this.boxProlo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProlo)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtn
            // 
            this.pnlBtn.Controls.Add(this.groupBox4);
            this.pnlBtn.Controls.Add(this.boxFantome);
            this.pnlBtn.Controls.Add(this.boxRetard);
            this.pnlBtn.Controls.Add(this.boxProlo);
            this.pnlBtn.Location = new System.Drawing.Point(98, 79);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(993, 499);
            this.pnlBtn.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.imgAbo);
            this.groupBox4.Controls.Add(this.btnAbo);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(984, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // imgAbo
            // 
            this.imgAbo.BackgroundImage = global::Maquette.Properties.Resources.user;
            this.imgAbo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgAbo.Location = new System.Drawing.Point(884, 15);
            this.imgAbo.Name = "imgAbo";
            this.imgAbo.Size = new System.Drawing.Size(86, 79);
            this.imgAbo.TabIndex = 7;
            this.imgAbo.TabStop = false;
            // 
            // btnAbo
            // 
            this.btnAbo.BackColor = System.Drawing.Color.Teal;
            this.btnAbo.FlatAppearance.BorderSize = 5;
            this.btnAbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnAbo.Location = new System.Drawing.Point(0, 2);
            this.btnAbo.Name = "btnAbo";
            this.btnAbo.Size = new System.Drawing.Size(984, 98);
            this.btnAbo.TabIndex = 6;
            this.btnAbo.Text = "Liste des abonnés";
            this.btnAbo.UseVisualStyleBackColor = false;
            this.btnAbo.Click += new System.EventHandler(this.BtnAbo_Click);
            // 
            // boxFantome
            // 
            this.boxFantome.BackColor = System.Drawing.Color.Teal;
            this.boxFantome.Controls.Add(this.imgFantome);
            this.boxFantome.Controls.Add(this.btnFantome);
            this.boxFantome.Location = new System.Drawing.Point(3, 109);
            this.boxFantome.Name = "boxFantome";
            this.boxFantome.Size = new System.Drawing.Size(990, 118);
            this.boxFantome.TabIndex = 0;
            this.boxFantome.TabStop = false;
            // 
            // imgFantome
            // 
            this.imgFantome.BackColor = System.Drawing.Color.Teal;
            this.imgFantome.BackgroundImage = global::Maquette.Properties.Resources.fantome;
            this.imgFantome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgFantome.Location = new System.Drawing.Point(884, 19);
            this.imgFantome.Name = "imgFantome";
            this.imgFantome.Size = new System.Drawing.Size(80, 80);
            this.imgFantome.TabIndex = 2;
            this.imgFantome.TabStop = false;
            // 
            // btnFantome
            // 
            this.btnFantome.BackColor = System.Drawing.Color.Teal;
            this.btnFantome.FlatAppearance.BorderSize = 5;
            this.btnFantome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFantome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnFantome.Location = new System.Drawing.Point(6, 14);
            this.btnFantome.Name = "btnFantome";
            this.btnFantome.Size = new System.Drawing.Size(978, 98);
            this.btnFantome.TabIndex = 3;
            this.btnFantome.Text = "Abonnés fantômes";
            this.btnFantome.UseVisualStyleBackColor = false;
            this.btnFantome.Click += new System.EventHandler(this.BtnFantome_Click);
            // 
            // boxRetard
            // 
            this.boxRetard.BackColor = System.Drawing.Color.Teal;
            this.boxRetard.Controls.Add(this.imgRetard);
            this.boxRetard.Controls.Add(this.btnRetard);
            this.boxRetard.Location = new System.Drawing.Point(3, 233);
            this.boxRetard.Name = "boxRetard";
            this.boxRetard.Size = new System.Drawing.Size(990, 120);
            this.boxRetard.TabIndex = 1;
            this.boxRetard.TabStop = false;
            // 
            // imgRetard
            // 
            this.imgRetard.BackgroundImage = global::Maquette.Properties.Resources.timer;
            this.imgRetard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgRetard.Location = new System.Drawing.Point(884, 21);
            this.imgRetard.Name = "imgRetard";
            this.imgRetard.Size = new System.Drawing.Size(80, 80);
            this.imgRetard.TabIndex = 3;
            this.imgRetard.TabStop = false;
            // 
            // btnRetard
            // 
            this.btnRetard.BackColor = System.Drawing.Color.Teal;
            this.btnRetard.FlatAppearance.BorderSize = 5;
            this.btnRetard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnRetard.Location = new System.Drawing.Point(6, 11);
            this.btnRetard.Name = "btnRetard";
            this.btnRetard.Size = new System.Drawing.Size(978, 98);
            this.btnRetard.TabIndex = 4;
            this.btnRetard.Text = "Retards supérieurs à 10 jours";
            this.btnRetard.UseVisualStyleBackColor = false;
            this.btnRetard.Click += new System.EventHandler(this.BtnRetard_Click);
            // 
            // boxProlo
            // 
            this.boxProlo.BackColor = System.Drawing.Color.Teal;
            this.boxProlo.Controls.Add(this.imgProlo);
            this.boxProlo.Controls.Add(this.btnProlo);
            this.boxProlo.Location = new System.Drawing.Point(3, 359);
            this.boxProlo.Name = "boxProlo";
            this.boxProlo.Size = new System.Drawing.Size(990, 130);
            this.boxProlo.TabIndex = 2;
            this.boxProlo.TabStop = false;
            // 
            // imgProlo
            // 
            this.imgProlo.BackgroundImage = global::Maquette.Properties.Resources.quick_time;
            this.imgProlo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgProlo.Location = new System.Drawing.Point(884, 28);
            this.imgProlo.Name = "imgProlo";
            this.imgProlo.Size = new System.Drawing.Size(80, 80);
            this.imgProlo.TabIndex = 4;
            this.imgProlo.TabStop = false;
            // 
            // btnProlo
            // 
            this.btnProlo.BackColor = System.Drawing.Color.Teal;
            this.btnProlo.FlatAppearance.BorderSize = 5;
            this.btnProlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProlo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnProlo.Location = new System.Drawing.Point(6, 19);
            this.btnProlo.Name = "btnProlo";
            this.btnProlo.Size = new System.Drawing.Size(978, 98);
            this.btnProlo.TabIndex = 5;
            this.btnProlo.Text = "Abonnés ayant prolongés";
            this.btnProlo.UseVisualStyleBackColor = false;
            this.btnProlo.Click += new System.EventHandler(this.BtnProlo_Click);
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.Teal;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAbo,
            this.barreMenu,
            this.lblAlbum});
            this.menu.Location = new System.Drawing.Point(60, 24);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(345, 43);
            this.menu.TabIndex = 2;
            this.menu.Text = "toolStrip1";
            // 
            // lblAbo
            // 
            this.lblAbo.AutoSize = false;
            this.lblAbo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.lblAbo.Name = "lblAbo";
            this.lblAbo.Size = new System.Drawing.Size(148, 40);
            this.lblAbo.Text = "Abonné";
            // 
            // barreMenu
            // 
            this.barreMenu.Name = "barreMenu";
            this.barreMenu.Size = new System.Drawing.Size(6, 43);
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = false;
            this.lblAlbum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(148, 40);
            this.lblAlbum.Text = "Album";
            this.lblAlbum.Click += new System.EventHandler(this.LblAlbum_Click);
            // 
            // AdminIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::Maquette.Properties.Resources.flou1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pnlBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminIHM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminIHM";
            this.pnlBtn.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAbo)).EndInit();
            this.boxFantome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgFantome)).EndInit();
            this.boxRetard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgRetard)).EndInit();
            this.boxProlo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProlo)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlBtn;
        private System.Windows.Forms.GroupBox boxFantome;
        private System.Windows.Forms.PictureBox imgFantome;
        private System.Windows.Forms.GroupBox boxRetard;
        private System.Windows.Forms.PictureBox imgRetard;
        private System.Windows.Forms.GroupBox boxProlo;
        private System.Windows.Forms.PictureBox imgProlo;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripLabel lblAbo;
        private System.Windows.Forms.ToolStripSeparator barreMenu;
        private System.Windows.Forms.ToolStripLabel lblAlbum;
        private System.Windows.Forms.Button btnFantome;
        private System.Windows.Forms.Button btnRetard;
        private System.Windows.Forms.Button btnProlo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox imgAbo;
        private System.Windows.Forms.Button btnAbo;
    }
}