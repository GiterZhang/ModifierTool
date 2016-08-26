using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ModifierTool
{
    public partial class MainForm : Form
    {
        string filePath;
        string fileIdentifier = "3dm&nba2k game modifier";

        ModiferConfig modiferConfig;

        int focusRowIndex = -1;

        int ValueChangedFlag = ValueChangedFlag_Busy;

        const int ValueChangedFlag_Busy = 0;
        const int ValueChangedFlag_Free = 1;

        public string FileName
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
                this.Text = "3DM&NBA2K Game Modifier Tool" + " - [" + (value == null ? "无标题" : value) + "]";       
            }
        }

        public MainForm(string fileName = null)
        {           
            InitializeComponent();
            FileName = fileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabPannel.TabPages.Clear();
            if (!LoadFile(FileName))
            {
                CreateProject();
            }
        }
        private bool LoadFile(string fileName)
        {
            try
            {
                if (fileName != null && fileName != "")
                {
                    StreamReader reader = new StreamReader(fileName);
                    System.Xml.Serialization.XmlSerializer xr = new System.Xml.Serialization.XmlSerializer(typeof(ModiferConfig));
                    modiferConfig = (ModiferConfig)xr.Deserialize(reader);

                    gameNameTxtbox.Text = modiferConfig.GameName;
                    processNameTxtbox.Text = modiferConfig.ProcessName;
                    moduleNameTxtbox.Text = modiferConfig.ModuleName;
                    reader.Close();
                    LoadVersions();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取文件失败，已重新创建工程");
                return false;
            }
            
            return false;
        }
        private void CreateProject()
        {
            modiferConfig = new ModiferConfig();
            
            modiferConfig.FileIdentifier = fileIdentifier;

            modiferConfig.GameName = gameNameTxtbox.Text;
            modiferConfig.ProcessName = processNameTxtbox.Text;
            modiferConfig.ModuleName = moduleNameTxtbox.Text;

            LoadVersions();//清空        
        }
        private bool SaveFile(string fileName)
        {
            if (gameNameTxtbox.Text == "" || processNameTxtbox.Text == "" || moduleNameTxtbox.Text == "")
            {
                MessageBox.Show("游戏名称，进程名称，模块名称不能为空");
                return false;
            }
            modiferConfig.GameName = gameNameTxtbox.Text;
            modiferConfig.ProcessName = processNameTxtbox.Text;
            modiferConfig.ModuleName = moduleNameTxtbox.Text;

            if (fileName != null && fileName != "")
            {
                StreamWriter writer = new System.IO.StreamWriter(fileName);
                System.Xml.Serialization.XmlSerializer xr = new System.Xml.Serialization.XmlSerializer(typeof(ModiferConfig));
                xr.Serialize(writer, modiferConfig);
                writer.Close();
                return true;
            }
            else
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = fileDialog.FileName;
                    if (FileName != "" && FileName != null)
                    {
                        SaveFile(FileName);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }            
                
            }
            return false;

            //判断是否存在多个版本MD5值一样
            //判断是否有一个版本没有页
        }

        private void LoadPages()
        {
            var pages = modiferConfig.Versions[GetVersionIndex()].Pages;
            tabPannel.TabPages.Clear();
            if (pages != null)
            {               
                foreach (var page in pages)
                {
                    TabPage tabPage = new TabPage();
                    tabPage.Text = page.Name;
                    tabPannel.TabPages.Add(tabPage);
                }
                LoadItems();
            }
            
        }
        private void LoadItems()
        {
            TabPage currentPage = tabPannel.SelectedTab;
            if (currentPage != null)
            {
                currentPage.Controls.Add(gridView);
                var functionItems = modiferConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items;

                gridView.Rows.Clear();
                if (functionItems != null)
                {
                    ValueChangedFlag = ValueChangedFlag_Busy;
                    foreach (var item in functionItems)
                    {
                        gridView.Rows.Add(
                            item.Name,
                            item.Address.GetAddrString(modiferConfig.ModuleName),
                            item.ValueType,
                            item.ReadOnly,
                            (item.MaxValue == double.MaxValue ? "(none)" : item.MaxValue.ToString()),
                            (item.MinValue == double.MinValue ? "(none)" : item.MinValue.ToString()),
                            (item.Size == 0 ? "(none)" : item.Size.ToString()),
                            item.FormStyle,
                            "编辑"
                            );
                    }
                    //释放锁定，允许修改
                    ValueChangedFlag = ValueChangedFlag_Free;
                }            
            }                     
        }
        private void LoadVersions()
        {
            versionCombox.Items.Clear();
            tabPannel.TabPages.Clear();
            md5txtbox.Text = "";
            var versions = modiferConfig.Versions;
            if (versions != null)
            {
                foreach (var version in versions)
                {
                    versionCombox.Items.Add(version.VersionName);
                }
            }
        }
        private int GetVersionIndex()
        {
            return versionCombox.SelectedIndex;
        }
        private int GetPageIndex()
        {
            return tabPannel.SelectedIndex;
        }       

        private void addVersionBtn_Click(object sender, EventArgs e)
        {
            if (modiferConfig.Versions == null)
            {
                modiferConfig.Versions = new List<Version>();
            }
            //先寻找有没有MD5相同的
            var version = UpdateVersionBox.UpdateVersion();
            if (version != null)
            {
                foreach (var ver in modiferConfig.Versions)
                {
                    if (ver.FileMd5 == version.FileMd5)
                    {
                        MessageBox.Show("新增的版本MD5与已存在的版本有重叠，拒绝添加！");
                        return;
                    }
                }
                modiferConfig.Versions.Add(version);
                LoadVersions();
            }         
        }

        private void updateVersionBtn_Click(object sender, EventArgs e)
        {
            int index = GetVersionIndex();
            if (index >= 0)
            {
                var currentVersion = modiferConfig.Versions[index];
                if (currentVersion != null)
                {
                    UpdateVersionBox.UpdateVersion(currentVersion);

                    LoadVersions();
                }
                else
                {
                    MessageBox.Show("选取版本失败");
                }                              
            }            
            
            LoadVersions();
        }       

        private void deleteVersionBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定要删除当前版本吗", "注意：", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var version = modiferConfig.Versions[GetVersionIndex()];
                if (version != null)
                {
                    modiferConfig.Versions.Remove(version);
                    LoadVersions();
                }
                else
                {
                    MessageBox.Show("内部错误");
                }
            }
        }

        private void 新建页面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modiferConfig.Versions[GetVersionIndex()].Pages.Add(new FunctionPage { Name = "默认页面" });
            tabPannel.TabPages.Add("默认页面");
    
        }
        private void 刷新页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GetPageIndex() >= 0 && GetVersionIndex() >= 0)
            {
                LoadItems();
            }
        }
        private void 新建元素ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = UpdateFunctionItemBox.UpdateFunctionItem();
            if (modiferConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items == null)
                modiferConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items = new List<FunctionItem>();

            if (item != null)
            {
                modiferConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items.Add(item);
                LoadItems();
            }
        }
        private void 编辑元素ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (focusRowIndex >=0)
            {
                var item = modiferConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items[focusRowIndex];
                if (item != null)
                {
                    UpdateFunctionItemBox.UpdateFunctionItem(item);
                    LoadItems();
                }
            }            
        }
        private void 删除元素ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (focusRowIndex >= 0)
            {
                var item = modiferConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items[focusRowIndex];
                if (item != null)
                {
                    if (MessageBox.Show("确定要删除[" + item.Name + "]这个元素吗？","注意", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        
                        modiferConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items.Remove(item);                        
                        LoadItems();
                        focusRowIndex = -1;
                    }
                }
            }                     
        }

        private void versionCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = versionCombox.SelectedIndex;
            if (index >= 0)
            {
                md5txtbox.Text = modiferConfig.Versions[index].FileMd5;
                LoadPages();
            }
        }

        private void gridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                focusRowIndex = e.RowIndex;
            }               
            else if(e.RowIndex >= 0)
            {
                int columnIndex = e.ColumnIndex;
                if (columnIndex == 1)
                {
                    var item = modiferConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items[e.RowIndex];
                    UpdateMemoryAddressBox.UpdateMemoryAddress(item.Address);
                    LoadItems();
                }
                else if(columnIndex == 8)
                {
                    var item = modiferConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items[e.RowIndex];
                    if (item.FormStyle == "下拉列表")
                    {                        
                        UpdateValueStringMapBox.UpdateValueStringMap(item.ValueStringMap);
                        LoadItems();
                    }
                    else
                    {
                        MessageBox.Show("非下拉列表，没有值串映射");
                    }
                    
                }
            }
        }

        private void tabPannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPannel.SelectedIndex >= 0 && GetVersionIndex() >= 0 )
            {
                LoadItems();
            }           
        }
        
        private void moduleNameTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (GetPageIndex() >= 0 && GetVersionIndex() >= 0)
            {
                modiferConfig.ModuleName = moduleNameTxtbox.Text;
                LoadItems();
            }
        }

        private void gridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int colunmIndex = e.ColumnIndex;
            if (ValueChangedFlag == ValueChangedFlag_Free && e.RowIndex >= 0) 
            {
                if (colunmIndex == 0)
                {
                    string name = gridView.Rows[e.RowIndex].Cells[colunmIndex].Value.ToString();
                    if (name == "" || name == null)
                    {
                        MessageBox.Show("不能为空");

                        ValueChangedFlag = ValueChangedFlag_Busy;
                        gridView.Rows[e.RowIndex].Cells[colunmIndex].Value = "Function";
                        ValueChangedFlag = ValueChangedFlag_Free;
                    }
                    else
                    {
                        modiferConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items[e.RowIndex].Name = name;
                    }
                }
                else if (colunmIndex == 3)
                {
                    modiferConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items[e.RowIndex].ReadOnly = bool.Parse(gridView.Rows[e.RowIndex].Cells[colunmIndex].Value.ToString());
                }
            }            
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (focusRowIndex != -1 && gridView.CurrentCell.ColumnIndex != 0 && gridView.CurrentCell.ColumnIndex != 3)
            {
                contextMenu.Items[5].Visible = true;
                contextMenu.Items[6].Visible = true;
            }
            else
            {
                contextMenu.Items[5].Visible = false;
                contextMenu.Items[6].Visible = false;
            }
        }


        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modiferConfig.Versions != null && modiferConfig.Versions.Count > 0)
            {
                SaveFile(FileName);
            }
            FileName = null;
            CreateProject();        
        }
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = fileDialog.FileName;
                if (!LoadFile(FileName))
                    CreateProject();
            }
        }
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modiferConfig.Versions != null && modiferConfig.Versions.Count > 0)
            {
                if (SaveFile(FileName))
                {
                    MessageBox.Show("保存成功！");
                }
            }            
        }
        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFile(""))
            {
                MessageBox.Show("保存成功！");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modiferConfig.Versions != null && modiferConfig.Versions.Count > 0)
            {
                SaveFile(FileName);
            }
        }

        private void 重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var page = modiferConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()];
            var newName = Interaction.InputBox("输入页面名称", "重命名", page.Name);
            if (newName != "")
            {
                page.Name = newName;
                tabPannel.SelectedTab.Text = page.Name;
            }
        }
    }
}
