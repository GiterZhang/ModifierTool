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
    public partial class UpdateFunctionItemForm : Form
    {
        private FunctionItem item;//用来存放要处理的
        private FunctionItem item_temp;//用来操作的
        public FunctionItem Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
                item_temp = value;
                if (value != null)
                {
                    this.functionNameTxtbox.Text = item.Name;
                    this.addressTxtbox.Text = item.Address.GetAddrString();
                    this.startPlaceCmbx.Text = item.StartPlace.ToString();
                    this.readOnlyCheckbox.Checked = item.ReadOnly;
                    this.arraySizeTxtbox.Text = item.Size.ToString();

                    if (item.MaxValue != int.MaxValue)
                    {
                        this.maxValueTxtbox.Text = item.MaxValue.ToString();
                    }
                    if (item.MinValue != int.MinValue)
                    {
                        this.minValueTxtbox.Text = item.MinValue.ToString();
                    }

                    this.formStyleCombox.Text = item.FormStyle;
                    this.valueTypeCombox.Text = (item.ValueType == "System.Int64" ? "System.Binary" : item.ValueType);
                }
                else
                {
                    item_temp = new FunctionItem();
                }
            }
        }

        public UpdateFunctionItemForm()
        {
            InitializeComponent();
        }

        private void UpdateFunctionItemForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Submit(item_temp))
                Close();
        }
        private bool Check()
        {
            if (functionNameTxtbox.Text == "")
            {
                MessageBox.Show("功能名称不能为空");
                return false;
            }
            if (formStyleCombox.Text == "")
            {
                MessageBox.Show("未选择控件样式");
                return false;
            }
            if (valueTypeCombox.Text == "")
            {
                MessageBox.Show("未选择值类型");
                return false;
            }
            if (item_temp.Address == null)
            {
                MessageBox.Show("未设置地址");
                return false;
            }
            if (item_temp.ValueStringMap == null && formStyleCombox.Text == "下拉列表")
            {
                MessageBox.Show("未设置值映射关系");
                return false;
            }
            if (valueTypeCombox.Text == "System.Binary" && startPlaceCmbx.Text == "")
            {
                MessageBox.Show("未设置起始位置");
                return false;
            }
            if ((valueTypeCombox.Text == "System.String" || valueTypeCombox.Text == "System.Byte[]" || valueTypeCombox.Text == "System.Binary") && arraySizeTxtbox.Text == "")
            {
                MessageBox.Show("未设置长度");
                return false;
            }
            if (valueTypeCombox.Text == "System.Binary" && (formStyleCombox.Text == "单选框" && arraySizeTxtbox.Text != "1") || (formStyleCombox.Text != "单选框" && arraySizeTxtbox.Text == "1"))
            {
                MessageBox.Show("长度应为1或控件类型应为单选框");
                return false;
            }
            return true;
            
        }
        private bool Submit(FunctionItem item)
        {
            if (Check())
            {
                try
                {
                    item.Name = functionNameTxtbox.Text;

                    if (maxValueTxtbox.Text != "")
                        item.MaxValue = int.Parse(maxValueTxtbox.Text);
                    else
                        item.MaxValue = int.MaxValue;

                    if (minValueTxtbox.Text != "")
                        item.MinValue = int.Parse(minValueTxtbox.Text);
                    else
                        item.MinValue = int.MinValue;

                    
                    item.ReadOnly = readOnlyCheckbox.Checked;
                    item.FormStyle = formStyleCombox.Text;

                    if (item.FormStyle != "下拉列表")
                        item.ValueStringMap = null;

                    if (arraySizeTxtbox.Text != "")
                    {
                        int size = int.Parse(arraySizeTxtbox.Text);
                        if (size < 1)
                        {
                            MessageBox.Show("长度应大于0");
                            return false;
                        }
                        if (valueTypeCombox.Text == "System.Binary" && size > 64)
                        {
                            MessageBox.Show("最大不能超过64位");
                            return false;
                        }
                        item.Size = size;
                    }
                        
                    if (startPlaceCmbx.Text != "")
                        item.StartPlace = int.Parse(startPlaceCmbx.Text);

                    string valueTypeStr = valueTypeCombox.Text;
                    valueTypeStr = (valueTypeStr == "System.Binary" ? "System.Int64" : valueTypeStr);//转换Binary数据类型

                    item.ValueType = valueTypeStr;

                    if (item.MaxValue > item.MinValue)
                    {
                        this.item = item;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("最小值大于最大值");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                                                       
            }
            return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void valueTypeCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = valueTypeCombox.Text;
            switch (selectedText)
            {
                case "System.Binary":
                    startPlaceCmbx.Enabled = true;
                    arraySizeTxtbox.Enabled = true;

                    readOnlyCheckbox.Enabled = true;

                    maxValueTxtbox.Enabled = true;
                    minValueTxtbox.Enabled = true;

                    formStyleCombox.Enabled = true;
                    break;

                case "System.String":
                    startPlaceCmbx.Enabled = false;
                    startPlaceCmbx.SelectedIndex = -1;

                    arraySizeTxtbox.Enabled = true;

                    maxValueTxtbox.Text = "";
                    maxValueTxtbox.Enabled = false;
                    minValueTxtbox.Text = "";
                    minValueTxtbox.Enabled = false;

                    formStyleCombox.Enabled = false;
                    formStyleCombox.Text = "文本框";
                    break;

                case "System.Double":
                    startPlaceCmbx.Enabled = false;
                    startPlaceCmbx.SelectedIndex = -1;

                    arraySizeTxtbox.Text = "";
                    arraySizeTxtbox.Enabled = false;

                    maxValueTxtbox.Enabled = true;
                    minValueTxtbox.Enabled = true;

                    formStyleCombox.Enabled = false;
                    formStyleCombox.Text = "文本框";
                    break;

                case "System.Single":
                    startPlaceCmbx.Enabled = false;
                    startPlaceCmbx.SelectedIndex = -1;

                    arraySizeTxtbox.Text = "";
                    arraySizeTxtbox.Enabled = false;

                    maxValueTxtbox.Enabled = true;
                    minValueTxtbox.Enabled = true;

                    formStyleCombox.Enabled = false;
                    formStyleCombox.Text = "文本框";
                    break;

                default:
                    startPlaceCmbx.Enabled = false;
                    startPlaceCmbx.SelectedIndex = -1;

                    arraySizeTxtbox.Enabled = false;
                    arraySizeTxtbox.Text = "";

                    maxValueTxtbox.Enabled = true;
                    minValueTxtbox.Enabled = true;

                    formStyleCombox.Enabled = true;

                    formStyleCombox.Text = "文本框";
                    break;
            }
        }

        private void formStyleCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = formStyleCombox.Text;
            if (selectedText == "下拉列表")
            {
                editMapBtn.Enabled = true;
                readOnlyCheckbox.Checked = false;
                readOnlyCheckbox.Enabled = false;
            }
            else if (selectedText == "单选框")
            {
                valueTypeCombox.Text = "System.Binary";
                arraySizeTxtbox.Text = "1";
            }
            else
            {
                readOnlyCheckbox.Enabled = true;
                editMapBtn.Enabled = false;
            }
        }

        private void editAddressBtn_Click(object sender, EventArgs e)
        {
            item_temp.Address = UpdateMemoryAddressBox.UpdateMemoryAddress(item_temp.Address);
            if(item_temp.Address != null)
                addressTxtbox.Text = item_temp.Address.GetAddrString();
        }

        private void editMapBtn_Click(object sender, EventArgs e)
        {
            item_temp.ValueStringMap = UpdateValueStringMapBox.UpdateValueStringMap(item_temp.ValueStringMap);
            if (item_temp.ValueStringMap != null)
            {
                //断点测试
                return;
            }
        }

        private void arraySizeTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (arraySizeTxtbox.Text == "1" && valueTypeCombox.Text == "System.Binary")
            {
                formStyleCombox.Text = "单选框";
            }
        }
    }
    public static class UpdateFunctionItemBox
    {
        private static UpdateFunctionItemForm frm;
        
        public static FunctionItem UpdateFunctionItem(FunctionItem item = null)
        {
            frm = new UpdateFunctionItemForm();                      
            frm.Item = item;            
            frm.ShowDialog();

            return frm.Item;
        }
    }
}
