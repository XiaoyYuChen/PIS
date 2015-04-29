namespace PatSI
{
    partial class DBIN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupTmplate = new System.Windows.Forms.GroupBox();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnFileBrower = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.listOther = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.listQY = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listTime = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBase = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbZTList = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssProcess = new System.Windows.Forms.ToolStripProgressBar();
            this.tssMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCen = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.panTemplate = new System.Windows.Forms.Panel();
            this.dgwtemplate = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupTmplate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwtemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupTmplate
            // 
            this.groupTmplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTmplate.Controls.Add(this.txtTemplate);
            this.groupTmplate.Controls.Add(this.button1);
            this.groupTmplate.Location = new System.Drawing.Point(3, 140);
            this.groupTmplate.Name = "groupTmplate";
            this.groupTmplate.Size = new System.Drawing.Size(626, 64);
            this.groupTmplate.TabIndex = 36;
            this.groupTmplate.TabStop = false;
            this.groupTmplate.Text = "模板";
            // 
            // txtTemplate
            // 
            this.txtTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTemplate.Location = new System.Drawing.Point(49, 20);
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new System.Drawing.Size(489, 21);
            this.txtTemplate.TabIndex = 7;
            this.txtTemplate.Enter += new System.EventHandler(this.txtTemplate_Enter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(541, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtFileName);
            this.groupBox2.Controls.Add(this.btnFileBrower);
            this.groupBox2.Location = new System.Drawing.Point(3, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 64);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据源";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(49, 20);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(489, 21);
            this.txtFileName.TabIndex = 4;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // btnFileBrower
            // 
            this.btnFileBrower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileBrower.Location = new System.Drawing.Point(541, 19);
            this.btnFileBrower.Name = "btnFileBrower";
            this.btnFileBrower.Size = new System.Drawing.Size(75, 23);
            this.btnFileBrower.TabIndex = 5;
            this.btnFileBrower.Text = "浏览";
            this.btnFileBrower.UseVisualStyleBackColor = true;
            this.btnFileBrower.Click += new System.EventHandler(this.btnFileBrower_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.groupBox9);
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(3, 205);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(626, 249);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "自动标引";
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox9.Controls.Add(this.listOther);
            this.groupBox9.Location = new System.Drawing.Point(473, 22);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox9.Size = new System.Drawing.Size(142, 213);
            this.groupBox9.TabIndex = 41;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "其它信息";
            // 
            // listOther
            // 
            this.listOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOther.FormattingEnabled = true;
            this.listOther.ItemHeight = 12;
            this.listOther.Items.AddRange(new object[] {
            "第一申请人",
            "申请人类型",
            "第一发明人",
            "是否公知技术"});
            this.listOther.Location = new System.Drawing.Point(5, 19);
            this.listOther.Name = "listOther";
            this.listOther.Size = new System.Drawing.Size(132, 189);
            this.listOther.TabIndex = 11;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox8.Controls.Add(this.listQY);
            this.groupBox8.Location = new System.Drawing.Point(322, 22);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox8.Size = new System.Drawing.Size(142, 213);
            this.groupBox8.TabIndex = 40;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "区域信息";
            // 
            // listQY
            // 
            this.listQY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listQY.FormattingEnabled = true;
            this.listQY.ItemHeight = 12;
            this.listQY.Items.AddRange(new object[] {
            "洲际",
            "国家",
            "省",
            "省(合并计划单列市）",
            "市",
            "区县",
            "区域",
            "是否国外来华",
            "三国",
            "五国"});
            this.listQY.Location = new System.Drawing.Point(5, 19);
            this.listQY.Name = "listQY";
            this.listQY.Size = new System.Drawing.Size(132, 189);
            this.listQY.TabIndex = 10;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox7.Controls.Add(this.listTime);
            this.groupBox7.Location = new System.Drawing.Point(171, 22);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox7.Size = new System.Drawing.Size(142, 213);
            this.groupBox7.TabIndex = 39;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "时间信息";
            // 
            // listTime
            // 
            this.listTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTime.FormattingEnabled = true;
            this.listTime.ItemHeight = 12;
            this.listTime.Items.AddRange(new object[] {
            "申请年",
            "公开年",
            "授权年",
            "失效年",
            "最早优先权年",
            "公开年差",
            "授权年差",
            "专利年龄"});
            this.listTime.Location = new System.Drawing.Point(5, 19);
            this.listTime.Name = "listTime";
            this.listTime.Size = new System.Drawing.Size(132, 189);
            this.listTime.TabIndex = 9;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.listBase);
            this.groupBox6.Location = new System.Drawing.Point(20, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox6.Size = new System.Drawing.Size(142, 213);
            this.groupBox6.TabIndex = 38;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "基础标引";
            // 
            // listBase
            // 
            this.listBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBase.FormattingEnabled = true;
            this.listBase.ItemHeight = 12;
            this.listBase.Items.AddRange(new object[] {
            "专利类型",
            "专利类型(PCT)",
            "主权利要求字数",
            "发明人数量",
            "申请人数量",
            "同族数量",
            "国家数量",
            "申请国",
            "共开国"});
            this.listBase.Location = new System.Drawing.Point(5, 19);
            this.listBase.Name = "listBase";
            this.listBase.Size = new System.Drawing.Size(132, 189);
            this.listBase.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.cmbZTList);
            this.groupBox5.Location = new System.Drawing.Point(3, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(626, 63);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "专题库";
            // 
            // cmbZTList
            // 
            this.cmbZTList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbZTList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZTList.FormattingEnabled = true;
            this.cmbZTList.Location = new System.Drawing.Point(49, 22);
            this.cmbZTList.Name = "cmbZTList";
            this.cmbZTList.Size = new System.Drawing.Size(561, 20);
            this.cmbZTList.TabIndex = 0;
            this.cmbZTList.SelectedIndexChanged += new System.EventHandler(this.cmbZTList_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.toolStripStatusLabel1,
            this.StatusMsg,
            this.toolStripStatusLabel2,
            this.tssProcess,
            this.tssMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(634, 22);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.AutoSize = false;
            this.tssStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(67, 17);
            this.tssStatus.Text = "准备";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Enabled = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // StatusMsg
            // 
            this.StatusMsg.AutoSize = false;
            this.StatusMsg.Name = "StatusMsg";
            this.StatusMsg.Size = new System.Drawing.Size(100, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // tssProcess
            // 
            this.tssProcess.Name = "tssProcess";
            this.tssProcess.Size = new System.Drawing.Size(383, 16);
            // 
            // tssMsg
            // 
            this.tssMsg.AutoSize = false;
            this.tssMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tssMsg.Name = "tssMsg";
            this.tssMsg.Size = new System.Drawing.Size(45, 17);
            this.tssMsg.Text = "0%";
            // 
            // btnCen
            // 
            this.btnCen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCen.Enabled = false;
            this.btnCen.Location = new System.Drawing.Point(567, 464);
            this.btnCen.Name = "btnCen";
            this.btnCen.Size = new System.Drawing.Size(59, 23);
            this.btnCen.TabIndex = 13;
            this.btnCen.Text = "取消";
            this.btnCen.UseVisualStyleBackColor = true;
            this.btnCen.Click += new System.EventHandler(this.btnCen_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(502, 464);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(59, 23);
            this.btnImport.TabIndex = 39;
            this.btnImport.Text = "导入(&I)";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panTemplate
            // 
            this.panTemplate.Controls.Add(this.dgwtemplate);
            this.panTemplate.Location = new System.Drawing.Point(1, 900);
            this.panTemplate.Name = "panTemplate";
            this.panTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.panTemplate.Size = new System.Drawing.Size(492, 134);
            this.panTemplate.TabIndex = 42;
            // 
            // dgwtemplate
            // 
            this.dgwtemplate.AllowUserToAddRows = false;
            this.dgwtemplate.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwtemplate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgwtemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwtemplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.path,
            this.name,
            this.dbtype,
            this.filetype});
            this.dgwtemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwtemplate.Location = new System.Drawing.Point(3, 3);
            this.dgwtemplate.Name = "dgwtemplate";
            this.dgwtemplate.ReadOnly = true;
            this.dgwtemplate.RowHeadersVisible = false;
            this.dgwtemplate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwtemplate.RowTemplate.Height = 23;
            this.dgwtemplate.Size = new System.Drawing.Size(486, 128);
            this.dgwtemplate.TabIndex = 0;
            this.dgwtemplate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_template_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // path
            // 
            this.path.DataPropertyName = "path";
            this.path.HeaderText = "模板地址";
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "模板名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 285;
            // 
            // dbtype
            // 
            this.dbtype.DataPropertyName = "dbtype";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dbtype.DefaultCellStyle = dataGridViewCellStyle8;
            this.dbtype.HeaderText = "数据类型";
            this.dbtype.Name = "dbtype";
            this.dbtype.ReadOnly = true;
            // 
            // filetype
            // 
            this.filetype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filetype.DataPropertyName = "filetype";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.filetype.DefaultCellStyle = dataGridViewCellStyle9;
            this.filetype.HeaderText = "文件类型";
            this.filetype.Name = "filetype";
            this.filetype.ReadOnly = true;
            // 
            // DBIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 520);
            this.Controls.Add(this.panTemplate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnCen);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupTmplate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBIN";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据导入";
            this.groupTmplate.ResumeLayout(false);
            this.groupTmplate.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwtemplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTmplate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbZTList;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnFileBrower;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox9;        
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox listOther;
        private System.Windows.Forms.ListBox listQY;
        private System.Windows.Forms.ListBox listTime;
        private System.Windows.Forms.ListBox listBase;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssMsg;
        private System.Windows.Forms.ToolStripProgressBar tssProcess;
        private System.Windows.Forms.ToolStripStatusLabel StatusMsg;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.Button btnCen;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel panTemplate;
        private System.Windows.Forms.DataGridView dgwtemplate;
        private System.Windows.Forms.TextBox txtTemplate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn filetype;
    }
}