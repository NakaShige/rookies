namespace 販売管理システム.View.Forms
{
    partial class 在庫一覧Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvw商品 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvw商品
            // 
            this.lvw商品.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvw商品.FullRowSelect = true;
            this.lvw商品.GridLines = true;
            this.lvw商品.Location = new System.Drawing.Point(12, 12);
            this.lvw商品.Name = "lvw商品";
            this.lvw商品.Size = new System.Drawing.Size(536, 456);
            this.lvw商品.TabIndex = 4;
            this.lvw商品.UseCompatibleStateImageBehavior = false;
            this.lvw商品.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "仕入価格";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "販売価格";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "在庫数";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "仕入日";
            // 
            // 在庫一覧Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 482);
            this.Controls.Add(this.lvw商品);
            this.Name = "在庫一覧Form";
            this.Text = "在庫一覧Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvw商品;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}