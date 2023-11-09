
namespace WinStudent
{
    partial class FrmClassList
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGrades = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDel = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(53, 53);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 34);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "新增班级";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbGrades);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(179, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(847, 70);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件:";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(564, 27);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(67, 29);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(327, 31);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 25);
            this.txtName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "名称:";
            // 
            // cbGrades
            // 
            this.cbGrades.FormattingEnabled = true;
            this.cbGrades.Location = new System.Drawing.Point(81, 32);
            this.cbGrades.Margin = new System.Windows.Forms.Padding(4);
            this.cbGrades.Name = "cbGrades";
            this.cbGrades.Size = new System.Drawing.Size(160, 23);
            this.cbGrades.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "年级:";
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClasses.ColumnHeadersHeight = 30;
            this.dgvClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassId,
            this.ClassName,
            this.GradeName,
            this.Remark,
            this.colEdit,
            this.colDel});
            this.dgvClasses.EnableHeadersVisualStyles = false;
            this.dgvClasses.Location = new System.Drawing.Point(19, 114);
            this.dgvClasses.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClasses.RowHeadersWidth = 51;
            this.dgvClasses.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvClasses.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvClasses.RowTemplate.Height = 30;
            this.dgvClasses.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(1007, 484);
            this.dgvClasses.TabIndex = 8;
            this.dgvClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellContentClick);
            // 
            // ClassId
            // 
            this.ClassId.DataPropertyName = "ClassId";
            this.ClassId.HeaderText = "班级编号";
            this.ClassId.MinimumWidth = 6;
            this.ClassId.Name = "ClassId";
            this.ClassId.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "班级名称";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // GradeName
            // 
            this.GradeName.DataPropertyName = "GradeName";
            this.GradeName.HeaderText = "年级名称";
            this.GradeName.MinimumWidth = 6;
            this.GradeName.Name = "GradeName";
            this.GradeName.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.FillWeight = 200F;
            this.Remark.HeaderText = "班级描述";
            this.Remark.MinimumWidth = 6;
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // colEdit
            // 
            dataGridViewCellStyle5.NullValue = "修改";
            this.colEdit.DefaultCellStyle = dataGridViewCellStyle5;
            this.colEdit.FillWeight = 50F;
            this.colEdit.HeaderText = "修改";
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            // 
            // colDel
            // 
            dataGridViewCellStyle6.NullValue = "删除";
            this.colDel.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDel.FillWeight = 50F;
            this.colDel.HeaderText = "删除";
            this.colDel.MinimumWidth = 6;
            this.colDel.Name = "colDel";
            // 
            // FrmClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 611);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvClasses);
            this.Name = "FrmClassList";
            this.Text = "班级列表";
            this.Load += new System.EventHandler(this.FrmClassList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGrades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewLinkColumn colEdit;
        private System.Windows.Forms.DataGridViewLinkColumn colDel;
    }
}