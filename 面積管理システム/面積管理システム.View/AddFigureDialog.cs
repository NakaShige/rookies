using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 面積管理システム.Model.図形;

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
                double? length = this.Length;
                if (!length.HasValue)
                    return null;

                if (rbnSquare.Checked) return new 四角形(length.Value);
                else if (rbnTriangle.Checked) return new 三角形(length.Value);
                
                return null;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double? length = this.Length;
            if (!length.HasValue)
            {
                MessageBox.Show("長さの入力が間違っています。");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private double? Length
        {
            get
            {
                double dLength;
                if (!double.TryParse(txtLength.Text, out dLength) || dLength <= 0.0)
                    return null;

                return dLength;
            }
        }
    }
}
