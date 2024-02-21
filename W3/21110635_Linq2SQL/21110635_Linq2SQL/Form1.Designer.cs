namespace _21110635_Linq2SQL
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLNVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.linq2SqlDataSet1 = new _21110635_Linq2SQL.Linq2SqlDataSet1();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txt_Dept = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_EmpID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qlyNVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linq2SqlDataSet = new _21110635_Linq2SQL.Linq2SqlDataSet();
            this.qLNVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNVienTableAdapter = new _21110635_Linq2SQL.Linq2SqlDataSetTableAdapters.QLNVienTableAdapter();
            this.qLNVienTableAdapter1 = new _21110635_Linq2SQL.Linq2SqlDataSet1TableAdapters.QLNVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linq2SqlDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlyNVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linq2SqlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Find:";
            // 
            // txt_Find
            // 
            this.txt_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Find.Location = new System.Drawing.Point(190, 412);
            this.txt_Find.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(264, 31);
            this.txt_Find.TabIndex = 19;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            this.txt_Find.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Find_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.deptDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.qLNVienBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(96, 517);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(575, 331);
            this.dataGridView1.TabIndex = 18;
            // 
            // emIDDataGridViewTextBoxColumn
            // 
            this.emIDDataGridViewTextBoxColumn.DataPropertyName = "emID";
            this.emIDDataGridViewTextBoxColumn.HeaderText = "emID";
            this.emIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emIDDataGridViewTextBoxColumn.Name = "emIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // deptDataGridViewTextBoxColumn
            // 
            this.deptDataGridViewTextBoxColumn.DataPropertyName = "Dept";
            this.deptDataGridViewTextBoxColumn.HeaderText = "Dept";
            this.deptDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deptDataGridViewTextBoxColumn.Name = "deptDataGridViewTextBoxColumn";
            // 
            // qLNVienBindingSource1
            // 
            this.qLNVienBindingSource1.DataMember = "QLNVien";
            this.qLNVienBindingSource1.DataSource = this.linq2SqlDataSet1;
            // 
            // linq2SqlDataSet1
            // 
            this.linq2SqlDataSet1.DataSetName = "Linq2SqlDataSet1";
            this.linq2SqlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(504, 344);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(124, 56);
            this.btn_Delete.TabIndex = 17;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(331, 344);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(124, 56);
            this.btn_Edit.TabIndex = 16;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Result:";
            // 
            // txt_Dept
            // 
            this.txt_Dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dept.Location = new System.Drawing.Point(148, 184);
            this.txt_Dept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Dept.Name = "txt_Dept";
            this.txt_Dept.Size = new System.Drawing.Size(426, 31);
            this.txt_Dept.TabIndex = 5;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(148, 115);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(426, 31);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_EmpID
            // 
            this.txt_EmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpID.Location = new System.Drawing.Point(148, 44);
            this.txt_EmpID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_EmpID.Name = "txt_EmpID";
            this.txt_EmpID.Size = new System.Drawing.Size(426, 31);
            this.txt_EmpID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dept:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp ID:";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(151, 344);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(124, 56);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Dept);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_EmpID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(96, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(611, 261);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infomation";
            // 
            // qlyNVienBindingSource
            // 
            this.qlyNVienBindingSource.DataMember = "qlyNVien";
            // 
            // linq2SqlDataSet
            // 
            this.linq2SqlDataSet.DataSetName = "Linq2SqlDataSet";
            this.linq2SqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNVienBindingSource
            // 
            this.qLNVienBindingSource.DataMember = "QLNVien";
            this.qLNVienBindingSource.DataSource = this.linq2SqlDataSet;
            // 
            // qLNVienTableAdapter
            // 
            this.qLNVienTableAdapter.ClearBeforeFill = true;
            // 
            // qLNVienTableAdapter1
            // 
            this.qLNVienTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 886);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Find);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "21110635_LinqToSql";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linq2SqlDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlyNVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linq2SqlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource qlyNVienBindingSource;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_Dept;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_EmpID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private Linq2SqlDataSet linq2SqlDataSet;
        private System.Windows.Forms.BindingSource qLNVienBindingSource;
        private Linq2SqlDataSetTableAdapters.QLNVienTableAdapter qLNVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn emIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptDataGridViewTextBoxColumn;
        private Linq2SqlDataSet1 linq2SqlDataSet1;
        private System.Windows.Forms.BindingSource qLNVienBindingSource1;
        private Linq2SqlDataSet1TableAdapters.QLNVienTableAdapter qLNVienTableAdapter1;
    }
}

