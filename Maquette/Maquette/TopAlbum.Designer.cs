
namespace Maquette
{
    partial class TopAlbum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopAlbum));
            this.btnStyle = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.pnlElemEmprunt = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPageEmp = new System.Windows.Forms.Label();
            this.btnSuiEmp = new System.Windows.Forms.Button();
            this.btnPreEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStyle
            // 
            this.btnStyle.BackColor = System.Drawing.Color.Teal;
            this.btnStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStyle.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnStyle.Location = new System.Drawing.Point(12, 23);
            this.btnStyle.Name = "btnStyle";
            this.btnStyle.Size = new System.Drawing.Size(171, 76);
            this.btnStyle.TabIndex = 13;
            this.btnStyle.Text = "Les plus empruntés cette année";
            this.btnStyle.UseVisualStyleBackColor = false;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // pnlElemEmprunt
            // 
            this.pnlElemEmprunt.BackColor = System.Drawing.Color.Teal;
            this.pnlElemEmprunt.Location = new System.Drawing.Point(12, 118);
            this.pnlElemEmprunt.Name = "pnlElemEmprunt";
            this.pnlElemEmprunt.Size = new System.Drawing.Size(560, 389);
            this.pnlElemEmprunt.TabIndex = 14;
            // 
            // lblPageEmp
            // 
            this.lblPageEmp.AutoSize = true;
            this.lblPageEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblPageEmp.ForeColor = System.Drawing.Color.White;
            this.lblPageEmp.Location = new System.Drawing.Point(266, 523);
            this.lblPageEmp.Name = "lblPageEmp";
            this.lblPageEmp.Size = new System.Drawing.Size(32, 13);
            this.lblPageEmp.TabIndex = 17;
            this.lblPageEmp.Text = "Page";
            // 
            // btnSuiEmp
            // 
            this.btnSuiEmp.BackColor = System.Drawing.Color.Teal;
            this.btnSuiEmp.BackgroundImage = global::Maquette.Properties.Resources.fleche_droite;
            this.btnSuiEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuiEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnSuiEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuiEmp.Location = new System.Drawing.Point(497, 513);
            this.btnSuiEmp.Name = "btnSuiEmp";
            this.btnSuiEmp.Size = new System.Drawing.Size(75, 23);
            this.btnSuiEmp.TabIndex = 16;
            this.btnSuiEmp.UseVisualStyleBackColor = false;
            this.btnSuiEmp.Click += new System.EventHandler(this.BtnSuiEmp_Click);
            // 
            // btnPreEmp
            // 
            this.btnPreEmp.BackColor = System.Drawing.Color.Teal;
            this.btnPreEmp.BackgroundImage = global::Maquette.Properties.Resources.fleche_gauche;
            this.btnPreEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.btnPreEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreEmp.Location = new System.Drawing.Point(12, 513);
            this.btnPreEmp.Name = "btnPreEmp";
            this.btnPreEmp.Size = new System.Drawing.Size(75, 23);
            this.btnPreEmp.TabIndex = 15;
            this.btnPreEmp.UseVisualStyleBackColor = false;
            this.btnPreEmp.Click += new System.EventHandler(this.BtnPreEmp_Click);
            // 
            // TopAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maquette.Properties.Resources.flou1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.lblPageEmp);
            this.Controls.Add(this.btnSuiEmp);
            this.Controls.Add(this.btnPreEmp);
            this.Controls.Add(this.pnlElemEmprunt);
            this.Controls.Add(this.btnStyle);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TopAlbum";
            this.Text = "TopAlbum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStyle;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.FlowLayoutPanel pnlElemEmprunt;
        private System.Windows.Forms.Label lblPageEmp;
        private System.Windows.Forms.Button btnSuiEmp;
        private System.Windows.Forms.Button btnPreEmp;
    }
}