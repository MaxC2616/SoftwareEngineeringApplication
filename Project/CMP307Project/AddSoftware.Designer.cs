
namespace CMP307Project
{
    partial class AddSoftware
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
            this.backButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.softMisc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.softKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.softLicense = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.softDev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.softVersion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.softDesc = new System.Windows.Forms.TextBox();
            this.softType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.softName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(235)))));
            this.backButton.Location = new System.Drawing.Point(44, 543);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 32);
            this.backButton.TabIndex = 49;
            this.backButton.Text = "Go back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.addButton.Location = new System.Drawing.Point(372, 543);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 32);
            this.addButton.TabIndex = 48;
            this.addButton.Text = "Add Asset";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // softMisc
            // 
            this.softMisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.softMisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.softMisc.ForeColor = System.Drawing.Color.White;
            this.softMisc.Location = new System.Drawing.Point(233, 419);
            this.softMisc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.softMisc.MaxLength = 100;
            this.softMisc.Name = "softMisc";
            this.softMisc.Size = new System.Drawing.Size(107, 20);
            this.softMisc.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(41, 419);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Software Misc. Info:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(41, 380);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Software Purchase Date:";
            // 
            // softKey
            // 
            this.softKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.softKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.softKey.ForeColor = System.Drawing.Color.White;
            this.softKey.Location = new System.Drawing.Point(233, 339);
            this.softKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.softKey.MaxLength = 15;
            this.softKey.Name = "softKey";
            this.softKey.Size = new System.Drawing.Size(67, 20);
            this.softKey.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 339);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Software License Key:";
            // 
            // softLicense
            // 
            this.softLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.softLicense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.softLicense.ForeColor = System.Drawing.Color.White;
            this.softLicense.Location = new System.Drawing.Point(233, 300);
            this.softLicense.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.softLicense.MaxLength = 25;
            this.softLicense.Name = "softLicense";
            this.softLicense.Size = new System.Drawing.Size(67, 20);
            this.softLicense.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 300);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Software License:";
            // 
            // softDev
            // 
            this.softDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.softDev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.softDev.ForeColor = System.Drawing.Color.White;
            this.softDev.Location = new System.Drawing.Point(233, 261);
            this.softDev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.softDev.MaxLength = 50;
            this.softDev.Name = "softDev";
            this.softDev.Size = new System.Drawing.Size(100, 20);
            this.softDev.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Software Developer:";
            // 
            // softVersion
            // 
            this.softVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.softVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.softVersion.ForeColor = System.Drawing.Color.White;
            this.softVersion.Location = new System.Drawing.Point(233, 216);
            this.softVersion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.softVersion.MaxLength = 25;
            this.softVersion.Name = "softVersion";
            this.softVersion.Size = new System.Drawing.Size(67, 20);
            this.softVersion.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Software Version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Software Description:";
            // 
            // softDesc
            // 
            this.softDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.softDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.softDesc.ForeColor = System.Drawing.Color.White;
            this.softDesc.Location = new System.Drawing.Point(233, 168);
            this.softDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.softDesc.MaxLength = 100;
            this.softDesc.Name = "softDesc";
            this.softDesc.Size = new System.Drawing.Size(167, 20);
            this.softDesc.TabIndex = 30;
            // 
            // softType
            // 
            this.softType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.softType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.softType.ForeColor = System.Drawing.Color.White;
            this.softType.Location = new System.Drawing.Point(233, 121);
            this.softType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.softType.MaxLength = 25;
            this.softType.Name = "softType";
            this.softType.Size = new System.Drawing.Size(67, 20);
            this.softType.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Software Type:";
            // 
            // softName
            // 
            this.softName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.softName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.softName.ForeColor = System.Drawing.Color.White;
            this.softName.Location = new System.Drawing.Point(233, 82);
            this.softName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.softName.MaxLength = 50;
            this.softName.Name = "softName";
            this.softName.Size = new System.Drawing.Size(89, 20);
            this.softName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Software Name:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(251, 382);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 65);
            this.panel1.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(183, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 31);
            this.label6.TabIndex = 52;
            this.label6.Text = "Add Software";
            // 
            // AddSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(549, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.softMisc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.softKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.softLicense);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.softDev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.softVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.softDesc);
            this.Controls.Add(this.softType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.softName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddSoftware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSoftware";
            this.Load += new System.EventHandler(this.AddSoftware_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox softMisc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox softKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox softLicense;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox softDev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox softVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox softDesc;
        private System.Windows.Forms.TextBox softType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox softName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}