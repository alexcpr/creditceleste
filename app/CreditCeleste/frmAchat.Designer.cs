
namespace CreditCeleste
{
    partial class frmAchat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAchat));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblMonApplication = new System.Windows.Forms.Label();
            this.gpbMethodePaiement = new System.Windows.Forms.GroupBox();
            this.rdbEspece = new System.Windows.Forms.RadioButton();
            this.rdbCheque = new System.Windows.Forms.RadioButton();
            this.rdbCB = new System.Windows.Forms.RadioButton();
            this.lblPrixVoiture = new System.Windows.Forms.Label();
            this.lblFicheTechniqueVoit = new System.Windows.Forms.Label();
            this.lstDetailsVoiture = new System.Windows.Forms.ListBox();
            this.lblVoitureChoisie = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNouvVhc = new System.Windows.Forms.TextBox();
            this.gpbAncVhc = new System.Windows.Forms.GroupBox();
            this.txtAncVhcKilometrage = new System.Windows.Forms.TextBox();
            this.lblAncVhcKilometrage = new System.Windows.Forms.Label();
            this.lblAncVhcPlaque = new System.Windows.Forms.Label();
            this.txtAncVhcPlaque = new System.Windows.Forms.TextBox();
            this.gpbAgeAncVhc = new System.Windows.Forms.GroupBox();
            this.OCC5 = new System.Windows.Forms.RadioButton();
            this.OCC35 = new System.Windows.Forms.RadioButton();
            this.NF = new System.Windows.Forms.RadioButton();
            this.OCC3 = new System.Windows.Forms.RadioButton();
            this.btnAcheter = new System.Windows.Forms.Button();
            this.chkCredit = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDureeMois = new System.Windows.Forms.ComboBox();
            this.gpbMethodePaiement.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbAncVhc.SuspendLayout();
            this.gpbAgeAncVhc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1210, 90);
            this.lblHeader.TabIndex = 21;
            this.lblHeader.Text = "Crédit Céleste\r\nPaiement";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonApplication
            // 
            this.lblMonApplication.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMonApplication.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonApplication.ForeColor = System.Drawing.Color.Gray;
            this.lblMonApplication.Location = new System.Drawing.Point(20, 511);
            this.lblMonApplication.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
            this.lblMonApplication.Name = "lblMonApplication";
            this.lblMonApplication.Size = new System.Drawing.Size(1210, 25);
            this.lblMonApplication.TabIndex = 24;
            this.lblMonApplication.Text = "Crédits";
            this.lblMonApplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbMethodePaiement
            // 
            this.gpbMethodePaiement.Controls.Add(this.rdbEspece);
            this.gpbMethodePaiement.Controls.Add(this.rdbCheque);
            this.gpbMethodePaiement.Controls.Add(this.rdbCB);
            this.gpbMethodePaiement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMethodePaiement.ForeColor = System.Drawing.Color.DarkBlue;
            this.gpbMethodePaiement.Location = new System.Drawing.Point(904, 142);
            this.gpbMethodePaiement.Name = "gpbMethodePaiement";
            this.gpbMethodePaiement.Size = new System.Drawing.Size(310, 154);
            this.gpbMethodePaiement.TabIndex = 25;
            this.gpbMethodePaiement.TabStop = false;
            this.gpbMethodePaiement.Text = "Méthode de paiement";
            // 
            // rdbEspece
            // 
            this.rdbEspece.AutoSize = true;
            this.rdbEspece.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEspece.Location = new System.Drawing.Point(14, 116);
            this.rdbEspece.Margin = new System.Windows.Forms.Padding(4);
            this.rdbEspece.Name = "rdbEspece";
            this.rdbEspece.Size = new System.Drawing.Size(83, 27);
            this.rdbEspece.TabIndex = 3;
            this.rdbEspece.Text = "Espèce";
            this.rdbEspece.UseVisualStyleBackColor = true;
            // 
            // rdbCheque
            // 
            this.rdbCheque.AutoSize = true;
            this.rdbCheque.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCheque.Location = new System.Drawing.Point(14, 81);
            this.rdbCheque.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCheque.Name = "rdbCheque";
            this.rdbCheque.Size = new System.Drawing.Size(90, 27);
            this.rdbCheque.TabIndex = 2;
            this.rdbCheque.Text = "Chèque";
            this.rdbCheque.UseVisualStyleBackColor = true;
            // 
            // rdbCB
            // 
            this.rdbCB.AutoSize = true;
            this.rdbCB.Checked = true;
            this.rdbCB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCB.Location = new System.Drawing.Point(14, 46);
            this.rdbCB.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCB.Name = "rdbCB";
            this.rdbCB.Size = new System.Drawing.Size(142, 27);
            this.rdbCB.TabIndex = 0;
            this.rdbCB.TabStop = true;
            this.rdbCB.Text = "Carte Bancaire";
            this.rdbCB.UseVisualStyleBackColor = true;
            // 
            // lblPrixVoiture
            // 
            this.lblPrixVoiture.AutoSize = true;
            this.lblPrixVoiture.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixVoiture.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPrixVoiture.Location = new System.Drawing.Point(904, 372);
            this.lblPrixVoiture.Name = "lblPrixVoiture";
            this.lblPrixVoiture.Size = new System.Drawing.Size(71, 23);
            this.lblPrixVoiture.TabIndex = 30;
            this.lblPrixVoiture.Text = "Prix : X€";
            // 
            // lblFicheTechniqueVoit
            // 
            this.lblFicheTechniqueVoit.AutoSize = true;
            this.lblFicheTechniqueVoit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFicheTechniqueVoit.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFicheTechniqueVoit.Location = new System.Drawing.Point(6, 76);
            this.lblFicheTechniqueVoit.Name = "lblFicheTechniqueVoit";
            this.lblFicheTechniqueVoit.Size = new System.Drawing.Size(139, 23);
            this.lblFicheTechniqueVoit.TabIndex = 29;
            this.lblFicheTechniqueVoit.Text = "Fiche technique :";
            // 
            // lstDetailsVoiture
            // 
            this.lstDetailsVoiture.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDetailsVoiture.FormattingEnabled = true;
            this.lstDetailsVoiture.ItemHeight = 23;
            this.lstDetailsVoiture.Location = new System.Drawing.Point(144, 76);
            this.lstDetailsVoiture.Name = "lstDetailsVoiture";
            this.lstDetailsVoiture.Size = new System.Drawing.Size(410, 234);
            this.lstDetailsVoiture.TabIndex = 28;
            // 
            // lblVoitureChoisie
            // 
            this.lblVoitureChoisie.AutoSize = true;
            this.lblVoitureChoisie.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoitureChoisie.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblVoitureChoisie.Location = new System.Drawing.Point(6, 45);
            this.lblVoitureChoisie.Name = "lblVoitureChoisie";
            this.lblVoitureChoisie.Size = new System.Drawing.Size(131, 23);
            this.lblVoitureChoisie.TabIndex = 27;
            this.lblVoitureChoisie.Text = "Voiture choisie :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNouvVhc);
            this.groupBox1.Controls.Add(this.lblVoitureChoisie);
            this.groupBox1.Controls.Add(this.lstDetailsVoiture);
            this.groupBox1.Controls.Add(this.lblFicheTechniqueVoit);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(324, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 363);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvelle voiture";
            // 
            // txtNouvVhc
            // 
            this.txtNouvVhc.BackColor = System.Drawing.SystemColors.Window;
            this.txtNouvVhc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNouvVhc.Location = new System.Drawing.Point(144, 42);
            this.txtNouvVhc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNouvVhc.Name = "txtNouvVhc";
            this.txtNouvVhc.ReadOnly = true;
            this.txtNouvVhc.Size = new System.Drawing.Size(410, 30);
            this.txtNouvVhc.TabIndex = 28;
            // 
            // gpbAncVhc
            // 
            this.gpbAncVhc.Controls.Add(this.txtAncVhcKilometrage);
            this.gpbAncVhc.Controls.Add(this.lblAncVhcKilometrage);
            this.gpbAncVhc.Controls.Add(this.lblAncVhcPlaque);
            this.gpbAncVhc.Controls.Add(this.txtAncVhcPlaque);
            this.gpbAncVhc.Controls.Add(this.gpbAgeAncVhc);
            this.gpbAncVhc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAncVhc.ForeColor = System.Drawing.Color.DarkBlue;
            this.gpbAncVhc.Location = new System.Drawing.Point(41, 127);
            this.gpbAncVhc.Name = "gpbAncVhc";
            this.gpbAncVhc.Size = new System.Drawing.Size(277, 363);
            this.gpbAncVhc.TabIndex = 27;
            this.gpbAncVhc.TabStop = false;
            this.gpbAncVhc.Text = "Votre ancienne voiture";
            // 
            // txtAncVhcKilometrage
            // 
            this.txtAncVhcKilometrage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAncVhcKilometrage.Location = new System.Drawing.Point(11, 139);
            this.txtAncVhcKilometrage.Margin = new System.Windows.Forms.Padding(4);
            this.txtAncVhcKilometrage.Name = "txtAncVhcKilometrage";
            this.txtAncVhcKilometrage.ReadOnly = true;
            this.txtAncVhcKilometrage.Size = new System.Drawing.Size(259, 30);
            this.txtAncVhcKilometrage.TabIndex = 13;
            // 
            // lblAncVhcKilometrage
            // 
            this.lblAncVhcKilometrage.AutoSize = true;
            this.lblAncVhcKilometrage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAncVhcKilometrage.Location = new System.Drawing.Point(10, 112);
            this.lblAncVhcKilometrage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAncVhcKilometrage.Name = "lblAncVhcKilometrage";
            this.lblAncVhcKilometrage.Size = new System.Drawing.Size(102, 23);
            this.lblAncVhcKilometrage.TabIndex = 12;
            this.lblAncVhcKilometrage.Text = "Kilométrage";
            // 
            // lblAncVhcPlaque
            // 
            this.lblAncVhcPlaque.AutoSize = true;
            this.lblAncVhcPlaque.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAncVhcPlaque.Location = new System.Drawing.Point(10, 39);
            this.lblAncVhcPlaque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAncVhcPlaque.Name = "lblAncVhcPlaque";
            this.lblAncVhcPlaque.Size = new System.Drawing.Size(201, 23);
            this.lblAncVhcPlaque.TabIndex = 11;
            this.lblAncVhcPlaque.Text = "Plaque d\'immatriculation";
            // 
            // txtAncVhcPlaque
            // 
            this.txtAncVhcPlaque.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAncVhcPlaque.Location = new System.Drawing.Point(11, 66);
            this.txtAncVhcPlaque.Margin = new System.Windows.Forms.Padding(4);
            this.txtAncVhcPlaque.Name = "txtAncVhcPlaque";
            this.txtAncVhcPlaque.ReadOnly = true;
            this.txtAncVhcPlaque.Size = new System.Drawing.Size(259, 30);
            this.txtAncVhcPlaque.TabIndex = 8;
            // 
            // gpbAgeAncVhc
            // 
            this.gpbAgeAncVhc.Controls.Add(this.OCC5);
            this.gpbAgeAncVhc.Controls.Add(this.OCC35);
            this.gpbAgeAncVhc.Controls.Add(this.NF);
            this.gpbAgeAncVhc.Controls.Add(this.OCC3);
            this.gpbAgeAncVhc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAgeAncVhc.ForeColor = System.Drawing.Color.DarkBlue;
            this.gpbAgeAncVhc.Location = new System.Drawing.Point(14, 180);
            this.gpbAgeAncVhc.Margin = new System.Windows.Forms.Padding(4);
            this.gpbAgeAncVhc.Name = "gpbAgeAncVhc";
            this.gpbAgeAncVhc.Padding = new System.Windows.Forms.Padding(4);
            this.gpbAgeAncVhc.Size = new System.Drawing.Size(256, 167);
            this.gpbAgeAncVhc.TabIndex = 9;
            this.gpbAgeAncVhc.TabStop = false;
            this.gpbAgeAncVhc.Text = "Âge du vehicule";
            // 
            // OCC5
            // 
            this.OCC5.AutoSize = true;
            this.OCC5.Enabled = false;
            this.OCC5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OCC5.Location = new System.Drawing.Point(8, 131);
            this.OCC5.Margin = new System.Windows.Forms.Padding(4);
            this.OCC5.Name = "OCC5";
            this.OCC5.Size = new System.Drawing.Size(206, 27);
            this.OCC5.TabIndex = 3;
            this.OCC5.Text = "Occasion 5 ans ou plus";
            this.OCC5.UseVisualStyleBackColor = true;
            // 
            // OCC35
            // 
            this.OCC35.AutoSize = true;
            this.OCC35.Enabled = false;
            this.OCC35.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OCC35.Location = new System.Drawing.Point(7, 96);
            this.OCC35.Margin = new System.Windows.Forms.Padding(4);
            this.OCC35.Name = "OCC35";
            this.OCC35.Size = new System.Drawing.Size(197, 27);
            this.OCC35.TabIndex = 2;
            this.OCC35.Text = "Occasion de 3 à 5 ans";
            this.OCC35.UseVisualStyleBackColor = true;
            // 
            // NF
            // 
            this.NF.AutoSize = true;
            this.NF.Checked = true;
            this.NF.Enabled = false;
            this.NF.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NF.Location = new System.Drawing.Point(8, 26);
            this.NF.Margin = new System.Windows.Forms.Padding(4);
            this.NF.Name = "NF";
            this.NF.Size = new System.Drawing.Size(68, 27);
            this.NF.TabIndex = 0;
            this.NF.TabStop = true;
            this.NF.Text = "Neuf";
            this.NF.UseVisualStyleBackColor = true;
            // 
            // OCC3
            // 
            this.OCC3.AutoSize = true;
            this.OCC3.Enabled = false;
            this.OCC3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OCC3.Location = new System.Drawing.Point(8, 61);
            this.OCC3.Margin = new System.Windows.Forms.Padding(4);
            this.OCC3.Name = "OCC3";
            this.OCC3.Size = new System.Drawing.Size(181, 27);
            this.OCC3.TabIndex = 1;
            this.OCC3.Text = "Occasion - de 3 ans";
            this.OCC3.UseVisualStyleBackColor = true;
            // 
            // btnAcheter
            // 
            this.btnAcheter.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAcheter.FlatAppearance.BorderSize = 0;
            this.btnAcheter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcheter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcheter.ForeColor = System.Drawing.Color.White;
            this.btnAcheter.Location = new System.Drawing.Point(904, 403);
            this.btnAcheter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcheter.Name = "btnAcheter";
            this.btnAcheter.Size = new System.Drawing.Size(309, 85);
            this.btnAcheter.TabIndex = 31;
            this.btnAcheter.Text = "Payer";
            this.btnAcheter.UseVisualStyleBackColor = false;
            this.btnAcheter.Click += new System.EventHandler(this.btnAcheter_Click);
            // 
            // chkCredit
            // 
            this.chkCredit.AutoSize = true;
            this.chkCredit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCredit.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkCredit.Location = new System.Drawing.Point(904, 302);
            this.chkCredit.Name = "chkCredit";
            this.chkCredit.Size = new System.Drawing.Size(150, 27);
            this.chkCredit.TabIndex = 32;
            this.chkCredit.Text = "Je fais un crédit";
            this.chkCredit.UseVisualStyleBackColor = true;
            this.chkCredit.CheckedChanged += new System.EventHandler(this.chkCredit_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(900, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Durée (mois) :";
            // 
            // cboDureeMois
            // 
            this.cboDureeMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDureeMois.Enabled = false;
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
            this.cboDureeMois.Location = new System.Drawing.Point(1045, 332);
            this.cboDureeMois.Margin = new System.Windows.Forms.Padding(4);
            this.cboDureeMois.Name = "cboDureeMois";
            this.cboDureeMois.Size = new System.Drawing.Size(169, 31);
            this.cboDureeMois.TabIndex = 33;
            // 
            // frmAchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 556);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPrixVoiture);
            this.Controls.Add(this.cboDureeMois);
            this.Controls.Add(this.chkCredit);
            this.Controls.Add(this.btnAcheter);
            this.Controls.Add(this.gpbAncVhc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbMethodePaiement);
            this.Controls.Add(this.lblMonApplication);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAchat";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Achat - Crédit Céleste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAchat_FormClosing);
            this.Load += new System.EventHandler(this.frmAchat_Load);
            this.gpbMethodePaiement.ResumeLayout(false);
            this.gpbMethodePaiement.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbAncVhc.ResumeLayout(false);
            this.gpbAncVhc.PerformLayout();
            this.gpbAgeAncVhc.ResumeLayout(false);
            this.gpbAgeAncVhc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblMonApplication;
        private System.Windows.Forms.GroupBox gpbMethodePaiement;
        private System.Windows.Forms.RadioButton rdbEspece;
        private System.Windows.Forms.RadioButton rdbCheque;
        private System.Windows.Forms.RadioButton rdbCB;
        private System.Windows.Forms.Label lblPrixVoiture;
        private System.Windows.Forms.Label lblFicheTechniqueVoit;
        private System.Windows.Forms.ListBox lstDetailsVoiture;
        private System.Windows.Forms.Label lblVoitureChoisie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNouvVhc;
        private System.Windows.Forms.GroupBox gpbAncVhc;
        private System.Windows.Forms.TextBox txtAncVhcKilometrage;
        private System.Windows.Forms.Label lblAncVhcKilometrage;
        private System.Windows.Forms.Label lblAncVhcPlaque;
        private System.Windows.Forms.TextBox txtAncVhcPlaque;
        private System.Windows.Forms.GroupBox gpbAgeAncVhc;
        private System.Windows.Forms.RadioButton OCC5;
        private System.Windows.Forms.RadioButton OCC35;
        private System.Windows.Forms.RadioButton NF;
        private System.Windows.Forms.RadioButton OCC3;
        private System.Windows.Forms.Button btnAcheter;
        private System.Windows.Forms.CheckBox chkCredit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDureeMois;
    }
}