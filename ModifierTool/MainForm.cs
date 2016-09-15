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
using System.Security.Cryptography;

namespace ModifierTool
{
    public delegate void IOfunction(Stream stream);
    public partial class MainForm : Form
    {
        string filePath;
        string fileIdentifier = "3dm&&nba2k Game Modifier";

        ModifierConfig modifierConfig;

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
                this.Text = "3DM&NBA2K Game Modifier Tool" + " - [" + (value == null || value == "" ? "无标题" : value) + "]";       
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
                    if (reader != null)
                    {
                        System.Xml.Serialization.XmlSerializer xr = new System.Xml.Serialization.XmlSerializer(typeof(ModifierConfig));
                        modifierConfig = (ModifierConfig)xr.Deserialize(reader);

                        gameNameTxtbox.Text = modifierConfig.GameName;
                        processNameTxtbox.Text = modifierConfig.ProcessName;
                        moduleNameTxtbox.Text = modifierConfig.ModuleName;

                        reader.Close();
                        LoadVersions();
                        return true;
                    }                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取文件失败，已重新创建工程");                
            }
            return false;
        }
        private void CreateProject()
        {
            modifierConfig = new ModifierConfig();
            
            modifierConfig.FileIdentifier = fileIdentifier;

            gameNameTxtbox.Text = "GameName";
            processNameTxtbox.Text = "ProcessName";
            moduleNameTxtbox.Text = "ModuleName";

            modifierConfig.GameName = gameNameTxtbox.Text;
            modifierConfig.ProcessName = processNameTxtbox.Text;
            modifierConfig.ModuleName = moduleNameTxtbox.Text;

            LoadVersions();//清空        
        }
        private bool SaveFile(string fileName)
        {
            if (gameNameTxtbox.Text == "" || processNameTxtbox.Text == "" || moduleNameTxtbox.Text == "")
            {
                MessageBox.Show("游戏名称，进程名称，模块名称不能为空");
                return false;
            }
            modifierConfig.GameName = gameNameTxtbox.Text;
            modifierConfig.ProcessName = processNameTxtbox.Text;
            modifierConfig.ModuleName = moduleNameTxtbox.Text;

            if (fileName != null && fileName != "")
            {
                //Stream writer = CryptoFile("w");
                StreamWriter writer = new StreamWriter(fileName);
                if (writer != null)
                {
                    System.Xml.Serialization.XmlSerializer xr = new System.Xml.Serialization.XmlSerializer(typeof(ModifierConfig));
                    xr.Serialize(writer, modifierConfig);
                    //加密
                    writer.Close();
                    return true;
                }                         
            }
            else
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.Filter = "修改器脚本文件(*.msf)|*.msf";       //设置过滤器
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = fileDialog.FileName;
                    if (FileName != "" && FileName != null)
                    {
                        return SaveFile(FileName);
                    }
                }                            
            }
            return false;
        }

        private Stream CryptoFile(string format)
        {
            FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            try
            {
                format.ToLower();               
                byte[] key = System.Text.Encoding.Default.GetBytes(fileIdentifier.ToArray(),0,8);
                byte[] Iv = System.Text.Encoding.Default.GetBytes(fileIdentifier.ToArray());

                ICryptoTransform transform = new DESCryptoServiceProvider().CreateDecryptor(key,Iv);

                CryptoStream cs;
                if (format == "r")
                {
                    cs = new CryptoStream(fs, transform, CryptoStreamMode.Read);
                    return cs;
                }
                else if(format == "w")
                {
                    cs = new CryptoStream(fs, transform, CryptoStreamMode.Write);
                    return cs;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                fs.Close();
                return null;
            }          
        }

        private void LoadPages()
        {
            var pages = modifierConfig.Versions[GetVersionIndex()].Pages;
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
                var functionItems = modifierConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items;

                gridView.Rows.Clear();
                if (functionItems != null)
                {
                    ValueChangedFlag = ValueChangedFlag_Busy;
                    int index = 0;
                    foreach (var item in functionItems)
                    {
                        gridView.Rows.Add(
                            item.Name,
                            item.Address.GetAddrString(modifierConfig.ModuleName),
                            (item.ValueType == "System.Int64" ? "System.Binary" : item.ValueType),
                            item.ReadOnly,
                            (item.MaxValue == int.MaxValue ? "(none)" : item.MaxValue.ToString()),
                            (item.MinValue == int.MinValue ? "(none)" : item.MinValue.ToString()),
                            (item.Size == 0 ? "(none)" : item.Size.ToString()),
                            item.FormStyle,
                            "编辑"
                            );

                        if (item.FormStyle == "下拉列表")
                        {
                            gridView.Rows[index].Cells[3].ReadOnly = true;
                            gridView.Rows[index].Cells[3].Style.BackColor = Color.WhiteSmoke;
                        }
                        index++;
                    }
                    //释放锁定，允许修改
                    ValueChangedFlag = ValueChangedFlag_Free;
                }            
            }
            focusRowIndex = -1;                     
        }
        private void LoadVersions()
        {
            versionCombox.Items.Clear();
            tabPannel.TabPages.Clear();
            md5txtbox.Text = "";
            var versions = modifierConfig.Versions;
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
            if (modifierConfig.Versions == null)
            {
                modifierConfig.Versions = new List<Version>();
            }
            //先寻找有没有MD5相同的
            var version = UpdateVersionBox.UpdateVersion();
            if (version != null)
            {
                foreach (var ver in modifierConfig.Versions)
                {
                    if (ver.FileMd5 == version.FileMd5)
                    {
                        MessageBox.Show("新增的版本MD5与已存在的版本有重叠，拒绝添加！");
                        return;
                    }
                }

                //新建版本的时候拷贝页面
                if (modifierConfig.Versions.Count > 0)
                {
                    //待做
                }

                modifierConfig.Versions.Add(version);
                LoadVersions();
            }         
        }

        private void updateVersionBtn_Click(object sender, EventArgs e)
        {
            int index = GetVersionIndex();
            if (index >= 0)
            {
                var currentVersion = modifierConfig.Versions[index];
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
            if (GetVersionIndex() >= 0)
            {
                if (MessageBox.Show("确定要删除当前版本吗", "注意：", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var version = modifierConfig.Versions[GetVersionIndex()];
                    if (version != null)
                    {
                        modifierConfig.Versions.Remove(version);
                        LoadVersions();
                    }
                    else
                    {
                        MessageBox.Show("内部错误");
                    }
                }
            }            
        }

        private void 新建页面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newPage = new FunctionPage { Name = "新建页面" };
            modifierConfig.Versions[GetVersionIndex()].Pages.Add(newPage);
            tabPannel.TabPages.Add(newPage.Name);    
        }
        private void 重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var page = modifierConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()];
            var newName = Interaction.InputBox("输入页面名称", "重命名", page.Name);
            if (newName != "")
            {
                page.Name = newName;
                tabPannel.SelectedTab.Text = page.Name;
            }
        }
        private void 删除页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var page = modifierConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()];
            if (page.Items == null)
            {
                modifierConfig.Versions[GetVersionIndex()].Pages.RemoveAt(GetPageIndex());
                LoadPages();
            }
            else
            {
                if (MessageBox.Show("当前页面包含已编辑元素，确定要删除当前页面[" + page.Name + "]吗","注意：", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    modifierConfig.Versions[GetVersionIndex()].Pages.RemoveAt(GetPageIndex());
                    LoadPages();
                }
            }
        }
        private void 刷新页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GetPageIndex() >= 0 && GetVersionIndex() >= 0)
            {
                LoadItems();
            }
        }
        private void 重排页面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReSortPageBox.ReSortPage(modifierConfig.Versions[GetVersionIndex()].Pages);
            LoadPages();
        }


        private void 新建元素ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = UpdateFunctionItemBox.UpdateFunctionItem();
            if (modifierConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items == null)
                modifierConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items = new List<FunctionItem>();

            if (item != null)
            {
                modifierConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items.Add(item);
                LoadItems();
            }
        }
        private void 编辑元素ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (focusRowIndex >=0)
            {
                var item = modifierConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items[focusRowIndex];
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
                var item = modifierConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items[focusRowIndex];
                if (item != null)
                {
                    if (MessageBox.Show("确定要删除[" + item.Name + "]这个元素吗？","注意", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        modifierConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items.Remove(item);                        
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
                md5txtbox.Text = modifierConfig.Versions[index].FileMd5;
                LoadPages();
            }
        }

        private void gridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                focusRowIndex = e.RowIndex;
            }               
        }

        private void gridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int columnIndex = e.ColumnIndex;
                if (columnIndex == 1)
                {
                    var item = modifierConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items[e.RowIndex];
                    UpdateMemoryAddressBox.UpdateMemoryAddress(item.Address);
                    LoadItems();
                }
                else if (columnIndex == 8)
                {
                    var item = modifierConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items[e.RowIndex];
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
                modifierConfig.ModuleName = moduleNameTxtbox.Text;
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
                        modifierConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items[e.RowIndex].Name = name;
                    }
                }
                else if (colunmIndex == 3)
                {
                    modifierConfig.Versions[GetVersionIndex()].Pages[GetPageIndex()].Items[e.RowIndex].ReadOnly = bool.Parse(gridView.Rows[e.RowIndex].Cells[colunmIndex].Value.ToString());
                }
            }            
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (focusRowIndex != -1 && gridView.CurrentCell.ColumnIndex != 0 && gridView.CurrentCell.ColumnIndex != 3)
            {
                contextMenu.Items[6].Visible = true;
                contextMenu.Items[7].Visible = true;
            }
            else
            {
                contextMenu.Items[6].Visible = false;
                contextMenu.Items[7].Visible = false;
            }
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifierConfig.Versions != null && modifierConfig.Versions.Count > 0)
            {
                SaveFile(FileName);
            }
            FileName = null;
            CreateProject();        
        }
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "修改器脚本文件(*.msf)|*.msf";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = fileDialog.FileName;
                if (!LoadFile(FileName))
                    CreateProject();
            }
        }
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifierConfig.Versions != null && modifierConfig.Versions.Count > 0)
            {
                bool res = SaveFile(FileName);
                if (res == true)
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
            if (modifierConfig.Versions != null && modifierConfig.Versions.Count > 0)
            {
                if (FileName != null)
                {
                    SaveFile(FileName);
                }
                else if (MessageBox.Show("需要保存文档吗？", "注意：", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SaveFile(FileName);
                    
                }                
            }
        }

        
    }
}
