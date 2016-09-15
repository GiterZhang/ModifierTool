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
    public partial class ReSortPageForm : Form
    {
        private List<FunctionPage> pages;
        public List<FunctionPage> Pages
        {
            set
            {
                pages = value;
            }
        }
        public ReSortPageForm()
        {
            InitializeComponent();
        }

        private void ReSortPageForm_Load(object sender, EventArgs e)
        {
            LoadPages();
        }
        public void LoadPages()
        {
            listBox1.Items.Clear();
            if (pages != null)
            {
                foreach (var page in pages)
                {
                    listBox1.Items.Add(page.Name);
                }
            }
        }
        public void ExchangePagePlace(int index_x,int index_y)
        {
            FunctionPage temp = pages[index_x];
            pages[index_x] = pages[index_y];
            pages[index_y] = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void raiseBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                int index_x = listBox1.SelectedIndex;
                int index_y = listBox1.SelectedIndex - 1;
                ExchangePagePlace(index_x, index_y);
                LoadPages();

                listBox1.SelectedIndex = index_y;
            }
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < (pages.Count - 1))
            {
                int index_x = listBox1.SelectedIndex;
                int index_y = listBox1.SelectedIndex + 1;
                ExchangePagePlace(index_x, index_y);
                LoadPages();

                listBox1.SelectedIndex = index_y;
            }
        }

    }
    public static class ReSortPageBox
    {
        private static ReSortPageForm frm;
        public static void ReSortPage(List<FunctionPage> pages)
        {
            frm = new ReSortPageForm();
            frm.Pages = pages;
            frm.ShowDialog();
        }
    }
}
