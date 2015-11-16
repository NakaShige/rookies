using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 面積管理システム.Model;

namespace 面積管理システム.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Event

        private void btnAddFigure_Click(object sender, EventArgs e)
        {
            var dlg = new AddFigureDialog();
            var ret = dlg.ShowDialog();

            if (ret == DialogResult.OK)
            {
                var item = dlg.SelectFigureItem;
                if (item != null)
                {
                    Global.DataManager.Add(item);
                }
            }
        }

        private void btnDeleteFigure_Click(object sender, EventArgs e)
        {
            if (!Global.DataManager.IsSelected)
                return;

            Global.DataManager.Remove(Global.DataManager.SelectedItem);
        }

        private void lvwFigure_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var selectedItem = e.Item != null ? e.Item.Tag as I図形 : null;
            Global.DataManager.SelectedItem = selectedItem;
        }

        #endregion

        public void UI更新()
        {
            lvwFigure.Items.Clear();

            Array.ForEach<I図形>(Global.DataManager.Items, p =>
                {
                    var item = new ListViewItem(p.Name);
                    item.SubItems.Add(p.面積.ToString("F4"));
                    item.Tag = p;

                    lvwFigure.Items.Add(item);
                });

            lblTotal.Text = "Total : " + Global.DataManager.Items.Sum(q => q.面積).ToString("F4");
        }
    }
}
