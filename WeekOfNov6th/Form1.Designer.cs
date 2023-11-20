namespace WeekOfNov6th
{
    partial class Form1
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
            this.LBL1 = new System.Windows.Forms.Label();
            this.LBL2 = new System.Windows.Forms.Label();
            this.CTF = new System.Windows.Forms.RadioButton();
            this.FTC = new System.Windows.Forms.RadioButton();
            this.grpTempConverter = new System.Windows.Forms.GroupBox();
            this.MC1 = new System.Windows.Forms.ComboBox();
            this.BTN1 = new System.Windows.Forms.Button();
            this.RTB1 = new System.Windows.Forms.RichTextBox();
            this.BTN2 = new System.Windows.Forms.Button();
            this.TXT2 = new System.Windows.Forms.TextBox();
            this.TXT1 = new System.Windows.Forms.TextBox();
            this.LBL4 = new System.Windows.Forms.Label();
            this.LBL5 = new System.Windows.Forms.Label();
            this.LBL3 = new System.Windows.Forms.Label();
            this.MTI = new System.Windows.Forms.CheckBox();
            this.MTK = new System.Windows.Forms.CheckBox();
            this.BTN3 = new System.Windows.Forms.Button();
            this.ITM = new System.Windows.Forms.CheckBox();
            this.KTM = new System.Windows.Forms.CheckBox();
            this.BTN4 = new System.Windows.Forms.Button();
            this.BTN5 = new System.Windows.Forms.Button();
            this.BTN6 = new System.Windows.Forms.Button();
            this.grpTempConverter.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL1.Location = new System.Drawing.Point(42, 68);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(236, 26);
            this.LBL1.TabIndex = 0;
            this.LBL1.Text = "Temperature Converter";
            // 
            // LBL2
            // 
            this.LBL2.AutoSize = true;
            this.LBL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL2.Location = new System.Drawing.Point(42, 142);
            this.LBL2.Name = "LBL2";
            this.LBL2.Size = new System.Drawing.Size(178, 26);
            this.LBL2.TabIndex = 1;
            this.LBL2.Text = "Money Converter";
            // 
            // CTF
            // 
            this.CTF.AutoSize = true;
            this.CTF.Location = new System.Drawing.Point(18, 31);
            this.CTF.Name = "CTF";
            this.CTF.Size = new System.Drawing.Size(196, 28);
            this.CTF.TabIndex = 2;
            this.CTF.TabStop = true;
            this.CTF.Text = "Celsuis - Fahrenheit";
            this.CTF.UseVisualStyleBackColor = true;
            this.CTF.CheckedChanged += new System.EventHandler(this.CTF_CheckedChanged);
            // 
            // FTC
            // 
            this.FTC.AutoSize = true;
            this.FTC.Location = new System.Drawing.Point(234, 31);
            this.FTC.Name = "FTC";
            this.FTC.Size = new System.Drawing.Size(196, 28);
            this.FTC.TabIndex = 3;
            this.FTC.TabStop = true;
            this.FTC.Text = "Fahrenheit - Celsius";
            this.FTC.UseVisualStyleBackColor = true;
            this.FTC.CheckedChanged += new System.EventHandler(this.FTC_CheckedChanged);
            // 
            // grpTempConverter
            // 
            this.grpTempConverter.Controls.Add(this.CTF);
            this.grpTempConverter.Controls.Add(this.FTC);
            this.grpTempConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTempConverter.Location = new System.Drawing.Point(321, 38);
            this.grpTempConverter.Name = "grpTempConverter";
            this.grpTempConverter.Size = new System.Drawing.Size(458, 77);
            this.grpTempConverter.TabIndex = 4;
            this.grpTempConverter.TabStop = false;
            this.grpTempConverter.Tag = "";
            this.grpTempConverter.Text = "Convert";
            // 
            // MC1
            // 
            this.MC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC1.FormatString = "C2";
            this.MC1.FormattingEnabled = true;
            this.MC1.Items.AddRange(new object[] {
            "Yen to Dollar",
            "Dollar to Yen",
            "Dollars to Pound",
            "Pound to Dollar"});
            this.MC1.Location = new System.Drawing.Point(321, 142);
            this.MC1.Name = "MC1";
            this.MC1.Size = new System.Drawing.Size(136, 32);
            this.MC1.TabIndex = 5;
            this.MC1.Tag = "";
            // 
            // BTN1
            // 
            this.BTN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN1.Location = new System.Drawing.Point(846, 82);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(75, 33);
            this.BTN1.TabIndex = 6;
            this.BTN1.Text = "button1";
            this.BTN1.UseVisualStyleBackColor = true;
            this.BTN1.Click += new System.EventHandler(this.BTN1_Click);
            // 
            // RTB1
            // 
            this.RTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB1.Location = new System.Drawing.Point(47, 478);
            this.RTB1.Name = "RTB1";
            this.RTB1.ReadOnly = true;
            this.RTB1.Size = new System.Drawing.Size(964, 148);
            this.RTB1.TabIndex = 7;
            this.RTB1.Text = "";
            // 
            // BTN2
            // 
            this.BTN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN2.Location = new System.Drawing.Point(846, 136);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(75, 32);
            this.BTN2.TabIndex = 8;
            this.BTN2.Text = "button2";
            this.BTN2.UseVisualStyleBackColor = true;
            this.BTN2.Click += new System.EventHandler(this.BTN2_Click);
            // 
            // TXT2
            // 
            this.TXT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT2.Location = new System.Drawing.Point(321, 411);
            this.TXT2.Name = "TXT2";
            this.TXT2.Size = new System.Drawing.Size(169, 29);
            this.TXT2.TabIndex = 9;
            // 
            // TXT1
            // 
            this.TXT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT1.Location = new System.Drawing.Point(47, 411);
            this.TXT1.Name = "TXT1";
            this.TXT1.Size = new System.Drawing.Size(173, 29);
            this.TXT1.TabIndex = 10;
            // 
            // LBL4
            // 
            this.LBL4.AutoSize = true;
            this.LBL4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL4.Location = new System.Drawing.Point(43, 372);
            this.LBL4.Name = "LBL4";
            this.LBL4.Size = new System.Drawing.Size(61, 24);
            this.LBL4.TabIndex = 11;
            this.LBL4.Text = "Input1";
            // 
            // LBL5
            // 
            this.LBL5.AutoSize = true;
            this.LBL5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL5.Location = new System.Drawing.Point(317, 372);
            this.LBL5.Name = "LBL5";
            this.LBL5.Size = new System.Drawing.Size(61, 24);
            this.LBL5.TabIndex = 12;
            this.LBL5.Text = "Input2";
            // 
            // LBL3
            // 
            this.LBL3.AutoSize = true;
            this.LBL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL3.Location = new System.Drawing.Point(42, 243);
            this.LBL3.Name = "LBL3";
            this.LBL3.Size = new System.Drawing.Size(196, 25);
            this.LBL3.TabIndex = 13;
            this.LBL3.Tag = "";
            this.LBL3.Text = "Distance Converter";
            // 
            // MTI
            // 
            this.MTI.AutoSize = true;
            this.MTI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTI.Location = new System.Drawing.Point(321, 289);
            this.MTI.Name = "MTI";
            this.MTI.Size = new System.Drawing.Size(167, 28);
            this.MTI.TabIndex = 14;
            this.MTI.Text = "Meters to Inches";
            this.MTI.UseVisualStyleBackColor = true;
            this.MTI.CheckedChanged += new System.EventHandler(this.MTI_CheckedChanged);
            // 
            // MTK
            // 
            this.MTK.AutoSize = true;
            this.MTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTK.Location = new System.Drawing.Point(321, 240);
            this.MTK.Name = "MTK";
            this.MTK.Size = new System.Drawing.Size(186, 28);
            this.MTK.TabIndex = 15;
            this.MTK.Tag = "";
            this.MTK.Text = "Miles to Kilometers";
            this.MTK.UseVisualStyleBackColor = true;
            this.MTK.CheckedChanged += new System.EventHandler(this.MTK_CheckedChanged);
            // 
            // BTN3
            // 
            this.BTN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN3.Location = new System.Drawing.Point(846, 243);
            this.BTN3.Name = "BTN3";
            this.BTN3.Size = new System.Drawing.Size(75, 31);
            this.BTN3.TabIndex = 16;
            this.BTN3.Text = "button3";
            this.BTN3.UseVisualStyleBackColor = true;
            this.BTN3.Click += new System.EventHandler(this.BTN3_Click);
            // 
            // ITM
            // 
            this.ITM.AutoSize = true;
            this.ITM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITM.Location = new System.Drawing.Point(565, 290);
            this.ITM.Name = "ITM";
            this.ITM.Size = new System.Drawing.Size(167, 28);
            this.ITM.TabIndex = 17;
            this.ITM.Text = "Inches to Meters";
            this.ITM.UseVisualStyleBackColor = true;
            this.ITM.CheckedChanged += new System.EventHandler(this.ITM_CheckedChanged);
            // 
            // KTM
            // 
            this.KTM.AutoSize = true;
            this.KTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTM.Location = new System.Drawing.Point(565, 240);
            this.KTM.Name = "KTM";
            this.KTM.Size = new System.Drawing.Size(186, 28);
            this.KTM.TabIndex = 18;
            this.KTM.Text = "Kilometers to Miles";
            this.KTM.UseVisualStyleBackColor = true;
            this.KTM.CheckedChanged += new System.EventHandler(this.KTM_CheckedChanged);
            // 
            // BTN4
            // 
            this.BTN4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN4.Location = new System.Drawing.Point(846, 287);
            this.BTN4.Name = "BTN4";
            this.BTN4.Size = new System.Drawing.Size(75, 31);
            this.BTN4.TabIndex = 19;
            this.BTN4.Text = "button4";
            this.BTN4.UseVisualStyleBackColor = true;
            this.BTN4.Click += new System.EventHandler(this.BTN4_Click);
            // 
            // BTN5
            // 
            this.BTN5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN5.Location = new System.Drawing.Point(846, 409);
            this.BTN5.Name = "BTN5";
            this.BTN5.Size = new System.Drawing.Size(75, 31);
            this.BTN5.TabIndex = 20;
            this.BTN5.Text = "button5";
            this.BTN5.UseVisualStyleBackColor = true;
            this.BTN5.Click += new System.EventHandler(this.BTN5_click);
            // 
            // BTN6
            // 
            this.BTN6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN6.Location = new System.Drawing.Point(846, 348);
            this.BTN6.Name = "BTN6";
            this.BTN6.Size = new System.Drawing.Size(75, 31);
            this.BTN6.TabIndex = 21;
            this.BTN6.Text = "button5";
            this.BTN6.UseVisualStyleBackColor = true;
            this.BTN6.Click += new System.EventHandler(this.BTN6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 648);
            this.Controls.Add(this.BTN6);
            this.Controls.Add(this.BTN5);
            this.Controls.Add(this.MC1);
            this.Controls.Add(this.BTN4);
            this.Controls.Add(this.KTM);
            this.Controls.Add(this.ITM);
            this.Controls.Add(this.BTN3);
            this.Controls.Add(this.MTK);
            this.Controls.Add(this.MTI);
            this.Controls.Add(this.LBL3);
            this.Controls.Add(this.LBL5);
            this.Controls.Add(this.LBL4);
            this.Controls.Add(this.TXT1);
            this.Controls.Add(this.TXT2);
            this.Controls.Add(this.BTN2);
            this.Controls.Add(this.RTB1);
            this.Controls.Add(this.BTN1);
            this.Controls.Add(this.grpTempConverter);
            this.Controls.Add(this.LBL2);
            this.Controls.Add(this.LBL1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpTempConverter.ResumeLayout(false);
            this.grpTempConverter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.Label LBL2;
        private System.Windows.Forms.RadioButton CTF;
        private System.Windows.Forms.RadioButton FTC;
        private System.Windows.Forms.GroupBox grpTempConverter;
        private System.Windows.Forms.ComboBox MC1;
        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.RichTextBox RTB1;
        private System.Windows.Forms.Button BTN2;
        private System.Windows.Forms.TextBox TXT2;
        private System.Windows.Forms.TextBox TXT1;
        private System.Windows.Forms.Label LBL4;
        private System.Windows.Forms.Label LBL5;
        private System.Windows.Forms.Label LBL3;
        private System.Windows.Forms.CheckBox MTI;
        private System.Windows.Forms.CheckBox MTK;
        private System.Windows.Forms.Button BTN3;
        private System.Windows.Forms.CheckBox ITM;
        private System.Windows.Forms.CheckBox KTM;
        private System.Windows.Forms.Button BTN4;
        private System.Windows.Forms.Button BTN5;
        private System.Windows.Forms.Button BTN6;
    }
}

