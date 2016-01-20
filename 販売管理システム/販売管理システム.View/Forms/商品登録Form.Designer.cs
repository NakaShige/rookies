namespace 販売管理システム.View.Forms
{
    partial class 商品登録Form
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
            this.txt商品名 = new System.Windows.Forms.TextBox();
            this.btn登録 = new System.Windows.Forms.Button();
            this.lvw商品 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txt商品名
            // 
            this.txt商品名.Location = new System.Drawing.Point(12, 12);
            this.txt商品名.Name = "txt商品名";
            this.txt商品名.Size = new System.Drawing.Size(282, 19);
            this.txt商品名.TabIndex = 0;
            // 
            // btn登録
            // 
            this.btn登録.Location = new System.Drawing.Point(300, 8);
            this.btn登録.Name = "btn登録";
            this.btn登録.Size = new System.Drawing.Size(75, 23);
            this.btn登録.TabIndex = 1;
            this.btn登録.Text = "登録";
            this.btn登録.UseVisualStyleBackColor = true;
            this.btn登録.Click += new System.EventHandler(this.btn登録_Click);
            // 
            // lvw商品
            // 
            this.lvw商品.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvw商品.FullRowSelect = true;
            this.lvw商品.GridLines = true;
            this.lvw商品.Location = new System.Drawing.Point(12, 41);
            this.lvw商品.Name = "lvw商品";
            this.lvw商品.Size = new System.Drawing.Size(363, 170);
            this.lvw商品.TabIndex = 2;
            this.lvw商品.UseCompatibleStateImageBehavior = false;
            this.lvw商品.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名";
            this.columnHeader1.Width = 200;
            // 
            // 商品登録Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 223);
            this.Controls.Add(this.lvw商品);
            this.Controls.Add(this.btn登録);
            this.Controls.Add(this.txt商品名);
            this.Name = "商品登録Form";
            this.Text = "商品登録Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt商品名;
        private System.Windows.Forms.Button btn登録;
        private System.Windows.Forms.ListView lvw商品;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}