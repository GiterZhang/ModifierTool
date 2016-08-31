namespace ModifierTool
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moduleNameTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.processNameTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gameNameTxtbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteVersionBtn = new System.Windows.Forms.Button();
            this.updateVersionBtn = new System.Windows.Forms.Button();
            this.addVersionBtn = new System.Windows.Forms.Button();
            this.md5txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.versionCombox = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.FunctionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadOnly = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaxValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArraySize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueMap = new System.Windows.Forms.DataGridViewLinkColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建页面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.新建元素ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑元素ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除元素ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPannel = new System.Windows.Forms.TabControl();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.tabPannel.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.moduleNameTxtbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.processNameTxtbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gameNameTxtbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "程序信息";
            // 
            // moduleNameTxtbox
            // 
            this.moduleNameTxtbox.Location = new System.Drawing.Point(78, 90);
            this.moduleNameTxtbox.Name = "moduleNameTxtbox";
            this.moduleNameTxtbox.Size = new System.Drawing.Size(184, 21);
            this.moduleNameTxtbox.TabIndex = 5;
            this.moduleNameTxtbox.Text = "ModuleName";
            this.moduleNameTxtbox.TextChanged += new System.EventHandler(this.moduleNameTxtbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "模块名：";
            // 
            // processNameTxtbox
            // 
            this.processNameTxtbox.Location = new System.Drawing.Point(78, 54);
            this.processNameTxtbox.Name = "processNameTxtbox";
            this.processNameTxtbox.Size = new System.Drawing.Size(184, 21);
            this.processNameTxtbox.TabIndex = 3;
            this.processNameTxtbox.Text = "ProcessName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "进程名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "游戏名称：";
            // 
            // gameNameTxtbox
            // 
            this.gameNameTxtbox.Location = new System.Drawing.Point(78, 18);
            this.gameNameTxtbox.Name = "gameNameTxtbox";
            this.gameNameTxtbox.Size = new System.Drawing.Size(184, 21);
            this.gameNameTxtbox.TabIndex = 0;
            this.gameNameTxtbox.Text = "GameName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteVersionBtn);
            this.groupBox2.Controls.Add(this.updateVersionBtn);
            this.groupBox2.Controls.Add(this.addVersionBtn);
            this.groupBox2.Controls.Add(this.md5txtbox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.versionCombox);
            this.groupBox2.Location = new System.Drawing.Point(293, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 127);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "版本";
            // 
            // deleteVersionBtn
            // 
            this.deleteVersionBtn.Location = new System.Drawing.Point(336, 93);
            this.deleteVersionBtn.Name = "deleteVersionBtn";
            this.deleteVersionBtn.Size = new System.Drawing.Size(75, 21);
            this.deleteVersionBtn.TabIndex = 9;
            this.deleteVersionBtn.Text = "删除版本";
            this.deleteVersionBtn.UseVisualStyleBackColor = true;
            this.deleteVersionBtn.Click += new System.EventHandler(this.deleteVersionBtn_Click);
            // 
            // updateVersionBtn
            // 
            this.updateVersionBtn.Location = new System.Drawing.Point(336, 57);
            this.updateVersionBtn.Name = "updateVersionBtn";
            this.updateVersionBtn.Size = new System.Drawing.Size(75, 21);
            this.updateVersionBtn.TabIndex = 8;
            this.updateVersionBtn.Text = "修改信息";
            this.updateVersionBtn.UseVisualStyleBackColor = true;
            this.updateVersionBtn.Click += new System.EventHandler(this.updateVersionBtn_Click);
            // 
            // addVersionBtn
            // 
            this.addVersionBtn.Location = new System.Drawing.Point(336, 18);
            this.addVersionBtn.Name = "addVersionBtn";
            this.addVersionBtn.Size = new System.Drawing.Size(75, 21);
            this.addVersionBtn.TabIndex = 7;
            this.addVersionBtn.Text = "添加版本";
            this.addVersionBtn.UseVisualStyleBackColor = true;
            this.addVersionBtn.Click += new System.EventHandler(this.addVersionBtn_Click);
            // 
            // md5txtbox
            // 
            this.md5txtbox.Location = new System.Drawing.Point(75, 57);
            this.md5txtbox.Name = "md5txtbox";
            this.md5txtbox.ReadOnly = true;
            this.md5txtbox.Size = new System.Drawing.Size(247, 21);
            this.md5txtbox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "MD5：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "版本号：";
            // 
            // versionCombox
            // 
            this.versionCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionCombox.FormattingEnabled = true;
            this.versionCombox.Location = new System.Drawing.Point(75, 18);
            this.versionCombox.Name = "versionCombox";
            this.versionCombox.Size = new System.Drawing.Size(247, 20);
            this.versionCombox.TabIndex = 0;
            this.versionCombox.SelectedIndexChanged += new System.EventHandler(this.versionCombox_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(899, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "+";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToResizeColumns = false;
            this.gridView.AllowUserToResizeRows = false;
            this.gridView.BackgroundColor = System.Drawing.Color.White;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FunctionName,
            this.Address,
            this.ValueType,
            this.ReadOnly,
            this.MaxValue,
            this.MinValue,
            this.ArraySize,
            this.FormStyle,
            this.valueMap});
            this.gridView.ContextMenuStrip = this.contextMenu;
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(3, 3);
            this.gridView.Margin = new System.Windows.Forms.Padding(0);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.gridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridView.RowTemplate.Height = 23;
            this.gridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridView.Size = new System.Drawing.Size(893, 390);
            this.gridView.TabIndex = 0;
            this.gridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridView_CellMouseDown);
            this.gridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellValueChanged);
            // 
            // FunctionName
            // 
            this.FunctionName.HeaderText = "功能";
            this.FunctionName.Name = "FunctionName";
            this.FunctionName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FunctionName.Width = 150;
            // 
            // Address
            // 
            this.Address.HeaderText = "地址";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address.Width = 200;
            // 
            // ValueType
            // 
            this.ValueType.HeaderText = "值类型";
            this.ValueType.Name = "ValueType";
            this.ValueType.ReadOnly = true;
            this.ValueType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ValueType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ValueType.Width = 120;
            // 
            // ReadOnly
            // 
            this.ReadOnly.HeaderText = "只读";
            this.ReadOnly.Name = "ReadOnly";
            this.ReadOnly.Width = 50;
            // 
            // MaxValue
            // 
            this.MaxValue.HeaderText = "最大值";
            this.MaxValue.Name = "MaxValue";
            this.MaxValue.ReadOnly = true;
            this.MaxValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaxValue.Width = 80;
            // 
            // MinValue
            // 
            this.MinValue.HeaderText = "最小值";
            this.MinValue.Name = "MinValue";
            this.MinValue.ReadOnly = true;
            this.MinValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MinValue.Width = 80;
            // 
            // ArraySize
            // 
            this.ArraySize.HeaderText = "长度";
            this.ArraySize.Name = "ArraySize";
            this.ArraySize.ReadOnly = true;
            this.ArraySize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ArraySize.Width = 50;
            // 
            // FormStyle
            // 
            this.FormStyle.HeaderText = "控件格式";
            this.FormStyle.Name = "FormStyle";
            this.FormStyle.ReadOnly = true;
            this.FormStyle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FormStyle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FormStyle.Width = 80;
            // 
            // valueMap
            // 
            this.valueMap.HeaderText = "值串映射";
            this.valueMap.Name = "valueMap";
            this.valueMap.ReadOnly = true;
            this.valueMap.Width = 80;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建页面ToolStripMenuItem,
            this.重命名ToolStripMenuItem,
            this.刷新页ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.新建元素ToolStripMenuItem,
            this.编辑元素ToolStripMenuItem,
            this.删除元素ToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(125, 142);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // 新建页面ToolStripMenuItem
            // 
            this.新建页面ToolStripMenuItem.Name = "新建页面ToolStripMenuItem";
            this.新建页面ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新建页面ToolStripMenuItem.Text = "新建页面";
            this.新建页面ToolStripMenuItem.Click += new System.EventHandler(this.新建页面ToolStripMenuItem_Click);
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.重命名ToolStripMenuItem.Text = "重命名";
            this.重命名ToolStripMenuItem.Click += new System.EventHandler(this.重命名ToolStripMenuItem_Click);
            // 
            // 刷新页ToolStripMenuItem
            // 
            this.刷新页ToolStripMenuItem.Name = "刷新页ToolStripMenuItem";
            this.刷新页ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.刷新页ToolStripMenuItem.Text = "刷新页";
            this.刷新页ToolStripMenuItem.Click += new System.EventHandler(this.刷新页ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // 新建元素ToolStripMenuItem
            // 
            this.新建元素ToolStripMenuItem.Name = "新建元素ToolStripMenuItem";
            this.新建元素ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新建元素ToolStripMenuItem.Text = "新建元素";
            this.新建元素ToolStripMenuItem.Click += new System.EventHandler(this.新建元素ToolStripMenuItem_Click);
            // 
            // 编辑元素ToolStripMenuItem
            // 
            this.编辑元素ToolStripMenuItem.Name = "编辑元素ToolStripMenuItem";
            this.编辑元素ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.编辑元素ToolStripMenuItem.Text = "编辑元素";
            this.编辑元素ToolStripMenuItem.Click += new System.EventHandler(this.编辑元素ToolStripMenuItem_Click);
            // 
            // 删除元素ToolStripMenuItem
            // 
            this.删除元素ToolStripMenuItem.Name = "删除元素ToolStripMenuItem";
            this.删除元素ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除元素ToolStripMenuItem.Text = "删除元素";
            this.删除元素ToolStripMenuItem.Click += new System.EventHandler(this.删除元素ToolStripMenuItem_Click);
            // 
            // tabPannel
            // 
            this.tabPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPannel.Controls.Add(this.tabPage1);
            this.tabPannel.Location = new System.Drawing.Point(0, 169);
            this.tabPannel.Name = "tabPannel";
            this.tabPannel.SelectedIndex = 0;
            this.tabPannel.Size = new System.Drawing.Size(907, 422);
            this.tabPannel.TabIndex = 0;
            this.tabPannel.SelectedIndexChanged += new System.EventHandler(this.tabPannel_SelectedIndexChanged);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(907, 25);
            this.menu.TabIndex = 4;
            this.menu.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ModifierTool.Properties.Resources._2kLOGO;
            this.pictureBox1.Location = new System.Drawing.Point(727, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "3DM&NBA2K Game Modifier Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.tabPannel.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox moduleNameTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox processNameTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gameNameTxtbox;
        private System.Windows.Forms.TextBox md5txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox versionCombox;
        private System.Windows.Forms.Button updateVersionBtn;
        private System.Windows.Forms.Button addVersionBtn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.TabControl tabPannel;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem 新建页面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 新建元素ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑元素ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除元素ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReadOnly;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArraySize;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormStyle;
        private System.Windows.Forms.DataGridViewLinkColumn valueMap;
        private System.Windows.Forms.Button deleteVersionBtn;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

