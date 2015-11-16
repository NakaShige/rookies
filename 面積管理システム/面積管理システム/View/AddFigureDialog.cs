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
    public partial class AddFigureDialog : Form
    {
        public AddFigureDialog()
        {
            InitializeComponent();
            this.CancelButton = btnCancel;
        }

        public I図形 SelectFigureItem
        {
            get
            {
                double dLength;
                if (!double.TryParse(txtLength.Text, out dLength))
                    return null;

                if (rbnSquare.Checked)
                {
                    return new 四角形(dLength);
                }
                else if (rbnTriangle.Checked)
                {
                    return new 三角形(dLength);
                }
                return null;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
