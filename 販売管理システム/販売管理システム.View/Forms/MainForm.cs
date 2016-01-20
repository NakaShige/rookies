using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 販売管理システム.Model.Data;
using 販売管理システム.View.ViewModel;

namespace 販売管理システム.View.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DataManager.getInstance().ChangedData += ChangedDataEvent;
        }

        private void ChangedDataEvent()
        {
            // データ変更による画面の更新処理
            var mainVM = ViewModelManager.getInstance().GetMainFormVM();
        }

        private void btn商品登録_Click(object sender, EventArgs e)
        {
            var dlg = new 商品登録Form();
            dlg.ShowDialog();
        }

        private void btn仕入処理_Click(object sender, EventArgs e)
        {
            var dlg = new 仕入処理Form();
            dlg.ShowDialog();
        }
    }
}
