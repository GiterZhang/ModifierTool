using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModifierTool
{
    public partial class UpdateVersionForm : Form
    {
        private Version version;
        private Version version_temp;
        public Version Version
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
                version_temp = value;
                if (value != null)
                {                    
                    textBox1.Text = version.VersionName;
                    textBox2.Text = version.FileMd5;

                    textBox2.ReadOnly = true;
                    checkBox1.Visible = true;
                }
                else
                {
                    version_temp = new Version();
                }
            }
        }
        public UpdateVersionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                version_temp.VersionName = textBox1.Text;
                version_temp.FileMd5 = textBox2.Text;

                //如果是新建版本的话，添加一个默认页面
                if (version == null)
                {
                    version_temp.Pages = new List<FunctionPage>();
                    version_temp.Pages.Add(new FunctionPage { Name = "初始页面" });
                }
                
                version = version_temp;                
                Close();
            }
            else
            {
                MessageBox.Show("版本名和MD5不能为空");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateVersionForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (MessageBox.Show("MD5是版本匹配唯一凭证，修改MD5可能会造成版本重叠，请自行保证MD5不要有重叠，否则将导致无法输出文件，确定要修改吗？", "注意：", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    textBox2.ReadOnly = false;
                }
            }
            else
            {
                textBox2.ReadOnly = true;
            }           
        }
    }
    public static class UpdateVersionBox
    {
        private static UpdateVersionForm frm;
        public static Version UpdateVersion(Version version = null)
        {
            frm = new UpdateVersionForm();
            frm.Version = version;
            frm.ShowDialog();
            return frm.Version;
        }
    }
}
