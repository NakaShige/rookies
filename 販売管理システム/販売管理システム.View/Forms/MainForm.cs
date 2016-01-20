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

            // Test
            Function();
        }

        private void ChangedDataEvent()
        {
            // データ変更による画面の更新処理
            var mainVM = ViewModelManager.getInstance().GetMainFormVM();
        }

        public void Function()
        {
            var dataManager = DataManager.getInstance();

            dataManager.商品登録("AAA");
            dataManager.商品登録("BBB");
            dataManager.商品登録("aaa"); // 登録されない（既に「AAA」があるので）


            dataManager.仕入処理(dataManager.商品List[0], 100, 200, 10, DateTime.Parse("2016/01/01"));
        }
    }
}
