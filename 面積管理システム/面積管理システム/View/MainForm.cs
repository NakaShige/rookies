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
using 面積管理システム.Model.図形;
using 面積管理システム.View.Commands;

namespace 面積管理システム.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Event

        private void btnAddFigure_Click(object sender, EventArgs e)
        {
            CommandManager.Execute(Commands.CommandType.Add);
        }

        private void btnDeleteFigure_Click(object sender, EventArgs e)
        {
            CommandManager.Execute(Commands.CommandType.Delete);
        }

        private void lvwFigure_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var selectedItem = (e.IsSelected && e.Item != null) ? e.Item.Tag as I図形 : null;
            Global.図形一覧.SelectedItem = selectedItem;

            UpdateCommandButton();
        }

        #endregion

        public void UI更新()
        {
            UpdateList();
            UpdateCommandButton();
        }

        private void UpdateList()
        {
            lvwFigure.Items.Clear();

            Array.ForEach<I図形>(Global.図形一覧.Items, p =>
            {
                var item = new ListViewItem(p.Name);
                item.SubItems.Add(p.面積.ToString("F4"));
                item.Tag = p;

                lvwFigure.Items.Add(item);
            });

            lblTotal.Text = "Total : " + Global.図形一覧.Items.Sum(q => q.面積).ToString("F4");
        }

        private void UpdateCommandButton()
        {
            btnAddFigure.Enabled = CommandManager.CanExecute(Commands.CommandType.Add);
            btnDeleteFigure.Enabled = CommandManager.CanExecute(Commands.CommandType.Delete);
        }
    }
}
