namespace ModifierTool
{
    partial class UpdateFunctionItemForm
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
            this.functionNameTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.readOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.maxValueTxtbox = new System.Windows.Forms.TextBox();
            this.minValueTxtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.formStyleCombox = new System.Windows.Forms.ComboBox();
            this.editAddressBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.arraySizeTxtbox = new System.Windows.Forms.TextBox();
            this.editMapBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.valueTypeCombox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.startPlaceCmbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // functionNameTxtbox
            // 
            this.functionNameTxtbox.Location = new System.Drawing.Point(94, 36);
            this.functionNameTxtbox.Name = "functionNameTxtbox";
            this.functionNameTxtbox.Size = new System.Drawing.Size(164, 21);
            this.functionNameTxtbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "功能：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "值类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "地址：";
            // 
            // addressTxtbox
            // 
            this.addressTxtbox.Location = new System.Drawing.Point(94, 97);
            this.addressTxtbox.Name = "addressTxtbox";
            this.addressTxtbox.ReadOnly = true;
            this.addressTxtbox.Size = new System.Drawing.Size(164, 21);
            this.addressTxtbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "只读：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "最大值：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "最小值：";
            // 
            // readOnlyCheckbox
            // 
            this.readOnlyCheckbox.AutoSize = true;
            this.readOnlyCheckbox.Location = new System.Drawing.Point(94, 136);
            this.readOnlyCheckbox.Name = "readOnlyCheckbox";
            this.readOnlyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.readOnlyCheckbox.TabIndex = 9;
            this.readOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // maxValueTxtbox
            // 
            this.maxValueTxtbox.Location = new System.Drawing.Point(94, 165);
            this.maxValueTxtbox.MaxLength = 10;
            this.maxValueTxtbox.Name = "maxValueTxtbox";
            this.maxValueTxtbox.Size = new System.Drawing.Size(164, 21);
            this.maxValueTxtbox.TabIndex = 10;
            // 
            // minValueTxtbox
            // 
            this.minValueTxtbox.Location = new System.Drawing.Point(94, 199);
            this.minValueTxtbox.MaxLength = 10;
            this.minValueTxtbox.Name = "minValueTxtbox";
            this.minValueTxtbox.Size = new System.Drawing.Size(164, 21);
            this.minValueTxtbox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "控件类型：";
            // 
            // formStyleCombox
            // 
            this.formStyleCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formStyleCombox.FormattingEnabled = true;
            this.formStyleCombox.Items.AddRange(new object[] {
            "单选框",
            "文本框",
            "下拉列表"});
            this.formStyleCombox.Location = new System.Drawing.Point(94, 236);
            this.formStyleCombox.Name = "formStyleCombox";
            this.formStyleCombox.Size = new System.Drawing.Size(164, 20);
            this.formStyleCombox.TabIndex = 13;
            this.formStyleCombox.SelectedIndexChanged += new System.EventHandler(this.formStyleCombox_SelectedIndexChanged);
            // 
            // editAddressBtn
            // 
            this.editAddressBtn.Location = new System.Drawing.Point(270, 95);
            this.editAddressBtn.Name = "editAddressBtn";
            this.editAddressBtn.Size = new System.Drawing.Size(61, 23);
            this.editAddressBtn.TabIndex = 14;
            this.editAddressBtn.Text = "编辑地址";
            this.editAddressBtn.UseVisualStyleBackColor = true;
            this.editAddressBtn.Click += new System.EventHandler(this.editAddressBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "数组长度：";
            // 
            // arraySizeTxtbox
            // 
            this.arraySizeTxtbox.Location = new System.Drawing.Point(210, 133);
            this.arraySizeTxtbox.MaxLength = 3;
            this.arraySizeTxtbox.Name = "arraySizeTxtbox";
            this.arraySizeTxtbox.Size = new System.Drawing.Size(48, 21);
            this.arraySizeTxtbox.TabIndex = 16;
            // 
            // editMapBtn
            // 
            this.editMapBtn.Enabled = false;
            this.editMapBtn.Location = new System.Drawing.Point(270, 235);
            this.editMapBtn.Name = "editMapBtn";
            this.editMapBtn.Size = new System.Drawing.Size(61, 23);
            this.editMapBtn.TabIndex = 17;
            this.editMapBtn.Text = "值串映射";
            this.editMapBtn.UseVisualStyleBackColor = true;
            this.editMapBtn.Click += new System.EventHandler(this.editMapBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(166, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "确定";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(256, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "取消";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // valueTypeCombox
            // 
            this.valueTypeCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valueTypeCombox.FormattingEnabled = true;
            this.valueTypeCombox.Items.AddRange(new object[] {
            "System.Binary",
            "System.Byte",
            "System.Int16",
            "System.Int32",
            "System.Single",
            "System.Double",
            "System.String"});
            this.valueTypeCombox.Location = new System.Drawing.Point(94, 66);
            this.valueTypeCombox.Name = "valueTypeCombox";
            this.valueTypeCombox.Size = new System.Drawing.Size(164, 20);
            this.valueTypeCombox.TabIndex = 20;
            this.valueTypeCombox.SelectedIndexChanged += new System.EventHandler(this.valueTypeCombox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "start:";
            // 
            // startPlaceCmbx
            // 
            this.startPlaceCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startPlaceCmbx.FormattingEnabled = true;
            this.startPlaceCmbx.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.startPlaceCmbx.Location = new System.Drawing.Point(300, 66);
            this.startPlaceCmbx.Name = "startPlaceCmbx";
            this.startPlaceCmbx.Size = new System.Drawing.Size(31, 20);
            this.startPlaceCmbx.TabIndex = 23;
            // 
            // UpdateFunctionItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 325);
            this.ControlBox = false;
            this.Controls.Add(this.startPlaceCmbx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.valueTypeCombox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.editMapBtn);
            this.Controls.Add(this.arraySizeTxtbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.editAddressBtn);
            this.Controls.Add(this.formStyleCombox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minValueTxtbox);
            this.Controls.Add(this.maxValueTxtbox);
            this.Controls.Add(this.readOnlyCheckbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.functionNameTxtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateFunctionItemForm";
            this.Text = "元素信息";
            this.Load += new System.EventHandler(this.UpdateFunctionItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox functionNameTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox readOnlyCheckbox;
        private System.Windows.Forms.TextBox maxValueTxtbox;
        private System.Windows.Forms.TextBox minValueTxtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox formStyleCombox;
        private System.Windows.Forms.Button editAddressBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox arraySizeTxtbox;
        private System.Windows.Forms.Button editMapBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox valueTypeCombox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox startPlaceCmbx;
    }
}