
namespace WinStudent
{
    partial class FrmStudentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDel = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(46, 43);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 29);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "新增学生";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbClasses);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(194, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(857, 79);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(674, 30);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 29);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(546, 27);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 34);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(368, 32);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 25);
            this.txtName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "姓名:";
            // 
            // cbClasses
            // 
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Location = new System.Drawing.Point(77, 34);
            this.cbClasses.Margin = new System.Windows.Forms.Padding(4);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(197, 23);
            this.cbClasses.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "班级:";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudents.ColumnHeadersHeight = 30;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.StuId,
            this.StuName,
            this.ClassName,
            this.Sex,
            this.Phone,
            this.colEdit,
            this.colDel});
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.Location = new System.Drawing.Point(13, 100);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowHeadersWidth = 30;
            this.dgvStudents.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvStudents.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dgvStudents.RowTemplate.Height = 30;
            this.dgvStudents.Size = new System.Drawing.Size(1056, 544);
            this.dgvStudents.TabIndex = 9;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // colChk
            // 
            this.colChk.HeaderText = "选择";
            this.colChk.MinimumWidth = 6;
            this.colChk.Name = "colChk";
            // 
            // StuId
            // 
            this.StuId.DataPropertyName = "StuId";
            this.StuId.HeaderText = "学生编号";
            this.StuId.MinimumWidth = 6;
            this.StuId.Name = "StuId";
            this.StuId.ReadOnly = true;
            // 
            // StuName
            // 
            this.StuName.DataPropertyName = "StuName";
            this.StuName.HeaderText = "学生姓名";
            this.StuName.MinimumWidth = 6;
            this.StuName.Name = "StuName";
            this.StuName.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "班级名称";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "性别";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "电话号码";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // colEdit
            // 
            dataGridViewCellStyle5.NullValue = "修改";
            this.colEdit.DefaultCellStyle = dataGridViewCellStyle5;
            this.colEdit.HeaderText = "修改";
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colDel
            // 
            dataGridViewCellStyle6.NullValue = "删除";
            this.colDel.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDel.HeaderText = "删除";
            this.colDel.MinimumWidth = 6;
            this.colDel.Name = "colDel";
            this.colDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 657);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStudents);
            this.Name = "FrmStudentList";
            this.Text = "学生列表";
            this.Load += new System.EventHandler(this.FrmStudentList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewLinkColumn colEdit;
        private System.Windows.Forms.DataGridViewLinkColumn colDel;
    }
}