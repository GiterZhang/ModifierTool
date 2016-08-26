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
    public partial class UpdateValueStringMapForm : Form
    {
        private ValueStringMap map;
        private ValueStringMap map_temp;
        public ValueStringMap Map
        {
            get
            {
                return map;
            }
            set
            {
                map = value;
                map_temp = value;
                if (value != null)
                {                   
                    textBox1.Text = map.ToString();
                }
                else
                {
                    map_temp = new ValueStringMap();
                }
            }
        }

        public UpdateValueStringMapForm()
        {
            InitializeComponent();
        }

        private void UpdateValueStringMapForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Submit(map_temp))
            {
                Close();
            }
                        
        }
        private bool Submit(ValueStringMap map)
        {
            if(map != null)
            {
                if (textBox1.Text != "")
                {
                    int index = 1;
                    map.ClearMap();//清空列表
                    foreach (var str in textBox1.Lines)
                    {
                        if (CheckStr(str))
                        {
                            var strs = str.Split(ValueStringMap.Separator.ToArray());
                            map.AddMap(strs[0], strs[2]);
                        }
                        else
                        {
                            MessageBox.Show("第" + index + "行格式不对(提示：123=>一二三)");
                            return false;
                        }                            
                        index++;
                    }
                    this.map = map;
                    return true;
                }
                else
                {
                    map = null;
                    return true;
                }
            }
            return false;
        }
        private bool CheckStr(string str)
        {
            var res = false;
            if (str != null)
            {
                try
                {
                    var strs = str.Split(ValueStringMap.Separator.ToCharArray());
                    if (strs.Length == 3)
                    {
                        int.Parse(strs[0]);

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
                
            }
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    public static class UpdateValueStringMapBox
    {
        private static UpdateValueStringMapForm frm;
        public static ValueStringMap UpdateValueStringMap(ValueStringMap map = null)
        {
            frm = new UpdateValueStringMapForm();
            frm.Map = map;
            frm.ShowDialog();
            return frm.Map;
        }
    }
}
