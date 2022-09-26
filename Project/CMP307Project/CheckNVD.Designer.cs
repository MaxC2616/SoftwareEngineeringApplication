
namespace CMP307Project
{
    partial class CheckNVD
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
            this.components = new System.ComponentModel.Container();
            this.backButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cVEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ourlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attackVectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attackComplexityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilegesRequiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userInteractionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confidentialityImpactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.integrityImpactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseSeverityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nVDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.assetText = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lowButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.highButton = new System.Windows.Forms.Button();
            this.criticalButton = new System.Windows.Forms.Button();
            this.resultsperpageTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(235)))));
            this.backButton.Location = new System.Drawing.Point(39, 718);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(158, 49);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Go back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.checkButton.Location = new System.Drawing.Point(1296, 635);
            this.checkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(296, 77);
            this.checkButton.TabIndex = 1;
            this.checkButton.Text = "Search NVD on current hardware";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cVEIDDataGridViewTextBoxColumn,
            this.problemvalueDataGridViewTextBoxColumn,
            this.ourlDataGridViewTextBoxColumn,
            this.descriptionvalueDataGridViewTextBoxColumn,
            this.attackVectorDataGridViewTextBoxColumn,
            this.attackComplexityDataGridViewTextBoxColumn,
            this.privilegesRequiredDataGridViewTextBoxColumn,
            this.userInteractionDataGridViewTextBoxColumn,
            this.confidentialityImpactDataGridViewTextBoxColumn,
            this.integrityImpactDataGridViewTextBoxColumn,
            this.baseScoreDataGridViewTextBoxColumn,
            this.baseSeverityDataGridViewTextBoxColumn,
            this.lastDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nVDBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(27, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(872, 363);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cVEIDDataGridViewTextBoxColumn
            // 
            this.cVEIDDataGridViewTextBoxColumn.DataPropertyName = "CVE_ID";
            this.cVEIDDataGridViewTextBoxColumn.HeaderText = "CVE_ID";
            this.cVEIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cVEIDDataGridViewTextBoxColumn.Name = "cVEIDDataGridViewTextBoxColumn";
            this.cVEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cVEIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // problemvalueDataGridViewTextBoxColumn
            // 
            this.problemvalueDataGridViewTextBoxColumn.DataPropertyName = "problem_value";
            this.problemvalueDataGridViewTextBoxColumn.HeaderText = "problem_value";
            this.problemvalueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.problemvalueDataGridViewTextBoxColumn.Name = "problemvalueDataGridViewTextBoxColumn";
            this.problemvalueDataGridViewTextBoxColumn.ReadOnly = true;
            this.problemvalueDataGridViewTextBoxColumn.Width = 150;
            // 
            // ourlDataGridViewTextBoxColumn
            // 
            this.ourlDataGridViewTextBoxColumn.DataPropertyName = "ourl";
            this.ourlDataGridViewTextBoxColumn.HeaderText = "ourl";
            this.ourlDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ourlDataGridViewTextBoxColumn.Name = "ourlDataGridViewTextBoxColumn";
            this.ourlDataGridViewTextBoxColumn.ReadOnly = true;
            this.ourlDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionvalueDataGridViewTextBoxColumn
            // 
            this.descriptionvalueDataGridViewTextBoxColumn.DataPropertyName = "description_value";
            this.descriptionvalueDataGridViewTextBoxColumn.HeaderText = "description_value";
            this.descriptionvalueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionvalueDataGridViewTextBoxColumn.Name = "descriptionvalueDataGridViewTextBoxColumn";
            this.descriptionvalueDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionvalueDataGridViewTextBoxColumn.Width = 150;
            // 
            // attackVectorDataGridViewTextBoxColumn
            // 
            this.attackVectorDataGridViewTextBoxColumn.DataPropertyName = "attackVector";
            this.attackVectorDataGridViewTextBoxColumn.HeaderText = "attackVector";
            this.attackVectorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.attackVectorDataGridViewTextBoxColumn.Name = "attackVectorDataGridViewTextBoxColumn";
            this.attackVectorDataGridViewTextBoxColumn.ReadOnly = true;
            this.attackVectorDataGridViewTextBoxColumn.Width = 150;
            // 
            // attackComplexityDataGridViewTextBoxColumn
            // 
            this.attackComplexityDataGridViewTextBoxColumn.DataPropertyName = "attackComplexity";
            this.attackComplexityDataGridViewTextBoxColumn.HeaderText = "attackComplexity";
            this.attackComplexityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.attackComplexityDataGridViewTextBoxColumn.Name = "attackComplexityDataGridViewTextBoxColumn";
            this.attackComplexityDataGridViewTextBoxColumn.ReadOnly = true;
            this.attackComplexityDataGridViewTextBoxColumn.Width = 150;
            // 
            // privilegesRequiredDataGridViewTextBoxColumn
            // 
            this.privilegesRequiredDataGridViewTextBoxColumn.DataPropertyName = "privilegesRequired";
            this.privilegesRequiredDataGridViewTextBoxColumn.HeaderText = "privilegesRequired";
            this.privilegesRequiredDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.privilegesRequiredDataGridViewTextBoxColumn.Name = "privilegesRequiredDataGridViewTextBoxColumn";
            this.privilegesRequiredDataGridViewTextBoxColumn.ReadOnly = true;
            this.privilegesRequiredDataGridViewTextBoxColumn.Width = 150;
            // 
            // userInteractionDataGridViewTextBoxColumn
            // 
            this.userInteractionDataGridViewTextBoxColumn.DataPropertyName = "userInteraction";
            this.userInteractionDataGridViewTextBoxColumn.HeaderText = "userInteraction";
            this.userInteractionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userInteractionDataGridViewTextBoxColumn.Name = "userInteractionDataGridViewTextBoxColumn";
            this.userInteractionDataGridViewTextBoxColumn.ReadOnly = true;
            this.userInteractionDataGridViewTextBoxColumn.Width = 150;
            // 
            // confidentialityImpactDataGridViewTextBoxColumn
            // 
            this.confidentialityImpactDataGridViewTextBoxColumn.DataPropertyName = "confidentialityImpact";
            this.confidentialityImpactDataGridViewTextBoxColumn.HeaderText = "confidentialityImpact";
            this.confidentialityImpactDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.confidentialityImpactDataGridViewTextBoxColumn.Name = "confidentialityImpactDataGridViewTextBoxColumn";
            this.confidentialityImpactDataGridViewTextBoxColumn.ReadOnly = true;
            this.confidentialityImpactDataGridViewTextBoxColumn.Width = 150;
            // 
            // integrityImpactDataGridViewTextBoxColumn
            // 
            this.integrityImpactDataGridViewTextBoxColumn.DataPropertyName = "integrityImpact";
            this.integrityImpactDataGridViewTextBoxColumn.HeaderText = "integrityImpact";
            this.integrityImpactDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.integrityImpactDataGridViewTextBoxColumn.Name = "integrityImpactDataGridViewTextBoxColumn";
            this.integrityImpactDataGridViewTextBoxColumn.ReadOnly = true;
            this.integrityImpactDataGridViewTextBoxColumn.Width = 150;
            // 
            // baseScoreDataGridViewTextBoxColumn
            // 
            this.baseScoreDataGridViewTextBoxColumn.DataPropertyName = "baseScore";
            this.baseScoreDataGridViewTextBoxColumn.HeaderText = "baseScore";
            this.baseScoreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.baseScoreDataGridViewTextBoxColumn.Name = "baseScoreDataGridViewTextBoxColumn";
            this.baseScoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.baseScoreDataGridViewTextBoxColumn.Width = 150;
            // 
            // baseSeverityDataGridViewTextBoxColumn
            // 
            this.baseSeverityDataGridViewTextBoxColumn.DataPropertyName = "baseSeverity";
            this.baseSeverityDataGridViewTextBoxColumn.HeaderText = "baseSeverity";
            this.baseSeverityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.baseSeverityDataGridViewTextBoxColumn.Name = "baseSeverityDataGridViewTextBoxColumn";
            this.baseSeverityDataGridViewTextBoxColumn.ReadOnly = true;
            this.baseSeverityDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastDateDataGridViewTextBoxColumn
            // 
            this.lastDateDataGridViewTextBoxColumn.DataPropertyName = "lastDate";
            this.lastDateDataGridViewTextBoxColumn.HeaderText = "lastDate";
            this.lastDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastDateDataGridViewTextBoxColumn.Name = "lastDateDataGridViewTextBoxColumn";
            this.lastDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // nVDBindingSource
            // 
            this.nVDBindingSource.DataSource = typeof(CMP307Project.NVD);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(22, 98);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(890, 375);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 575);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter by Asset Name (aname):";
            // 
            // assetText
            // 
            this.assetText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.assetText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assetText.ForeColor = System.Drawing.Color.White;
            this.assetText.Location = new System.Drawing.Point(39, 611);
            this.assetText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.assetText.Name = "assetText";
            this.assetText.Size = new System.Drawing.Size(218, 26);
            this.assetText.TabIndex = 5;
            this.assetText.TextChanged += new System.EventHandler(this.assetText_TextChanged);
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.copyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.copyButton.Location = new System.Drawing.Point(1628, 635);
            this.copyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(330, 77);
            this.copyButton.TabIndex = 6;
            this.copyButton.Text = "Copy vulnerability(s) to clipboard";
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(18, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 515);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(370, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hardware";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(1035, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 515);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(354, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vulnerabilities";
            // 
            // lowButton
            // 
            this.lowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.lowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(235)))));
            this.lowButton.Location = new System.Drawing.Point(576, 611);
            this.lowButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lowButton.Name = "lowButton";
            this.lowButton.Size = new System.Drawing.Size(122, 46);
            this.lowButton.TabIndex = 9;
            this.lowButton.Text = "Low";
            this.lowButton.UseVisualStyleBackColor = false;
            this.lowButton.Click += new System.EventHandler(this.lowButton_Click_1);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.mediumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(235)))));
            this.mediumButton.Location = new System.Drawing.Point(706, 611);
            this.mediumButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(134, 46);
            this.mediumButton.TabIndex = 10;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // highButton
            // 
            this.highButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.highButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(235)))));
            this.highButton.Location = new System.Drawing.Point(852, 611);
            this.highButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.highButton.Name = "highButton";
            this.highButton.Size = new System.Drawing.Size(124, 46);
            this.highButton.TabIndex = 11;
            this.highButton.Text = "High";
            this.highButton.UseVisualStyleBackColor = false;
            this.highButton.Click += new System.EventHandler(this.highButton_Click);
            // 
            // criticalButton
            // 
            this.criticalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.criticalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criticalButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(235)))));
            this.criticalButton.Location = new System.Drawing.Point(986, 611);
            this.criticalButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.criticalButton.Name = "criticalButton";
            this.criticalButton.Size = new System.Drawing.Size(129, 46);
            this.criticalButton.TabIndex = 12;
            this.criticalButton.Text = "Critical";
            this.criticalButton.UseVisualStyleBackColor = false;
            this.criticalButton.Click += new System.EventHandler(this.criticalButton_Click);
            // 
            // resultsperpageTextbox
            // 
            this.resultsperpageTextbox.Location = new System.Drawing.Point(576, 740);
            this.resultsperpageTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultsperpageTextbox.Name = "resultsperpageTextbox";
            this.resultsperpageTextbox.Size = new System.Drawing.Size(154, 26);
            this.resultsperpageTextbox.TabIndex = 13;
            this.resultsperpageTextbox.TextChanged += new System.EventHandler(this.resultsperpageTextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(570, 705);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(565, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Whats the max no. of results you want returned?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(741, 745);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "(Default is 20)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(570, 575);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(682, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Please select what level of severity you want to search for";
            // 
            // CheckNVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1988, 786);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultsperpageTextbox);
            this.Controls.Add(this.criticalButton);
            this.Controls.Add(this.highButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.lowButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.assetText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CheckNVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckNVD";
            this.Load += new System.EventHandler(this.CheckNVD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource nVDBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ourlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attackVectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attackComplexityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilegesRequiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userInteractionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confidentialityImpactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn integrityImpactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseSeverityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox assetText;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button lowButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button highButton;
        private System.Windows.Forms.Button criticalButton;
        private System.Windows.Forms.TextBox resultsperpageTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}