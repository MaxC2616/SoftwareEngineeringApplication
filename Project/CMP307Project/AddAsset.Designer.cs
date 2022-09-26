
namespace CMP307Project
{
    partial class AddAsset
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
            this.label1 = new System.Windows.Forms.Label();
            this.assetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.assetType = new System.Windows.Forms.TextBox();
            this.assetDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.assetModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.assetMFR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.assetMAC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.assetIP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.assetLocation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.assetWarranty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.assetMisc = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asset Name:";
            // 
            // assetName
            // 
            this.assetName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.assetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assetName.ForeColor = System.Drawing.Color.White;
            this.assetName.Location = new System.Drawing.Point(350, 126);
            this.assetName.MaxLength = 50;
            this.assetName.Name = "assetName";
            this.assetName.Size = new System.Drawing.Size(144, 26);
            this.assetName.TabIndex = 1;
            this.assetName.TextChanged += new System.EventHandler(this.assetName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asset Type:";
            // 
            // assetType
            // 
            this.assetType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.assetType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assetType.ForeColor = System.Drawing.Color.White;
            this.assetType.Location = new System.Drawing.Point(350, 186);
            this.assetType.MaxLength = 25;
            this.assetType.Name = "assetType";
            this.assetType.Size = new System.Drawing.Size(144, 26);
            this.assetType.TabIndex = 3;
            // 
            // assetDesc
            // 
            this.assetDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.assetDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assetDesc.ForeColor = System.Drawing.Color.White;
            this.assetDesc.Location = new System.Drawing.Point(350, 258);
            this.assetDesc.MaxLength = 100;
            this.assetDesc.Name = "assetDesc";
            this.assetDesc.Size = new System.Drawing.Size(365, 26);
            this.assetDesc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asset Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Asset Model:";
            // 
            // assetModel
            // 
            this.assetModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.assetModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assetModel.ForeColor = System.Drawing.Color.White;
            this.assetModel.Location = new System.Drawing.Point(350, 332);
            this.assetModel.MaxLength = 25;
            this.assetModel.Name = "assetModel";
            this.assetModel.Size = new System.Drawing.Size(152, 26);
            this.assetModel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(62, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Asset Manufacturer:";
            // 
            // assetMFR
            // 
            this.assetMFR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.assetMFR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assetMFR.ForeColor = System.Drawing.Color.White;
            this.assetMFR.Location = new System.Drawing.Point(350, 402);
            this.assetMFR.MaxLength = 50;
            this.assetMFR.Name = "assetMFR";
            this.assetMFR.Size = new System.Drawing.Size(152, 26);
            this.assetMFR.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(62, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Asset MAC:";
            // 
            // assetMAC
            // 
            this.assetMAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.assetMAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assetMAC.ForeColor = System.Drawing.Color.White;
            this.assetMAC.Location = new System.Drawing.Point(350, 462);
            this.assetMAC.MaxLength = 17;
            this.assetMAC.Name = "assetMAC";
            this.assetMAC.Size = new System.Drawing.Size(120, 26);
            this.assetMAC.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(62, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Asset IP:";
            // 
            // assetIP
            // 
            this.assetIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.assetIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assetIP.ForeColor = System.Drawing.Color.White;
            this.assetIP.Location = new System.Drawing.Point(350, 522);
            this.assetIP.MaxLength = 15;
            this.assetIP.Name = "assetIP";
            this.assetIP.Size = new System.Drawing.Size(110, 26);
            this.assetIP.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(62, 585);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "Asset Location:";
            // 
            // assetLocation
            // 
            this.assetLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.assetLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assetLocation.ForeColor = System.Drawing.Color.White;
            this.assetLocation.Location = new System.Drawing.Point(350, 585);
            this.assetLocation.MaxLength = 25;
            this.assetLocation.Name = "assetLocation";
            this.assetLocation.Size = new System.Drawing.Size(152, 26);
            this.assetLocation.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(62, 645);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 29);
            this.label10.TabIndex = 18;
            this.label10.Text = "Asset Purchase Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(62, 703);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 29);
            this.label11.TabIndex = 20;
            this.label11.Text = "Asset Warranty Info:";
            // 
            // assetWarranty
            // 
            this.assetWarranty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.assetWarranty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assetWarranty.ForeColor = System.Drawing.Color.White;
            this.assetWarranty.Location = new System.Drawing.Point(350, 706);
            this.assetWarranty.MaxLength = 75;
            this.assetWarranty.Name = "assetWarranty";
            this.assetWarranty.Size = new System.Drawing.Size(152, 26);
            this.assetWarranty.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(63, 758);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 29);
            this.label12.TabIndex = 22;
            this.label12.Text = "Asset Other Info:";
            // 
            // assetMisc
            // 
            this.assetMisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.assetMisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assetMisc.ForeColor = System.Drawing.Color.White;
            this.assetMisc.Location = new System.Drawing.Point(350, 762);
            this.assetMisc.MaxLength = 100;
            this.assetMisc.Name = "assetMisc";
            this.assetMisc.Size = new System.Drawing.Size(365, 26);
            this.assetMisc.TabIndex = 23;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.addButton.Location = new System.Drawing.Point(558, 835);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(156, 49);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "Add Asset";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(235)))));
            this.backButton.Location = new System.Drawing.Point(66, 835);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(140, 49);
            this.backButton.TabIndex = 25;
            this.backButton.Text = "Go back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 645);
            this.dateTimePicker1.MaxDate = new System.DateTime(2200, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1970, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 26);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 100);
            this.panel1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(292, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 46);
            this.label6.TabIndex = 0;
            this.label6.Text = "Add Hardware";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(544, 462);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(263, 25);
            this.label13.TabIndex = 28;
            this.label13.Text = "Example: XX:XX:XX:XX:XX";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(530, 522);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(282, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "Example: XXX.XXX.XXX.XXX";
            // 
            // AddAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(824, 909);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.assetMisc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.assetWarranty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.assetLocation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.assetIP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.assetMAC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.assetMFR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.assetModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.assetDesc);
            this.Controls.Add(this.assetType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.assetName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAsset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAsset";
            this.Load += new System.EventHandler(this.AddAsset_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox assetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox assetType;
        private System.Windows.Forms.TextBox assetDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox assetModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox assetMFR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox assetMAC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox assetIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox assetLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox assetWarranty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox assetMisc;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}