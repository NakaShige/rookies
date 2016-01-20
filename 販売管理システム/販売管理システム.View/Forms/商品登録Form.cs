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
    public partial class 商品登録Form : Form
    {
        public 商品登録Form()
        {
            InitializeComponent();

            DataManager.getInstance().ChangedData += 商品登録Form_ChangedData;
            UpdateUI();
        }

        private void 商品登録Form_ChangedData()
        {
            this.UpdateUI();
        }

        private void btn登録_Click(object sender, EventArgs e)
        {
            string s商品名 = txt商品名.Text;
            if (!DataManager.getInstance().商品登録(s商品名))
            {
                MessageBox.Show("入力名がおかしいか、既に登録されている");
                return;
            }

            MessageBox.Show("登録できました。");
            this.Close();
        }

        private void UpdateUI()
        {
            lvw商品.Items.Clear();
            lvw商品.BeginUpdate();

            foreach (var item in DataManager.getInstance().商品List)
            {
                lvw商品.Items.Add(new ListViewItem(item.Name));
            }

            lvw商品.EndUpdate();
        }
    }
}
