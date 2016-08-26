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
    public partial class UpdateMemoryAddressForm : Form
    {
        private MemoryAddress address;
        private MemoryAddress address_temp;
        public MemoryAddress Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                address_temp = value;
                if (value != null)
                {                   
                    addrTxtbox.Text = address.Address.ToString("x2");
                    IsContain.Checked = address.IsContainModuleAddr;
                    IsPtrCheckbox.Checked = address.IsPtr;

                    if (address.IsPtr)
                    {
                        foreach (var offset in address.Offsets)
                        {
                            if (offsetsTxtbox.Text != "")
                            {
                                offsetsTxtbox.Text += "\r\n";
                            }
                            offsetsTxtbox.Text += offset.ToString("x2");
                        }
                    }
                   
                    
                }
                else
                {
                    address_temp = new MemoryAddress();
                }
                
            }
        }
        public UpdateMemoryAddressForm()
        {
            InitializeComponent();
        }

        private void MemoryAdressForm_Load(object sender, EventArgs e)
        {

        }
        private bool Check()
        {
            if (addrTxtbox.Text == "")
            {
                MessageBox.Show("地址不能为空");               
                return false;
            }
            else
            {
                try
                {
                    long.Parse(addrTxtbox.Text, System.Globalization.NumberStyles.HexNumber);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("地址书写有误：" + ex.Message);
                    return false;
                }
            }


            if (IsPtrCheckbox.Checked)
            {
                int index = 1;//行数
                try
                {                    
                    foreach (var str in offsetsTxtbox.Lines)
                    {
                        int.Parse(str, System.Globalization.NumberStyles.HexNumber);
                        index++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("第" + index + "行地址书写有误：" + ex.Message);
                    return false;
                }                               
            }
            return true;
        }
        private bool Submit(MemoryAddress addr)
        {
            if (addr != null)
            {
                if (Check())
                {
                    addr.IsContainModuleAddr = IsContain.Checked;
                    addr.Address = long.Parse(addrTxtbox.Text, System.Globalization.NumberStyles.HexNumber);
                    addr.IsPtr = IsPtrCheckbox.Checked;
                                
                    if (addr.IsPtr)
                    {
                        addr.Offsets = new List<int>();
                        foreach (var offset in offsetsTxtbox.Lines)
                        {
                            addr.Offsets.Add(int.Parse(offset, System.Globalization.NumberStyles.HexNumber));
                        }
                    }
                    this.address = addr;
                    return true;                                       
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Submit(address_temp))
            {
                Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IsPtrCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsPtrCheckbox.Checked)
            {
                offsetsTxtbox.Enabled = true;
            }
            else
            {
                offsetsTxtbox.Enabled = false;
                offsetsTxtbox.Text = "";
            }
        }
    }
    public static class UpdateMemoryAddressBox
    {
        private static UpdateMemoryAddressForm frm;
        public static MemoryAddress UpdateMemoryAddress(MemoryAddress address = null)
        {
            frm = new UpdateMemoryAddressForm();
            frm.Address = address;
            frm.ShowDialog();

            return frm.Address;
        }
    }

}
