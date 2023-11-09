
namespace WinStudent
{
    partial class FrmGradeList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGradeName = new System.Windows.Forms.TextBox();
            this.dgvGradeList = new System.Windows.Forms.DataGridView();
            this.colGradeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(50, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增年级";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(355, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(106, 33);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "添加";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtGradeName);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Location = new System.Drawing.Point(230, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 66);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "年级名称：";
            // 
            // txtGradeName
            // 
            this.txtGradeName.Location = new System.Drawing.Point(136, 19);
            this.txtGradeName.Name = "txtGradeName";
            this.txtGradeName.Size = new System.Drawing.Size(172, 25);
            this.txtGradeName.TabIndex = 1;
            // 
            // dgvGradeList
            // 
            this.dgvGradeList.AllowUserToAddRows = false;
            this.dgvGradeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGradeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGradeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGradeList.ColumnHeadersHeight = 35;
            this.dgvGradeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGradeId,
            this.colGradeName,
            this.colEdit,
            this.colDelete});
            this.dgvGradeList.EnableHeadersVisualStyles = false;
            this.dgvGradeList.Location = new System.Drawing.Point(2, 105);
            this.dgvGradeList.Name = "dgvGradeList";
            this.dgvGradeList.RowHeadersWidth = 51;
            this.dgvGradeList.RowTemplate.Height = 27;
            this.dgvGradeList.Size = new System.Drawing.Size(751, 430);
            this.dgvGradeList.TabIndex = 2;
            this.dgvGradeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGradeList_CellContentClick);
            // 
            // colGradeId
            // 
            this.colGradeId.DataPropertyName = "GradeId";
            this.colGradeId.HeaderText = "年级编号";
            this.colGradeId.MinimumWidth = 6;
            this.colGradeId.Name = "colGradeId";
            this.colGradeId.ReadOnly = true;
            // 
            // colGradeName
            // 
            this.colGradeName.DataPropertyName = "GradeName";
            this.colGradeName.HeaderText = "年级名称";
            this.colGradeName.MinimumWidth = 6;
            this.colGradeName.Name = "colGradeName";
            this.colGradeName.ReadOnly = true;
            // 
            // colEdit
            // 
            dataGridViewCellStyle2.NullValue = "修改";
            this.colEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.colEdit.FillWeight = 50F;
            this.colEdit.HeaderText = "修改";
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            // 
            // colDelete
            // 
            this.colDelete.FillWeight = 50F;
            this.colDelete.HeaderText = "删除";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "删除";
            this.colDelete.UseColumnTextForLinkValue = true;
            // 
            // FrmGradeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 547);
            this.Controls.Add(this.dgvGradeList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmGradeList";
            this.Text = "年级列表";
            this.Load += new System.EventHandler(this.FrmGradeList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGradeName;
        private System.Windows.Forms.DataGridView dgvGradeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGradeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGradeName;
        private System.Windows.Forms.DataGridViewLinkColumn colEdit;
        private System.Windows.Forms.DataGridViewLinkColumn colDelete;
    }
}