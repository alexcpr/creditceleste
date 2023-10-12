
namespace CreditCeleste
{
    partial class frmSaisieBien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaisieBien));
            this.cboVoituresDisp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstDetailsVoiture = new System.Windows.Forms.ListBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblMonApplication = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrixVoiture = new System.Windows.Forms.Label();
            this.btnIntroduction = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboVoituresDisp
            // 
            this.cboVoituresDisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoituresDisp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVoituresDisp.FormattingEnabled = true;
            this.cboVoituresDisp.Location = new System.Drawing.Point(260, 140);
            this.cboVoituresDisp.Name = "cboVoituresDisp";
            this.cboVoituresDisp.Size = new System.Drawing.Size(409, 31);
            this.cboVoituresDisp.TabIndex = 18;
            this.cboVoituresDisp.SelectedIndexChanged += new System.EventHandler(this.cboVoituresDisp_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(26, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Voitures disponibles :";
            // 
            // lstDetailsVoiture
            // 
            this.lstDetailsVoiture.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDetailsVoiture.FormattingEnabled = true;
            this.lstDetailsVoiture.ItemHeight = 23;
            this.lstDetailsVoiture.Items.AddRange(new object[] {
            "Choissisez une voiture pour commencer"});
            this.lstDetailsVoiture.Location = new System.Drawing.Point(260, 177);
            this.lstDetailsVoiture.Name = "lstDetailsVoiture";
            this.lstDetailsVoiture.Size = new System.Drawing.Size(410, 234);
            this.lstDetailsVoiture.TabIndex = 20;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(661, 90);
            this.lblHeader.TabIndex = 21;
            this.lblHeader.Text = "Crédit Céleste\r\nVoitures disponibles";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonApplication
            // 
            this.lblMonApplication.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMonApplication.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonApplication.ForeColor = System.Drawing.Color.Gray;
            this.lblMonApplication.Location = new System.Drawing.Point(20, 546);
            this.lblMonApplication.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
            this.lblMonApplication.Name = "lblMonApplication";
            this.lblMonApplication.Size = new System.Drawing.Size(661, 25);
            this.lblMonApplication.TabIndex = 23;
            this.lblMonApplication.Text = "Crédits";
            this.lblMonApplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(27, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fiche technique        :";
            // 
            // lblPrixVoiture
            // 
            this.lblPrixVoiture.AutoSize = true;
            this.lblPrixVoiture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixVoiture.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPrixVoiture.Location = new System.Drawing.Point(27, 428);
            this.lblPrixVoiture.Name = "lblPrixVoiture";
            this.lblPrixVoiture.Size = new System.Drawing.Size(277, 28);
            this.lblPrixVoiture.TabIndex = 25;
            this.lblPrixVoiture.Text = "Prix : Choissisez une voiture";
            // 
            // btnIntroduction
            // 
            this.btnIntroduction.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIntroduction.FlatAppearance.BorderSize = 0;
            this.btnIntroduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntroduction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntroduction.ForeColor = System.Drawing.Color.White;
            this.btnIntroduction.Location = new System.Drawing.Point(512, 473);
            this.btnIntroduction.Margin = new System.Windows.Forms.Padding(4);
            this.btnIntroduction.Name = "btnIntroduction";
            this.btnIntroduction.Size = new System.Drawing.Size(158, 50);
            this.btnIntroduction.TabIndex = 29;
            this.btnIntroduction.Text = "Retour";
            this.btnIntroduction.UseVisualStyleBackColor = false;
            this.btnIntroduction.Click += new System.EventHandler(this.btnIntroduction_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(31, 473);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(158, 50);
            this.btnValider.TabIndex = 30;
            this.btnValider.Text = "Choisir";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // frmSaisieBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 591);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnIntroduction);
            this.Controls.Add(this.lblPrixVoiture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMonApplication);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lstDetailsVoiture);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboVoituresDisp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSaisieBien";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voitures disponibles - Crédit Céleste";
            this.Load += new System.EventHandler(this.frmSaisieBien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboVoituresDisp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstDetailsVoiture;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblMonApplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrixVoiture;
        private System.Windows.Forms.Button btnIntroduction;
        private System.Windows.Forms.Button btnValider;
    }
}