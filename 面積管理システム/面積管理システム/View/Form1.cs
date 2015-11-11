using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 面積管理システム.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddFigure_Click(object sender, EventArgs e)
        {
            var dlg = new AddFigureDialog();
            var ret = dlg.ShowDialog();

            if (ret == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
            else if (ret == System.Windows.Forms.DialogResult.Cancel)
            {
                MessageBox.Show("Cancel");
            }
        }
    }
}
