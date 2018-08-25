namespace StudentManager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboxStudentQuery = new System.Windows.Forms.GroupBox();
            this.txtQueryMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuerySName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuerySNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.SNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gboxStudentDetail = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.dtpBirthdy = new System.Windows.Forms.DateTimePicker();
            this.btnChoosePhoto = new System.Windows.Forms.Button();
            this.pbCurrentPhoto = new System.Windows.Forms.PictureBox();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSNO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gboxStudentQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.gboxStudentDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 688);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gboxStudentQuery
            // 
            this.gboxStudentQuery.Controls.Add(this.txtQueryMobile);
            this.gboxStudentQuery.Controls.Add(this.label3);
            this.gboxStudentQuery.Controls.Add(this.txtQuerySName);
            this.gboxStudentQuery.Controls.Add(this.label2);
            this.gboxStudentQuery.Controls.Add(this.txtQuerySNO);
            this.gboxStudentQuery.Controls.Add(this.label1);
            this.gboxStudentQuery.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxStudentQuery.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gboxStudentQuery.Location = new System.Drawing.Point(219, 48);
            this.gboxStudentQuery.Name = "gboxStudentQuery";
            this.gboxStudentQuery.Size = new System.Drawing.Size(1149, 117);
            this.gboxStudentQuery.TabIndex = 0;
            this.gboxStudentQuery.TabStop = false;
            this.gboxStudentQuery.Text = "学生信息查询：";
            // 
            // txtQueryMobile
            // 
            this.txtQueryMobile.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtQueryMobile.Font = new System.Drawing.Font("新宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtQueryMobile.ForeColor = System.Drawing.Color.Yellow;
            this.txtQueryMobile.Location = new System.Drawing.Point(851, 53);
            this.txtQueryMobile.Name = "txtQueryMobile";
            this.txtQueryMobile.Size = new System.Drawing.Size(196, 34);
            this.txtQueryMobile.TabIndex = 2;
            this.txtQueryMobile.TextChanged += new System.EventHandler(this.txtQueryMobile_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(694, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "电话号码：";
            // 
            // txtQuerySName
            // 
            this.txtQuerySName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtQuerySName.Font = new System.Drawing.Font("新宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtQuerySName.ForeColor = System.Drawing.Color.Yellow;
            this.txtQuerySName.Location = new System.Drawing.Point(510, 53);
            this.txtQuerySName.Name = "txtQuerySName";
            this.txtQuerySName.Size = new System.Drawing.Size(184, 34);
            this.txtQuerySName.TabIndex = 1;
            this.txtQuerySName.TextChanged += new System.EventHandler(this.txtQuerySName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(411, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名：";
            // 
            // txtQuerySNO
            // 
            this.txtQuerySNO.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtQuerySNO.Font = new System.Drawing.Font("新宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtQuerySNO.ForeColor = System.Drawing.Color.Yellow;
            this.txtQuerySNO.Location = new System.Drawing.Point(224, 53);
            this.txtQuerySNO.Name = "txtQuerySNO";
            this.txtQuerySNO.Size = new System.Drawing.Size(187, 34);
            this.txtQuerySNO.TabIndex = 0;
            this.txtQuerySNO.TextChanged += new System.EventHandler(this.txtQuerySNO_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(125, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AllowUserToResizeRows = false;
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNO,
            this.SName,
            this.Gender,
            this.Birthday,
            this.Mobile});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudent.EnableHeadersVisualStyles = false;
            this.dgvStudent.GridColor = System.Drawing.Color.White;
            this.dgvStudent.Location = new System.Drawing.Point(219, 177);
            this.dgvStudent.MultiSelect = false;
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvStudent.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudent.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStudent.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Teal;
            this.dgvStudent.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvStudent.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStudent.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.dgvStudent.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStudent.RowTemplate.Height = 27;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(1006, 330);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.SelectionChanged += new System.EventHandler(this.dgvStudent_SelectionChanged);
            this.dgvStudent.DoubleClick += new System.EventHandler(this.dgvStudent_DoubleClick);
            // 
            // SNO
            // 
            this.SNO.DataPropertyName = "SNO";
            this.SNO.HeaderText = "学号";
            this.SNO.Name = "SNO";
            this.SNO.ReadOnly = true;
            this.SNO.Width = 120;
            // 
            // SName
            // 
            this.SName.DataPropertyName = "SName";
            this.SName.HeaderText = "姓名";
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            this.SName.Width = 120;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 80;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "出生日期";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Width = 150;
            // 
            // Mobile
            // 
            this.Mobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "手机号码";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // btnImport
            // 
            this.btnImport.FlatAppearance.BorderSize = 2;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(1231, 200);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(137, 46);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "导入数据";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1231, 282);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 46);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1231, 364);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 46);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1231, 446);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 46);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gboxStudentDetail
            // 
            this.gboxStudentDetail.Controls.Add(this.rbFemale);
            this.gboxStudentDetail.Controls.Add(this.rbMale);
            this.gboxStudentDetail.Controls.Add(this.btnCancel);
            this.gboxStudentDetail.Controls.Add(this.btnCommit);
            this.gboxStudentDetail.Controls.Add(this.dtpBirthdy);
            this.gboxStudentDetail.Controls.Add(this.btnChoosePhoto);
            this.gboxStudentDetail.Controls.Add(this.pbCurrentPhoto);
            this.gboxStudentDetail.Controls.Add(this.txtHomeAddress);
            this.gboxStudentDetail.Controls.Add(this.txtEmail);
            this.gboxStudentDetail.Controls.Add(this.txtMobile);
            this.gboxStudentDetail.Controls.Add(this.label10);
            this.gboxStudentDetail.Controls.Add(this.label9);
            this.gboxStudentDetail.Controls.Add(this.txtSName);
            this.gboxStudentDetail.Controls.Add(this.label8);
            this.gboxStudentDetail.Controls.Add(this.label6);
            this.gboxStudentDetail.Controls.Add(this.label5);
            this.gboxStudentDetail.Controls.Add(this.txtSNO);
            this.gboxStudentDetail.Controls.Add(this.label7);
            this.gboxStudentDetail.Controls.Add(this.label4);
            this.gboxStudentDetail.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxStudentDetail.ForeColor = System.Drawing.Color.White;
            this.gboxStudentDetail.Location = new System.Drawing.Point(221, 520);
            this.gboxStudentDetail.Name = "gboxStudentDetail";
            this.gboxStudentDetail.Size = new System.Drawing.Size(1155, 179);
            this.gboxStudentDetail.TabIndex = 5;
            this.gboxStudentDetail.TabStop = false;
            this.gboxStudentDetail.Text = "学生信息明细：";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("新宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbFemale.ForeColor = System.Drawing.Color.Yellow;
            this.rbFemale.Location = new System.Drawing.Point(353, 75);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(56, 28);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "女";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("新宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbMale.ForeColor = System.Drawing.Color.Yellow;
            this.rbMale.Location = new System.Drawing.Point(283, 75);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(56, 28);
            this.rbMale.TabIndex = 3;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "男";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1010, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 46);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.FlatAppearance.BorderSize = 2;
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCommit.ForeColor = System.Drawing.Color.White;
            this.btnCommit.Location = new System.Drawing.Point(1010, 31);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(137, 46);
            this.btnCommit.TabIndex = 9;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // dtpBirthdy
            // 
            this.dtpBirthdy.CalendarForeColor = System.Drawing.Color.Yellow;
            this.dtpBirthdy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdy.Location = new System.Drawing.Point(803, 29);
            this.dtpBirthdy.Name = "dtpBirthdy";
            this.dtpBirthdy.Size = new System.Drawing.Size(153, 30);
            this.dtpBirthdy.TabIndex = 2;
            // 
            // btnChoosePhoto
            // 
            this.btnChoosePhoto.FlatAppearance.BorderSize = 2;
            this.btnChoosePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePhoto.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoosePhoto.ForeColor = System.Drawing.Color.White;
            this.btnChoosePhoto.Location = new System.Drawing.Point(46, 138);
            this.btnChoosePhoto.Name = "btnChoosePhoto";
            this.btnChoosePhoto.Size = new System.Drawing.Size(59, 33);
            this.btnChoosePhoto.TabIndex = 8;
            this.btnChoosePhoto.Text = "选择";
            this.btnChoosePhoto.UseVisualStyleBackColor = true;
            this.btnChoosePhoto.Click += new System.EventHandler(this.btnChoosePhoto_Click);
            // 
            // pbCurrentPhoto
            // 
            this.pbCurrentPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCurrentPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCurrentPhoto.Location = new System.Drawing.Point(15, 26);
            this.pbCurrentPhoto.Name = "pbCurrentPhoto";
            this.pbCurrentPhoto.Size = new System.Drawing.Size(127, 147);
            this.pbCurrentPhoto.TabIndex = 0;
            this.pbCurrentPhoto.TabStop = false;
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtHomeAddress.Font = new System.Drawing.Font("新宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtHomeAddress.ForeColor = System.Drawing.Color.Yellow;
            this.txtHomeAddress.Location = new System.Drawing.Point(309, 125);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(647, 34);
            this.txtHomeAddress.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtEmail.Font = new System.Drawing.Font("新宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.Yellow;
            this.txtEmail.Location = new System.Drawing.Point(752, 73);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 34);
            this.txtEmail.TabIndex = 6;
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtMobile.Font = new System.Drawing.Font("新宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtMobile.ForeColor = System.Drawing.Color.Yellow;
            this.txtMobile.Location = new System.Drawing.Point(501, 73);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(154, 34);
            this.txtMobile.TabIndex = 5;
            this.txtMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(184, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "家庭住址：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(681, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "邮箱：";
            // 
            // txtSName
            // 
            this.txtSName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtSName.Font = new System.Drawing.Font("新宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtSName.ForeColor = System.Drawing.Color.Yellow;
            this.txtSName.Location = new System.Drawing.Point(501, 28);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(154, 34);
            this.txtSName.TabIndex = 1;
            this.txtSName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(430, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "电话：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(680, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "出生日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(430, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "姓名：";
            // 
            // txtSNO
            // 
            this.txtSNO.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtSNO.Font = new System.Drawing.Font("新宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtSNO.ForeColor = System.Drawing.Color.Yellow;
            this.txtSNO.Location = new System.Drawing.Point(255, 28);
            this.txtSNO.Name = "txtSNO";
            this.txtSNO.Size = new System.Drawing.Size(154, 34);
            this.txtSNO.TabIndex = 0;
            this.txtSNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(184, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(184, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "学号：";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1303, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1388, 712);
            this.Controls.Add(this.gboxStudentDetail);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.gboxStudentQuery);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gboxStudentQuery.ResumeLayout(false);
            this.gboxStudentQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.gboxStudentDetail.ResumeLayout(false);
            this.gboxStudentDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gboxStudentQuery;
        private System.Windows.Forms.TextBox txtQueryMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuerySName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuerySNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gboxStudentDetail;
        private System.Windows.Forms.PictureBox pbCurrentPhoto;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.DateTimePicker dtpBirthdy;
        private System.Windows.Forms.Button btnChoosePhoto;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSNO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
    }
}

