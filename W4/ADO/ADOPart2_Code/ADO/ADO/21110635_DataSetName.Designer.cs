namespace ADO
{
    partial class _21110635_DataSetName
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
            this.buttonCount = new System.Windows.Forms.Button();
            this.button_DataSetName = new System.Windows.Forms.Button();
            this.buttonDataTable = new System.Windows.Forms.Button();
            this.buttonCase = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DataSetname: Employees";
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(603, 22);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(123, 43);
            this.buttonCount.TabIndex = 1;
            this.buttonCount.Text = "Count";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // button_DataSetName
            // 
            this.button_DataSetName.Location = new System.Drawing.Point(603, 95);
            this.button_DataSetName.Name = "button_DataSetName";
            this.button_DataSetName.Size = new System.Drawing.Size(123, 43);
            this.button_DataSetName.TabIndex = 1;
            this.button_DataSetName.Text = "DataSetName";
            this.button_DataSetName.UseVisualStyleBackColor = true;
            this.button_DataSetName.Click += new System.EventHandler(this.button_DataSetName_Click);
            // 
            // buttonDataTable
            // 
            this.buttonDataTable.Location = new System.Drawing.Point(603, 161);
            this.buttonDataTable.Name = "buttonDataTable";
            this.buttonDataTable.Size = new System.Drawing.Size(123, 43);
            this.buttonDataTable.TabIndex = 1;
            this.buttonDataTable.Text = "Data Table";
            this.buttonDataTable.UseVisualStyleBackColor = true;
            this.buttonDataTable.Click += new System.EventHandler(this.buttonDataTable_Click);
            // 
            // buttonCase
            // 
            this.buttonCase.Location = new System.Drawing.Point(603, 228);
            this.buttonCase.Name = "buttonCase";
            this.buttonCase.Size = new System.Drawing.Size(123, 43);
            this.buttonCase.TabIndex = 1;
            this.buttonCase.Text = "Case";
            this.buttonCase.UseVisualStyleBackColor = true;
            this.buttonCase.Click += new System.EventHandler(this.buttonCase_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(791, 342);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // _21110635_DataSetName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 672);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCase);
            this.Controls.Add(this.buttonDataTable);
            this.Controls.Add(this.button_DataSetName);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.label1);
            this.Name = "_21110635_DataSetName";
            this.Text = "_21110635_DataSet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button button_DataSetName;
        private System.Windows.Forms.Button buttonDataTable;
        private System.Windows.Forms.Button buttonCase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}