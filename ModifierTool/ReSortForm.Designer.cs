﻿namespace ModifierTool
{
    partial class ReSortItemsForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.raiseBtn = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 224);
            this.listBox1.TabIndex = 0;
            // 
            // raiseBtn
            // 
            this.raiseBtn.Location = new System.Drawing.Point(229, 12);
            this.raiseBtn.Name = "raiseBtn";
            this.raiseBtn.Size = new System.Drawing.Size(44, 31);
            this.raiseBtn.TabIndex = 2;
            this.raiseBtn.Text = "上升";
            this.raiseBtn.UseVisualStyleBackColor = true;
            this.raiseBtn.Click += new System.EventHandler(this.raiseBtn_Click);
            // 
            // downBtn
            // 
            this.downBtn.Location = new System.Drawing.Point(229, 49);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(44, 31);
            this.downBtn.TabIndex = 3;
            this.downBtn.Text = "下降";
            this.downBtn.UseVisualStyleBackColor = true;
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 253);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.raiseBtn);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReSortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "重排";
            this.Load += new System.EventHandler(this.ReSortPageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button raiseBtn;
        private System.Windows.Forms.Button downBtn;
        private System.Windows.Forms.Button button1;
    }
}