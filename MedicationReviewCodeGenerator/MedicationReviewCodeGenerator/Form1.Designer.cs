namespace MedicationReviewCodeGenerator
{
    partial class MedReview
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
            this.heritageDataSet = new MedicationReviewCodeGenerator.heritageDataSet();
            this.activworkTableAdapter = new MedicationReviewCodeGenerator.heritageDataSetTableAdapters.activworkTableAdapter();
            this.Submit = new System.Windows.Forms.Button();
            this.txtProgram = new System.Windows.Forms.ComboBox();
            this.txtPrescriber = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClientCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.heritageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // heritageDataSet
            // 
            this.heritageDataSet.DataSetName = "heritageDataSet";
            this.heritageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activworkTableAdapter
            // 
            this.activworkTableAdapter.ClearBeforeFill = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(59, 551);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Button6_Click);
            // 
            // txtProgram
            // 
            this.txtProgram.FormattingEnabled = true;
            this.txtProgram.Items.AddRange(new object[] {
            "020",
            "060",
            "710I",
            "710M",
            "710X",
            "700I",
            "700M",
            "700Z",
            "420",
            "60SM",
            "60SX",
            "60SZ",
            "60VM",
            "60VX",
            "60VZ",
            "60GM",
            "62GX",
            "62M",
            "62X",
            "66MG",
            "66MM",
            "66MX",
            "66MZ",
            "66SM",
            "66SX",
            "66SZ",
            "66VM",
            "66VX",
            "66VZ",
            "70D",
            "71D",
            "42D",
            "320",
            "110",
            "11MHB",
            "11MHC"});
            this.txtProgram.Location = new System.Drawing.Point(75, 9);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(199, 21);
            this.txtProgram.TabIndex = 8;
            this.txtProgram.SelectedIndexChanged += new System.EventHandler(this.TxtProgram_SelectedIndexChanged);
            // 
            // txtPrescriber
            // 
            this.txtPrescriber.FormattingEnabled = true;
            this.txtPrescriber.Items.AddRange(new object[] {
            "Patil",
            "Scribner",
            "Brandt",
            "Rade",
            "All"});
            this.txtPrescriber.Location = new System.Drawing.Point(75, 75);
            this.txtPrescriber.Name = "txtPrescriber";
            this.txtPrescriber.Size = new System.Drawing.Size(199, 21);
            this.txtPrescriber.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientCode,
            this.StaffCode,
            this.ProgramCode,
            this.ActivityDate});
            this.dataGridView1.Location = new System.Drawing.Point(310, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(492, 562);
            this.dataGridView1.TabIndex = 10;
            // 
            // ClientCode
            // 
            this.ClientCode.DataPropertyName = "clientcode_c";
            this.ClientCode.HeaderText = "Client Code";
            this.ClientCode.Name = "ClientCode";
            this.ClientCode.ReadOnly = true;
            // 
            // StaffCode
            // 
            this.StaffCode.DataPropertyName = "staffcode_c";
            this.StaffCode.HeaderText = "Staff Code";
            this.StaffCode.Name = "StaffCode";
            this.StaffCode.ReadOnly = true;
            // 
            // ProgramCode
            // 
            this.ProgramCode.DataPropertyName = "program_c";
            this.ProgramCode.HeaderText = "Program";
            this.ProgramCode.Name = "ProgramCode";
            this.ProgramCode.ReadOnly = true;
            // 
            // ActivityDate
            // 
            this.ActivityDate.DataPropertyName = "activitydate_d";
            this.ActivityDate.HeaderText = "Date";
            this.ActivityDate.Name = "ActivityDate";
            this.ActivityDate.ReadOnly = true;
            this.ActivityDate.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Program:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prescriber:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MedReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 586);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPrescriber);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.Submit);
            this.Name = "MedReview";
            this.Text = "Med Review Client Codes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.heritageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private heritageDataSet heritageDataSet;
        private heritageDataSetTableAdapters.activworkTableAdapter activworkTableAdapter;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ComboBox txtProgram;
        private System.Windows.Forms.ComboBox txtPrescriber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityDate;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
    }
}

