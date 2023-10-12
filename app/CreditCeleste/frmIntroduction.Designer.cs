
namespace CreditCeleste
{
    partial class frmIntroduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntroduction));
            this.cboIdt = new System.Windows.Forms.ComboBox();
            this.cboVendeur = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNouvVhc = new System.Windows.Forms.TextBox();
            this.txtAncVhcPlaque = new System.Windows.Forms.TextBox();
            this.gpbAgeAncVhc = new System.Windows.Forms.GroupBox();
            this.rdbOccasion5ouPlus = new System.Windows.Forms.RadioButton();
            this.rdbOccasion3a5 = new System.Windows.Forms.RadioButton();
            this.rdbNeuf = new System.Windows.Forms.RadioButton();
            this.rdbOccasionMoins3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbClient = new System.Windows.Forms.GroupBox();
            this.lblMonApplication = new System.Windows.Forms.Label();
            this.gpbAncVhc = new System.Windows.Forms.GroupBox();
            this.txtAncVhcKilometrage = new System.Windows.Forms.TextBox();
            this.lblAncVhcKilometrage = new System.Windows.Forms.Label();
            this.lblAncVhcPlaque = new System.Windows.Forms.Label();
            this.gpbNvVhc = new System.Windows.Forms.GroupBox();
            this.btnVoiture = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVendeur = new System.Windows.Forms.Label();
            this.btnCalculCredit = new System.Windows.Forms.Button();
            this.btnAcheter = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.gpbAgeAncVhc.SuspendLayout();
            this.gpbClient.SuspendLayout();
            this.gpbAncVhc.SuspendLayout();
            this.gpbNvVhc.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboIdt
            // 
            this.cboIdt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIdt.FormattingEnabled = true;
            this.cboIdt.Location = new System.Drawing.Point(110, 48);
            this.cboIdt.Margin = new System.Windows.Forms.Padding(4);
            this.cboIdt.Name = "cboIdt";
            this.cboIdt.Size = new System.Drawing.Size(200, 31);
            this.cboIdt.TabIndex = 3;
            // 
            // cboVendeur
            // 
            this.cboVendeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendeur.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVendeur.FormattingEnabled = true;
            this.cboVendeur.Location = new System.Drawing.Point(29, 66);
            this.cboVendeur.Margin = new System.Windows.Forms.Padding(4);
            this.cboVendeur.Name = "cboVendeur";
            this.cboVendeur.Size = new System.Drawing.Size(225, 31);
            this.cboVendeur.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(110, 87);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 30);
            this.txtNom.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(110, 130);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(200, 30);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNouvVhc
            // 
            this.txtNouvVhc.BackColor = System.Drawing.SystemColors.Window;
            this.txtNouvVhc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNouvVhc.Location = new System.Drawing.Point(29, 145);
            this.txtNouvVhc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNouvVhc.Name = "txtNouvVhc";
            this.txtNouvVhc.ReadOnly = true;
            this.txtNouvVhc.Size = new System.Drawing.Size(225, 30);
            this.txtNouvVhc.TabIndex = 7;
            this.txtNouvVhc.Text = "N/A";
            // 
            // txtAncVhcPlaque
            // 
            this.txtAncVhcPlaque.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAncVhcPlaque.Location = new System.Drawing.Point(22, 66);
            this.txtAncVhcPlaque.Margin = new System.Windows.Forms.Padding(4);
            this.txtAncVhcPlaque.Name = "txtAncVhcPlaque";
            this.txtAncVhcPlaque.Size = new System.Drawing.Size(235, 30);
            this.txtAncVhcPlaque.TabIndex = 8;
            // 
            // gpbAgeAncVhc
            // 
            this.gpbAgeAncVhc.Controls.Add(this.rdbOccasion5ouPlus);
            this.gpbAgeAncVhc.Controls.Add(this.rdbOccasion3a5);
            this.gpbAgeAncVhc.Controls.Add(this.rdbNeuf);
            this.gpbAgeAncVhc.Controls.Add(this.rdbOccasionMoins3);
            this.gpbAgeAncVhc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAgeAncVhc.ForeColor = System.Drawing.Color.DarkBlue;
            this.gpbAgeAncVhc.Location = new System.Drawing.Point(25, 180);
            this.gpbAgeAncVhc.Margin = new System.Windows.Forms.Padding(4);
            this.gpbAgeAncVhc.Name = "gpbAgeAncVhc";
            this.gpbAgeAncVhc.Padding = new System.Windows.Forms.Padding(4);
            this.gpbAgeAncVhc.Size = new System.Drawing.Size(232, 167);
            this.gpbAgeAncVhc.TabIndex = 9;
            this.gpbAgeAncVhc.TabStop = false;
            this.gpbAgeAncVhc.Text = "État du vehicule";
            // 
            // rdbOccasion5ouPlus
            // 
            this.rdbOccasion5ouPlus.AutoSize = true;
            this.rdbOccasion5ouPlus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOccasion5ouPlus.Location = new System.Drawing.Point(8, 131);
            this.rdbOccasion5ouPlus.Margin = new System.Windows.Forms.Padding(4);
            this.rdbOccasion5ouPlus.Name = "rdbOccasion5ouPlus";
            this.rdbOccasion5ouPlus.Size = new System.Drawing.Size(206, 27);
            this.rdbOccasion5ouPlus.TabIndex = 3;
            this.rdbOccasion5ouPlus.Text = "Occasion 5 ans ou plus";
            this.rdbOccasion5ouPlus.UseVisualStyleBackColor = true;
            // 
            // rdbOccasion3a5
            // 
            this.rdbOccasion3a5.AutoSize = true;
            this.rdbOccasion3a5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOccasion3a5.Location = new System.Drawing.Point(7, 96);
            this.rdbOccasion3a5.Margin = new System.Windows.Forms.Padding(4);
            this.rdbOccasion3a5.Name = "rdbOccasion3a5";
            this.rdbOccasion3a5.Size = new System.Drawing.Size(197, 27);
            this.rdbOccasion3a5.TabIndex = 2;
            this.rdbOccasion3a5.Text = "Occasion de 3 à 5 ans";
            this.rdbOccasion3a5.UseVisualStyleBackColor = true;
            // 
            // rdbNeuf
            // 
            this.rdbNeuf.AutoSize = true;
            this.rdbNeuf.Checked = true;
            this.rdbNeuf.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNeuf.Location = new System.Drawing.Point(8, 26);
            this.rdbNeuf.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNeuf.Name = "rdbNeuf";
            this.rdbNeuf.Size = new System.Drawing.Size(68, 27);
            this.rdbNeuf.TabIndex = 0;
            this.rdbNeuf.TabStop = true;
            this.rdbNeuf.Text = "Neuf";
            this.rdbNeuf.UseVisualStyleBackColor = true;
            // 
            // rdbOccasionMoins3
            // 
            this.rdbOccasionMoins3.AutoSize = true;
            this.rdbOccasionMoins3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOccasionMoins3.Location = new System.Drawing.Point(8, 61);
            this.rdbOccasionMoins3.Margin = new System.Windows.Forms.Padding(4);
            this.rdbOccasionMoins3.Name = "rdbOccasionMoins3";
            this.rdbOccasionMoins3.Size = new System.Drawing.Size(181, 27);
            this.rdbOccasionMoins3.TabIndex = 1;
            this.rdbOccasionMoins3.Text = "Occasion - de 3 ans";
            this.rdbOccasionMoins3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Civilité :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(23, 90);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(57, 23);
            this.lblNom.TabIndex = 11;
            this.lblNom.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prénom :";
            // 
            // gpbClient
            // 
            this.gpbClient.Controls.Add(this.lblNom);
            this.gpbClient.Controls.Add(this.txtNom);
            this.gpbClient.Controls.Add(this.txtPrenom);
            this.gpbClient.Controls.Add(this.label3);
            this.gpbClient.Controls.Add(this.label1);
            this.gpbClient.Controls.Add(this.cboIdt);
            this.gpbClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbClient.ForeColor = System.Drawing.Color.DarkBlue;
            this.gpbClient.Location = new System.Drawing.Point(23, 113);
            this.gpbClient.Name = "gpbClient";
            this.gpbClient.Size = new System.Drawing.Size(337, 186);
            this.gpbClient.TabIndex = 21;
            this.gpbClient.TabStop = false;
            this.gpbClient.Text = "Vos coordonnées";
            // 
            // lblMonApplication
            // 
            this.lblMonApplication.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMonApplication.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonApplication.ForeColor = System.Drawing.Color.Gray;
            this.lblMonApplication.Location = new System.Drawing.Point(20, 494);
            this.lblMonApplication.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
            this.lblMonApplication.Name = "lblMonApplication";
            this.lblMonApplication.Size = new System.Drawing.Size(912, 25);
            this.lblMonApplication.TabIndex = 22;
            this.lblMonApplication.Text = "Crédits";
            this.lblMonApplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.gpbAncVhc.Location = new System.Drawing.Point(366, 113);
            this.gpbAncVhc.Name = "gpbAncVhc";
            this.gpbAncVhc.Size = new System.Drawing.Size(277, 363);
            this.gpbAncVhc.TabIndex = 22;
            this.gpbAncVhc.TabStop = false;
            this.gpbAncVhc.Text = "Votre ancienne voiture";
            // 
            // txtAncVhcKilometrage
            // 
            this.txtAncVhcKilometrage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAncVhcKilometrage.Location = new System.Drawing.Point(22, 139);
            this.txtAncVhcKilometrage.Margin = new System.Windows.Forms.Padding(4);
            this.txtAncVhcKilometrage.Name = "txtAncVhcKilometrage";
            this.txtAncVhcKilometrage.Size = new System.Drawing.Size(235, 30);
            this.txtAncVhcKilometrage.TabIndex = 13;
            // 
            // lblAncVhcKilometrage
            // 
            this.lblAncVhcKilometrage.AutoSize = true;
            this.lblAncVhcKilometrage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAncVhcKilometrage.Location = new System.Drawing.Point(21, 112);
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
            this.lblAncVhcPlaque.Location = new System.Drawing.Point(21, 39);
            this.lblAncVhcPlaque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAncVhcPlaque.Name = "lblAncVhcPlaque";
            this.lblAncVhcPlaque.Size = new System.Drawing.Size(201, 23);
            this.lblAncVhcPlaque.TabIndex = 11;
            this.lblAncVhcPlaque.Text = "Plaque d\'immatriculation";
            // 
            // gpbNvVhc
            // 
            this.gpbNvVhc.Controls.Add(this.btnVoiture);
            this.gpbNvVhc.Controls.Add(this.label2);
            this.gpbNvVhc.Controls.Add(this.lblVendeur);
            this.gpbNvVhc.Controls.Add(this.cboVendeur);
            this.gpbNvVhc.Controls.Add(this.txtNouvVhc);
            this.gpbNvVhc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNvVhc.ForeColor = System.Drawing.Color.DarkBlue;
            this.gpbNvVhc.Location = new System.Drawing.Point(649, 113);
            this.gpbNvVhc.Name = "gpbNvVhc";
            this.gpbNvVhc.Size = new System.Drawing.Size(277, 363);
            this.gpbNvVhc.TabIndex = 24;
            this.gpbNvVhc.TabStop = false;
            this.gpbNvVhc.Text = "Votre nouvelle voiture";
            // 
            // btnVoiture
            // 
            this.btnVoiture.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVoiture.FlatAppearance.BorderSize = 0;
            this.btnVoiture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoiture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoiture.ForeColor = System.Drawing.Color.White;
            this.btnVoiture.Location = new System.Drawing.Point(29, 192);
            this.btnVoiture.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoiture.Name = "btnVoiture";
            this.btnVoiture.Size = new System.Drawing.Size(225, 155);
            this.btnVoiture.TabIndex = 27;
            this.btnVoiture.Text = "Choisir un véhicule";
            this.btnVoiture.UseVisualStyleBackColor = false;
            this.btnVoiture.Click += new System.EventHandler(this.btnVoiture_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Voiture choisie";
            // 
            // lblVendeur
            // 
            this.lblVendeur.AutoSize = true;
            this.lblVendeur.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendeur.Location = new System.Drawing.Point(25, 39);
            this.lblVendeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendeur.Name = "lblVendeur";
            this.lblVendeur.Size = new System.Drawing.Size(74, 23);
            this.lblVendeur.TabIndex = 11;
            this.lblVendeur.Text = "Vendeur";
            // 
            // btnCalculCredit
            // 
            this.btnCalculCredit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculCredit.FlatAppearance.BorderSize = 0;
            this.btnCalculCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculCredit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculCredit.ForeColor = System.Drawing.Color.White;
            this.btnCalculCredit.Location = new System.Drawing.Point(23, 319);
            this.btnCalculCredit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculCredit.Name = "btnCalculCredit";
            this.btnCalculCredit.Size = new System.Drawing.Size(336, 66);
            this.btnCalculCredit.TabIndex = 25;
            this.btnCalculCredit.Text = "Simuler un crédit";
            this.btnCalculCredit.UseVisualStyleBackColor = false;
            this.btnCalculCredit.Click += new System.EventHandler(this.btnCalculCredit_Click);
            // 
            // btnAcheter
            // 
            this.btnAcheter.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAcheter.FlatAppearance.BorderSize = 0;
            this.btnAcheter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcheter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcheter.ForeColor = System.Drawing.Color.White;
            this.btnAcheter.Location = new System.Drawing.Point(23, 404);
            this.btnAcheter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcheter.Name = "btnAcheter";
            this.btnAcheter.Size = new System.Drawing.Size(336, 72);
            this.btnAcheter.TabIndex = 26;
            this.btnAcheter.Text = "Acheter";
            this.btnAcheter.UseVisualStyleBackColor = false;
            this.btnAcheter.Click += new System.EventHandler(this.btnAcheter_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(912, 90);
            this.lblHeader.TabIndex = 20;
            this.lblHeader.Text = "Crédit Céleste\r\nAchat d\'une voiture";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmIntroduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 539);
            this.Controls.Add(this.btnAcheter);
            this.Controls.Add(this.btnCalculCredit);
            this.Controls.Add(this.gpbNvVhc);
            this.Controls.Add(this.gpbAncVhc);
            this.Controls.Add(this.lblMonApplication);
            this.Controls.Add(this.gpbClient);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIntroduction";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Achat - Crédit Céleste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIntroduction_FormClosing);
            this.Load += new System.EventHandler(this.frmIntroduction_Load);
            this.gpbAgeAncVhc.ResumeLayout(false);
            this.gpbAgeAncVhc.PerformLayout();
            this.gpbClient.ResumeLayout(false);
            this.gpbClient.PerformLayout();
            this.gpbAncVhc.ResumeLayout(false);
            this.gpbAncVhc.PerformLayout();
            this.gpbNvVhc.ResumeLayout(false);
            this.gpbNvVhc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboIdt;
        private System.Windows.Forms.ComboBox cboVendeur;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNouvVhc;
        private System.Windows.Forms.TextBox txtAncVhcPlaque;
        private System.Windows.Forms.GroupBox gpbAgeAncVhc;
        private System.Windows.Forms.RadioButton rdbOccasion5ouPlus;
        private System.Windows.Forms.RadioButton rdbOccasion3a5;
        private System.Windows.Forms.RadioButton rdbOccasionMoins3;
        private System.Windows.Forms.RadioButton rdbNeuf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbClient;
        private System.Windows.Forms.Label lblMonApplication;
        private System.Windows.Forms.GroupBox gpbAncVhc;
        private System.Windows.Forms.Label lblAncVhcPlaque;
        private System.Windows.Forms.GroupBox gpbNvVhc;
        private System.Windows.Forms.Label lblVendeur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAncVhcKilometrage;
        private System.Windows.Forms.TextBox txtAncVhcKilometrage;
        private System.Windows.Forms.Button btnCalculCredit;
        private System.Windows.Forms.Button btnVoiture;
        private System.Windows.Forms.Button btnAcheter;
        private System.Windows.Forms.Label lblHeader;
    }
}