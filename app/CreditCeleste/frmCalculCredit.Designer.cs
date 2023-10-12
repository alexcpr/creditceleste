
namespace CreditCeleste
{
    partial class frmCalculCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculCredit));
            this.txtMensualite = new System.Windows.Forms.TextBox();
            this.cboDureeMois = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblMonApplication = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtMontantCredit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.btnListeCredits = new System.Windows.Forms.Button();
            this.btnVoiture = new System.Windows.Forms.Button();
            this.btnIntroduction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMensualite
            // 
            this.txtMensualite.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensualite.Location = new System.Drawing.Point(363, 203);
            this.txtMensualite.Margin = new System.Windows.Forms.Padding(4);
            this.txtMensualite.Name = "txtMensualite";
            this.txtMensualite.ReadOnly = true;
            this.txtMensualite.Size = new System.Drawing.Size(169, 30);
            this.txtMensualite.TabIndex = 1;
            // 
            // cboDureeMois
            // 
            this.cboDureeMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDureeMois.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDureeMois.FormattingEnabled = true;
            this.cboDureeMois.Items.AddRange(new object[] {
            "6",
            "12",
            "24",
            "36",
            "48",
            "60",
            "72"});
            this.cboDureeMois.Location = new System.Drawing.Point(363, 164);
            this.cboDureeMois.Margin = new System.Windows.Forms.Padding(4);
            this.cboDureeMois.Name = "cboDureeMois";
            this.cboDureeMois.Size = new System.Drawing.Size(169, 31);
            this.cboDureeMois.TabIndex = 3;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(694, 90);
            this.lblHeader.TabIndex = 21;
            this.lblHeader.Text = "Crédit Céleste\r\nCalcul du Crédit";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonApplication
            // 
            this.lblMonApplication.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMonApplication.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonApplication.ForeColor = System.Drawing.Color.Gray;
            this.lblMonApplication.Location = new System.Drawing.Point(20, 484);
            this.lblMonApplication.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
            this.lblMonApplication.Name = "lblMonApplication";
            this.lblMonApplication.Size = new System.Drawing.Size(694, 25);
            this.lblMonApplication.TabIndex = 23;
            this.lblMonApplication.Text = "Crédits";
            this.lblMonApplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNom.Location = new System.Drawing.Point(168, 129);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(165, 23);
            this.lblNom.TabIndex = 25;
            this.lblNom.Text = "Montant emprunté :";
            // 
            // txtMontantCredit
            // 
            this.txtMontantCredit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontantCredit.Location = new System.Drawing.Point(363, 126);
            this.txtMontantCredit.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontantCredit.Name = "txtMontantCredit";
            this.txtMontantCredit.ReadOnly = true;
            this.txtMontantCredit.Size = new System.Drawing.Size(169, 30);
            this.txtMontantCredit.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(168, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Durée (mois) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(168, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mensualité à payer :";
            // 
            // btnCalcul
            // 
            this.btnCalcul.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalcul.FlatAppearance.BorderSize = 0;
            this.btnCalcul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcul.ForeColor = System.Drawing.Color.White;
            this.btnCalcul.Location = new System.Drawing.Point(172, 241);
            this.btnCalcul.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(360, 50);
            this.btnCalcul.TabIndex = 28;
            this.btnCalcul.Text = "Calculer la mensualité";
            this.btnCalcul.UseVisualStyleBackColor = false;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // btnListeCredits
            // 
            this.btnListeCredits.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnListeCredits.FlatAppearance.BorderSize = 0;
            this.btnListeCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeCredits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeCredits.ForeColor = System.Drawing.Color.White;
            this.btnListeCredits.Location = new System.Drawing.Point(172, 299);
            this.btnListeCredits.Margin = new System.Windows.Forms.Padding(4);
            this.btnListeCredits.Name = "btnListeCredits";
            this.btnListeCredits.Size = new System.Drawing.Size(360, 50);
            this.btnListeCredits.TabIndex = 29;
            this.btnListeCredits.Text = "Historique";
            this.btnListeCredits.UseVisualStyleBackColor = false;
            this.btnListeCredits.Click += new System.EventHandler(this.btnListeCredits_Click);
            // 
            // btnVoiture
            // 
            this.btnVoiture.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVoiture.FlatAppearance.BorderSize = 0;
            this.btnVoiture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoiture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoiture.ForeColor = System.Drawing.Color.White;
            this.btnVoiture.Location = new System.Drawing.Point(172, 357);
            this.btnVoiture.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoiture.Name = "btnVoiture";
            this.btnVoiture.Size = new System.Drawing.Size(360, 50);
            this.btnVoiture.TabIndex = 30;
            this.btnVoiture.Text = "Choisir une autre voiture";
            this.btnVoiture.UseVisualStyleBackColor = false;
            this.btnVoiture.Click += new System.EventHandler(this.btnVoiture_Click);
            // 
            // btnIntroduction
            // 
            this.btnIntroduction.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIntroduction.FlatAppearance.BorderSize = 0;
            this.btnIntroduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntroduction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntroduction.ForeColor = System.Drawing.Color.White;
            this.btnIntroduction.Location = new System.Drawing.Point(172, 415);
            this.btnIntroduction.Margin = new System.Windows.Forms.Padding(4);
            this.btnIntroduction.Name = "btnIntroduction";
            this.btnIntroduction.Size = new System.Drawing.Size(360, 50);
            this.btnIntroduction.TabIndex = 31;
            this.btnIntroduction.Text = "Retour";
            this.btnIntroduction.UseVisualStyleBackColor = false;
            this.btnIntroduction.Click += new System.EventHandler(this.btnIntroduction_Click);
            // 
            // frmCalculCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 529);
            this.Controls.Add(this.btnIntroduction);
            this.Controls.Add(this.btnVoiture);
            this.Controls.Add(this.btnListeCredits);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtMontantCredit);
            this.Controls.Add(this.lblMonApplication);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.cboDureeMois);
            this.Controls.Add(this.txtMensualite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCalculCredit";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcul Crédit - Crédit Céleste";
            this.Load += new System.EventHandler(this.frmCalculCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMensualite;
        private System.Windows.Forms.ComboBox cboDureeMois;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblMonApplication;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtMontantCredit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Button btnListeCredits;
        private System.Windows.Forms.Button btnVoiture;
        private System.Windows.Forms.Button btnIntroduction;
    }
}