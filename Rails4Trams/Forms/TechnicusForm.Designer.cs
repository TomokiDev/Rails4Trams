﻿namespace Rails4Trams
{
    partial class TechnicusForm
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
            this.lbKleineDienst = new System.Windows.Forms.ListBox();
            this.lbGroteDienst = new System.Windows.Forms.ListBox();
            this.btnKleineDienstAfronden = new System.Windows.Forms.Button();
            this.btnGroteDienstAfronden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnVeranderStatus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTerugTechForm = new System.Windows.Forms.Button();
            this.tbTijdsindicatie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbKleineDienst
            // 
            this.lbKleineDienst.FormattingEnabled = true;
            this.lbKleineDienst.ItemHeight = 16;
            this.lbKleineDienst.Location = new System.Drawing.Point(52, 78);
            this.lbKleineDienst.Name = "lbKleineDienst";
            this.lbKleineDienst.Size = new System.Drawing.Size(408, 244);
            this.lbKleineDienst.TabIndex = 0;
            // 
            // lbGroteDienst
            // 
            this.lbGroteDienst.FormattingEnabled = true;
            this.lbGroteDienst.ItemHeight = 16;
            this.lbGroteDienst.Location = new System.Drawing.Point(728, 78);
            this.lbGroteDienst.Name = "lbGroteDienst";
            this.lbGroteDienst.Size = new System.Drawing.Size(349, 244);
            this.lbGroteDienst.TabIndex = 1;
            // 
            // btnKleineDienstAfronden
            // 
            this.btnKleineDienstAfronden.Location = new System.Drawing.Point(183, 351);
            this.btnKleineDienstAfronden.Name = "btnKleineDienstAfronden";
            this.btnKleineDienstAfronden.Size = new System.Drawing.Size(104, 49);
            this.btnKleineDienstAfronden.TabIndex = 2;
            this.btnKleineDienstAfronden.Text = "Kleine dienst afronden";
            this.btnKleineDienstAfronden.UseVisualStyleBackColor = true;
            this.btnKleineDienstAfronden.Click += new System.EventHandler(this.btnKleineDienstAfronden_Click);
            // 
            // btnGroteDienstAfronden
            // 
            this.btnGroteDienstAfronden.Location = new System.Drawing.Point(848, 361);
            this.btnGroteDienstAfronden.Name = "btnGroteDienstAfronden";
            this.btnGroteDienstAfronden.Size = new System.Drawing.Size(119, 49);
            this.btnGroteDienstAfronden.TabIndex = 3;
            this.btnGroteDienstAfronden.Text = "Grote dienst afronden";
            this.btnGroteDienstAfronden.UseVisualStyleBackColor = true;
            this.btnGroteDienstAfronden.Click += new System.EventHandler(this.btnGroteDienstAfronden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kleine dienst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grote dienst";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1161, 28);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(91, 43);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Afmelden";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Defect",
            "Dienst",
            "Remise"});
            this.comboBox1.Location = new System.Drawing.Point(516, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // btnVeranderStatus
            // 
            this.btnVeranderStatus.Location = new System.Drawing.Point(539, 169);
            this.btnVeranderStatus.Name = "btnVeranderStatus";
            this.btnVeranderStatus.Size = new System.Drawing.Size(75, 49);
            this.btnVeranderStatus.TabIndex = 8;
            this.btnVeranderStatus.Text = "Verander status";
            this.btnVeranderStatus.UseVisualStyleBackColor = true;
            this.btnVeranderStatus.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status";
            // 
            // btnTerugTechForm
            // 
            this.btnTerugTechForm.Location = new System.Drawing.Point(1177, 477);
            this.btnTerugTechForm.Name = "btnTerugTechForm";
            this.btnTerugTechForm.Size = new System.Drawing.Size(75, 32);
            this.btnTerugTechForm.TabIndex = 10;
            this.btnTerugTechForm.Text = "Terug";
            this.btnTerugTechForm.UseVisualStyleBackColor = true;
            this.btnTerugTechForm.Visible = false;
            this.btnTerugTechForm.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbTijdsindicatie
            // 
            this.tbTijdsindicatie.Location = new System.Drawing.Point(530, 319);
            this.tbTijdsindicatie.Name = "tbTijdsindicatie";
            this.tbTijdsindicatie.Size = new System.Drawing.Size(100, 22);
            this.tbTijdsindicatie.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "duur reperatie in uur:";
            // 
            // TechnicusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 540);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTijdsindicatie);
            this.Controls.Add(this.btnTerugTechForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVeranderStatus);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGroteDienstAfronden);
            this.Controls.Add(this.btnKleineDienstAfronden);
            this.Controls.Add(this.lbGroteDienst);
            this.Controls.Add(this.lbKleineDienst);
            this.Name = "TechnicusForm";
            this.Text = "TechnicusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKleineDienst;
        private System.Windows.Forms.ListBox lbGroteDienst;
        private System.Windows.Forms.Button btnKleineDienstAfronden;
        private System.Windows.Forms.Button btnGroteDienstAfronden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnVeranderStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTerugTechForm;
        private System.Windows.Forms.TextBox tbTijdsindicatie;
        private System.Windows.Forms.Label label5;
    }
}