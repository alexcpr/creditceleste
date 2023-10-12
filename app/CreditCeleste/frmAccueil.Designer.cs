
namespace CreditCeleste
{
    partial class frmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.btnIntroduction = new System.Windows.Forms.Button();
            this.lblMonApplication = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIntroduction
            // 
            this.btnIntroduction.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIntroduction.FlatAppearance.BorderSize = 0;
            this.btnIntroduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntroduction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntroduction.ForeColor = System.Drawing.Color.White;
            this.btnIntroduction.Location = new System.Drawing.Point(28, 152);
            this.btnIntroduction.Margin = new System.Windows.Forms.Padding(4);
            this.btnIntroduction.Name = "btnIntroduction";
            this.btnIntroduction.Size = new System.Drawing.Size(386, 42);
            this.btnIntroduction.TabIndex = 0;
            this.btnIntroduction.Text = "Acheter une voiture";
            this.btnIntroduction.UseVisualStyleBackColor = false;
            this.btnIntroduction.Click += new System.EventHandler(this.btnIntroduction_Click);
            // 
            // lblMonApplication
            // 
            this.lblMonApplication.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMonApplication.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonApplication.ForeColor = System.Drawing.Color.Gray;
            this.lblMonApplication.Location = new System.Drawing.Point(20, 228);
            this.lblMonApplication.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
            this.lblMonApplication.Name = "lblMonApplication";
            this.lblMonApplication.Size = new System.Drawing.Size(398, 25);
            this.lblMonApplication.TabIndex = 3;
            this.lblMonApplication.Text = "Crédits";
            this.lblMonApplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(398, 90);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Crédit Céleste\r\nAccueil";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(438, 273);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblMonApplication);
            this.Controls.Add(this.btnIntroduction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccueil";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crédit Céleste";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIntroduction;
        private System.Windows.Forms.Label lblMonApplication;
        private System.Windows.Forms.Label lblHeader;
    }
}

