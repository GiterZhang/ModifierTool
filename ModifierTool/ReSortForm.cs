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
    public partial class ReSortItemsForm : Form
    {
        private List<FunctionPage> pages;
        public List<FunctionPage> Pages
        {
            set
            {
                pages = value;
            }
        }

        private List<FunctionItem> items;
        public List<FunctionItem> Items
        {
            set
            {
                items = value;
            }
        }

        public ReSortItemsForm()
        {
            InitializeComponent();
        }

        private void ReSortPageForm_Load(object sender, EventArgs e)
        {
            LoadItems();
        }
        public void LoadItems()
        {
            listBox1.Items.Clear();
            if (pages != null)
            {
                foreach (var page in pages)
                {
                    listBox1.Items.Add(page.Name);
                }
            }
            else if(items != null)
            {
                foreach (var item in items)
                {
                    listBox1.Items.Add(item.Name);
                }
            }
        }
        public void ExchangePagePlace(int index_x,int index_y)
        {
            FunctionPage temp = pages[index_x];
            pages[index_x] = pages[index_y];
            pages[index_y] = temp;
        }
        public void ExchangeItemPlace(int index_x, int index_y)
        {
            FunctionItem temp = items[index_x];
            items[index_x] = items[index_y];
            items[index_y] = temp;
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
                if (pages != null)
                {
                    ExchangePagePlace(index_x, index_y);
                }
                else if(items != null)
                {
                    ExchangeItemPlace(index_x, index_y);
                }
                
                LoadItems();

                listBox1.SelectedIndex = index_y;
            }
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (pages != null)
            {
                count = pages.Count;
            }
            else if (items != null)
            {
                count = items.Count;
            }
            if (listBox1.SelectedIndex < (count - 1))
            {
                int index_x = listBox1.SelectedIndex;
                int index_y = listBox1.SelectedIndex + 1;

                if (pages != null)
                {
                    ExchangePagePlace(index_x, index_y);
                }
                else if (items != null)
                {
                    ExchangeItemPlace(index_x, index_y);
                }

                LoadItems();

                listBox1.SelectedIndex = index_y;
            }
        }

    }
    public static class ReSortBox
    {
        private static ReSortItemsForm frm;
        public static void ReSort(List<FunctionPage> pages)
        {
            frm = new ReSortItemsForm();
            frm.Pages = pages;
            frm.ShowDialog();
        }
        public static void ReSort(List<FunctionItem> items)
        {
            frm = new ReSortItemsForm();
            frm.Items = items;
            frm.ShowDialog();
        }
    }
}
