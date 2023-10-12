
namespace CreditCeleste
{
    partial class frmListeCredits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeCredits));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblMonApplication = new System.Windows.Forms.Label();
            this.btnSupprimerHistorique = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.lstCredits = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1255, 90);
            this.lblHeader.TabIndex = 21;
            this.lblHeader.Text = "Crédit Céleste\r\nListe des crédits";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonApplication
            // 
            this.lblMonApplication.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMonApplication.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonApplication.ForeColor = System.Drawing.Color.Gray;
            this.lblMonApplication.Location = new System.Drawing.Point(20, 610);
            this.lblMonApplication.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
            this.lblMonApplication.Name = "lblMonApplication";
            this.lblMonApplication.Size = new System.Drawing.Size(1255, 25);
            this.lblMonApplication.TabIndex = 23;
            this.lblMonApplication.Text = "Crédits";
            this.lblMonApplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSupprimerHistorique
            // 
            this.btnSupprimerHistorique.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSupprimerHistorique.FlatAppearance.BorderSize = 0;
            this.btnSupprimerHistorique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerHistorique.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerHistorique.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerHistorique.Location = new System.Drawing.Point(519, 427);
            this.btnSupprimerHistorique.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerHistorique.Name = "btnSupprimerHistorique";
            this.btnSupprimerHistorique.Size = new System.Drawing.Size(253, 50);
            this.btnSupprimerHistorique.TabIndex = 28;
            this.btnSupprimerHistorique.Text = "Supprimer historique";
            this.btnSupprimerHistorique.UseVisualStyleBackColor = false;
            this.btnSupprimerHistorique.Click += new System.EventHandler(this.btnSupprimerHistorique_Click);
            // 
            // btnInit
            // 
            this.btnInit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInit.FlatAppearance.BorderSize = 0;
            this.btnInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInit.ForeColor = System.Drawing.Color.White;
            this.btnInit.Location = new System.Drawing.Point(519, 485);
            this.btnInit.Margin = new System.Windows.Forms.Padding(4);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(253, 50);
            this.btnInit.TabIndex = 29;
            this.btnInit.Text = "Réinitialiser";
            this.btnInit.UseVisualStyleBackColor = false;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCredit.FlatAppearance.BorderSize = 0;
            this.btnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredit.ForeColor = System.Drawing.Color.White;
            this.btnCredit.Location = new System.Drawing.Point(519, 543);
            this.btnCredit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(253, 50);
            this.btnCredit.TabIndex = 30;
            this.btnCredit.Text = "Retour";
            this.btnCredit.UseVisualStyleBackColor = false;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // lstCredits
            // 
            this.lstCredits.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCredits.FormattingEnabled = true;
            this.lstCredits.ItemHeight = 23;
            this.lstCredits.Location = new System.Drawing.Point(23, 113);
            this.lstCredits.Name = "lstCredits";
            this.lstCredits.Size = new System.Drawing.Size(1252, 303);
            this.lstCredits.TabIndex = 31;
            // 
            // frmListeCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 655);
            this.Controls.Add(this.lstCredits);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnSupprimerHistorique);
            this.Controls.Add(this.lblMonApplication);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListeCredits";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historique des crédits - Crédit Céleste";
            this.Load += new System.EventHandler(this.frmListeCredits_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblMonApplication;
        private System.Windows.Forms.Button btnSupprimerHistorique;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.ListBox lstCredits;
    }
}