using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 販売管理システム.Model.Data;

namespace 販売管理システム.View.Forms
{
    public partial class 仕入処理Form : Form
    {
        public 仕入処理Form()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void btn仕入処理_Click(object sender, EventArgs e)
        {
            if (1 != lvw商品.SelectedItems.Count)
                return;

            //lvw商品.SelectedItems[0].Tag;
        }

        private void UpdateUI()
        {
            lvw商品.Items.Clear();
            lvw商品.BeginUpdate();

            foreach (var item in DataManager.getInstance().商品List)
            {
                var lvwItem = new ListViewItem(item.Name);
                //lvwItem.Tag = item;
                lvw商品.Items.Add(lvwItem);
            }

            lvw商品.EndUpdate();
        }
    }
}
