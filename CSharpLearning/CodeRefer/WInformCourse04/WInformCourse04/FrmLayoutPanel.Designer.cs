
namespace WInformCourse04
{
    partial class FrmLayoutPanel
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDel = new System.Windows.Forms.CheckBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvClasses = new System.Windows.Forms.TreeView();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colStuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colRecover = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRecover = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 83);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkDel);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.cboSex);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStuName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(127, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 63);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件：";
            // 
            // chkDel
            // 
            this.chkDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDel.AutoSize = true;
            this.chkDel.ForeColor = System.Drawing.Color.Red;
            this.chkDel.Location = new System.Drawing.Point(870, 22);
            this.chkDel.Name = "chkDel";
            this.chkDel.Size = new System.Drawing.Size(76, 23);
            this.chkDel.TabIndex = 10;
            this.chkDel.Text = "已删除";
            this.chkDel.UseVisualStyleBackColor = true;
            this.chkDel.CheckedChanged += new System.EventHandler(this.chkDel_CheckedChanged);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(699, 15);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(89, 31);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "全部",
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(574, 19);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(99, 27);
            this.cboSex.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(335, 18);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(136, 27);
            this.txtPhone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(514, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(245, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "电话号码：";
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(97, 17);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(121, 27);
            this.txtStuName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "班级列表：";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(6, 93);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvClasses);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvStudents);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1097, 560);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 1;
            // 
            // tvClasses
            // 
            this.tvClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvClasses.Location = new System.Drawing.Point(0, 0);
            this.tvClasses.Name = "tvClasses";
            this.tvClasses.Size = new System.Drawing.Size(237, 558);
            this.tvClasses.TabIndex = 0;
            this.tvClasses.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvClasses_AfterSelect);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvStudents.ColumnHeadersHeight = 29;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.colStuId,
            this.colStuName,
            this.colClassId,
            this.colSex,
            this.colPhone,
            this.colEdit,
            this.colDel,
            this.colRecover,
            this.colRemove});
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.Location = new System.Drawing.Point(0, 56);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvStudents.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvStudents.RowTemplate.Height = 27;
            this.dgvStudents.Size = new System.Drawing.Size(852, 502);
            this.dgvStudents.TabIndex = 7;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            this.dgvStudents.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellValueChanged);
            this.dgvStudents.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvStudents_CurrentCellDirtyStateChanged);
            // 
            // colCheck
            // 
            this.colCheck.FillWeight = 80F;
            this.colCheck.HeaderText = "选择";
            this.colCheck.MinimumWidth = 6;
            this.colCheck.Name = "colCheck";
            // 
            // colStuId
            // 
            this.colStuId.DataPropertyName = "StuId";
            this.colStuId.FillWeight = 60F;
            this.colStuId.HeaderText = "学号";
            this.colStuId.MinimumWidth = 6;
            this.colStuId.Name = "colStuId";
            // 
            // colStuName
            // 
            this.colStuName.DataPropertyName = "StuName";
            this.colStuName.HeaderText = "姓名";
            this.colStuName.MinimumWidth = 6;
            this.colStuName.Name = "colStuName";
            this.colStuName.ReadOnly = true;
            // 
            // colClassId
            // 
            this.colClassId.DataPropertyName = "ClassId";
            this.colClassId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colClassId.HeaderText = "班级";
            this.colClassId.MinimumWidth = 6;
            this.colClassId.Name = "colClassId";
            // 
            // colSex
            // 
            this.colSex.DataPropertyName = "Sex";
            this.colSex.FalseValue = "女";
            this.colSex.FillWeight = 60F;
            this.colSex.HeaderText = "性别";
            this.colSex.MinimumWidth = 6;
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            this.colSex.TrueValue = "男";
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "电话号码";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            // 
            // colEdit
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.colEdit.DefaultCellStyle = dataGridViewCellStyle26;
            this.colEdit.FillWeight = 60F;
            this.colEdit.HeaderText = "修改";
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "修改";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDel
            // 
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.colDel.DefaultCellStyle = dataGridViewCellStyle27;
            this.colDel.FillWeight = 60F;
            this.colDel.HeaderText = "删除";
            this.colDel.MinimumWidth = 6;
            this.colDel.Name = "colDel";
            this.colDel.Text = "删除";
            this.colDel.UseColumnTextForButtonValue = true;
            // 
            // colRecover
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colRecover.DefaultCellStyle = dataGridViewCellStyle28;
            this.colRecover.FillWeight = 60F;
            this.colRecover.HeaderText = "恢复";
            this.colRecover.MinimumWidth = 6;
            this.colRecover.Name = "colRecover";
            this.colRecover.Text = "恢复";
            this.colRecover.UseColumnTextForLinkValue = true;
            // 
            // colRemove
            // 
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colRemove.DefaultCellStyle = dataGridViewCellStyle29;
            this.colRemove.FillWeight = 60F;
            this.colRemove.HeaderText = "移除";
            this.colRemove.MinimumWidth = 6;
            this.colRemove.Name = "colRemove";
            this.colRemove.Text = "移除";
            this.colRemove.UseColumnTextForLinkValue = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnRecover);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.chkAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 56);
            this.panel2.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(780, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(62, 31);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "移除";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecover.BackColor = System.Drawing.Color.Blue;
            this.btnRecover.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnRecover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnRecover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecover.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecover.ForeColor = System.Drawing.Color.White;
            this.btnRecover.Location = new System.Drawing.Point(704, 12);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(62, 31);
            this.btnRecover.TabIndex = 10;
            this.btnRecover.Text = "恢复";
            this.btnRecover.UseVisualStyleBackColor = false;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(625, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 31);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(104, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 31);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(13, 19);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(59, 19);
            this.chkAll.TabIndex = 7;
            this.chkAll.Text = "全选";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // FrmLayoutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 658);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1126, 705);
            this.Name = "FrmLayoutPanel";
            this.Text = "布局控件";
            this.Load += new System.EventHandler(this.FrmLayoutPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDel;
        private System.Windows.Forms.TreeView tvClasses;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStuName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colClassId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
        private System.Windows.Forms.DataGridViewLinkColumn colRecover;
        private System.Windows.Forms.DataGridViewLinkColumn colRemove;
    }
}

