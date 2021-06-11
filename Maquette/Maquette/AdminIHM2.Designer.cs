
namespace Maquette
{
    partial class AdminIHM2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminIHM2));
            this.menu = new System.Windows.Forms.ToolStrip();
            this.lblAbo = new System.Windows.Forms.ToolStripLabel();
            this.barreMenu = new System.Windows.Forms.ToolStripSeparator();
            this.lblAlbum = new System.Windows.Forms.ToolStripLabel();
            this.pnlElement = new System.Windows.Forms.FlowLayoutPanel();
            this.boxPasEmp = new System.Windows.Forms.GroupBox();
            this.imgPasEmp = new System.Windows.Forms.PictureBox();
            this.btnPasEmp = new System.Windows.Forms.Button();
            this.boxTop = new System.Windows.Forms.GroupBox();
            this.imgTop = new System.Windows.Forms.PictureBox();
            this.btnTop = new System.Windows.Forms.Button();
            this.boxCasier = new System.Windows.Forms.GroupBox();
            this.imgCasier = new System.Windows.Forms.PictureBox();
            this.btnCasier = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.pnlElement.SuspendLayout();
            this.boxPasEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPasEmp)).BeginInit();
            this.boxTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTop)).BeginInit();
            this.boxCasier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCasier)).BeginInit();
            this.SuspendLayout();
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
            this.menu.TabIndex = 4;
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
            this.lblAbo.Click += new System.EventHandler(this.LblAbo_Click);
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
            // 
            // pnlElement
            // 
            this.pnlElement.BackColor = System.Drawing.Color.Teal;
            this.pnlElement.Controls.Add(this.boxPasEmp);
            this.pnlElement.Controls.Add(this.boxTop);
            this.pnlElement.Controls.Add(this.boxCasier);
            this.pnlElement.Location = new System.Drawing.Point(89, 188);
            this.pnlElement.Name = "pnlElement";
            this.pnlElement.Size = new System.Drawing.Size(993, 394);
            this.pnlElement.TabIndex = 3;
            // 
            // boxPasEmp
            // 
            this.boxPasEmp.BackColor = System.Drawing.Color.Teal;
            this.boxPasEmp.Controls.Add(this.imgPasEmp);
            this.boxPasEmp.Controls.Add(this.btnPasEmp);
            this.boxPasEmp.Location = new System.Drawing.Point(3, 3);
            this.boxPasEmp.Name = "boxPasEmp";
            this.boxPasEmp.Size = new System.Drawing.Size(990, 118);
            this.boxPasEmp.TabIndex = 0;
            this.boxPasEmp.TabStop = false;
            // 
            // imgPasEmp
            // 
            this.imgPasEmp.BackColor = System.Drawing.Color.Teal;
            this.imgPasEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgPasEmp.Image = global::Maquette.Properties.Resources.emojidansbulle;
            this.imgPasEmp.Location = new System.Drawing.Point(884, 19);
            this.imgPasEmp.Name = "imgPasEmp";
            this.imgPasEmp.Size = new System.Drawing.Size(70, 80);
            this.imgPasEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPasEmp.TabIndex = 2;
            this.imgPasEmp.TabStop = false;
            // 
            // btnPasEmp
            // 
            this.btnPasEmp.BackColor = System.Drawing.Color.Teal;
            this.btnPasEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPasEmp.FlatAppearance.BorderSize = 5;
            this.btnPasEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnPasEmp.Location = new System.Drawing.Point(6, 14);
            this.btnPasEmp.Name = "btnPasEmp";
            this.btnPasEmp.Size = new System.Drawing.Size(978, 98);
            this.btnPasEmp.TabIndex = 3;
            this.btnPasEmp.Text = "Albums pas empruntés depuis plus d\'un an";
            this.btnPasEmp.UseVisualStyleBackColor = false;
            this.btnPasEmp.Click += new System.EventHandler(this.BtnPasEmp_Click);
            // 
            // boxTop
            // 
            this.boxTop.BackColor = System.Drawing.Color.Teal;
            this.boxTop.Controls.Add(this.imgTop);
            this.boxTop.Controls.Add(this.btnTop);
            this.boxTop.Location = new System.Drawing.Point(3, 127);
            this.boxTop.Name = "boxTop";
            this.boxTop.Size = new System.Drawing.Size(990, 120);
            this.boxTop.TabIndex = 1;
            this.boxTop.TabStop = false;
            // 
            // imgTop
            // 
            this.imgTop.BackColor = System.Drawing.Color.Transparent;
            this.imgTop.BackgroundImage = global::Maquette.Properties.Resources.ranking;
            this.imgTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgTop.Location = new System.Drawing.Point(884, 21);
            this.imgTop.Name = "imgTop";
            this.imgTop.Size = new System.Drawing.Size(80, 80);
            this.imgTop.TabIndex = 3;
            this.imgTop.TabStop = false;
            // 
            // btnTop
            // 
            this.btnTop.BackColor = System.Drawing.Color.Teal;
            this.btnTop.FlatAppearance.BorderSize = 5;
            this.btnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnTop.Location = new System.Drawing.Point(6, 11);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(978, 98);
            this.btnTop.TabIndex = 4;
            this.btnTop.Text = "Top albums de l\'année";
            this.btnTop.UseVisualStyleBackColor = false;
            this.btnTop.Click += new System.EventHandler(this.BtnTop_Click);
            // 
            // boxCasier
            // 
            this.boxCasier.BackColor = System.Drawing.Color.Teal;
            this.boxCasier.Controls.Add(this.imgCasier);
            this.boxCasier.Controls.Add(this.btnCasier);
            this.boxCasier.Location = new System.Drawing.Point(3, 253);
            this.boxCasier.Name = "boxCasier";
            this.boxCasier.Size = new System.Drawing.Size(990, 120);
            this.boxCasier.TabIndex = 2;
            this.boxCasier.TabStop = false;
            // 
            // imgCasier
            // 
            this.imgCasier.BackColor = System.Drawing.Color.Transparent;
            this.imgCasier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgCasier.Image = global::Maquette.Properties.Resources.lockers;
            this.imgCasier.Location = new System.Drawing.Point(884, 21);
            this.imgCasier.Name = "imgCasier";
            this.imgCasier.Size = new System.Drawing.Size(80, 80);
            this.imgCasier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCasier.TabIndex = 3;
            this.imgCasier.TabStop = false;
            // 
            // btnCasier
            // 
            this.btnCasier.BackColor = System.Drawing.Color.Teal;
            this.btnCasier.FlatAppearance.BorderSize = 5;
            this.btnCasier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnCasier.Location = new System.Drawing.Point(6, 11);
            this.btnCasier.Name = "btnCasier";
            this.btnCasier.Size = new System.Drawing.Size(978, 98);
            this.btnCasier.TabIndex = 4;
            this.btnCasier.Text = "Album manquant des casiers";
            this.btnCasier.UseVisualStyleBackColor = false;
            this.btnCasier.Click += new System.EventHandler(this.btnCasier_Click);
            // 
            // AdminIHM2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::Maquette.Properties.Resources.flou;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pnlElement);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminIHM2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminIHM2";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.pnlElement.ResumeLayout(false);
            this.boxPasEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPasEmp)).EndInit();
            this.boxTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgTop)).EndInit();
            this.boxCasier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCasier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripLabel lblAbo;
        private System.Windows.Forms.ToolStripSeparator barreMenu;
        private System.Windows.Forms.ToolStripLabel lblAlbum;
        private System.Windows.Forms.FlowLayoutPanel pnlElement;
        private System.Windows.Forms.GroupBox boxPasEmp;
        private System.Windows.Forms.Button btnPasEmp;
        private System.Windows.Forms.GroupBox boxTop;
        private System.Windows.Forms.PictureBox imgTop;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.PictureBox imgPasEmp;
        private System.Windows.Forms.GroupBox boxCasier;
        private System.Windows.Forms.PictureBox imgCasier;
        private System.Windows.Forms.Button btnCasier;
    }
}