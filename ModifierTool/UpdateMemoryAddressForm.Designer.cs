namespace ModifierTool
{
    partial class UpdateMemoryAddressForm
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
            this.addrTxtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.IsContain = new System.Windows.Forms.CheckBox();
            this.IsPtrCheckbox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.offsetsTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addrTxtbox
            // 
            this.addrTxtbox.Location = new System.Drawing.Point(108, 31);
            this.addrTxtbox.Name = "addrTxtbox";
            this.addrTxtbox.Size = new System.Drawing.Size(114, 21);
            this.addrTxtbox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IsContain
            // 
            this.IsContain.AutoSize = true;
            this.IsContain.Location = new System.Drawing.Point(12, 33);
            this.IsContain.Name = "IsContain";
            this.IsContain.Size = new System.Drawing.Size(90, 16);
            this.IsContain.TabIndex = 2;
            this.IsContain.Text = "模块地址  +";
            this.IsContain.UseVisualStyleBackColor = true;
            // 
            // IsPtrCheckbox
            // 
            this.IsPtrCheckbox.AutoSize = true;
            this.IsPtrCheckbox.Location = new System.Drawing.Point(12, 74);
            this.IsPtrCheckbox.Name = "IsPtrCheckbox";
            this.IsPtrCheckbox.Size = new System.Drawing.Size(48, 16);
            this.IsPtrCheckbox.TabIndex = 3;
            this.IsPtrCheckbox.Text = "指针";
            this.IsPtrCheckbox.UseVisualStyleBackColor = true;
            this.IsPtrCheckbox.CheckedChanged += new System.EventHandler(this.IsPtrCheckbox_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // offsetsTxtbox
            // 
            this.offsetsTxtbox.Enabled = false;
            this.offsetsTxtbox.Location = new System.Drawing.Point(12, 106);
            this.offsetsTxtbox.Multiline = true;
            this.offsetsTxtbox.Name = "offsetsTxtbox";
            this.offsetsTxtbox.Size = new System.Drawing.Size(210, 128);
            this.offsetsTxtbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "偏移地址";
            // 
            // UpdateMemoryAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 275);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.offsetsTxtbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.IsPtrCheckbox);
            this.Controls.Add(this.IsContain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addrTxtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateMemoryAddressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "地址信息";
            this.Load += new System.EventHandler(this.MemoryAdressForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addrTxtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox IsContain;
        private System.Windows.Forms.CheckBox IsPtrCheckbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox offsetsTxtbox;
        private System.Windows.Forms.Label label1;
    }
}