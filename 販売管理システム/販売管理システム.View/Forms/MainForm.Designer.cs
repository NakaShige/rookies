namespace 販売管理システム.View.Forms
{
    partial class MainForm
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("商品名");
            this.lvw本日の売上 = new System.Windows.Forms.ListView();
            this.btn商品登録 = new System.Windows.Forms.Button();
            this.btn仕入処理 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvw本日の売上
            // 
            this.lvw本日の売上.FullRowSelect = true;
            this.lvw本日の売上.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvw本日の売上.Location = new System.Drawing.Point(12, 39);
            this.lvw本日の売上.Name = "lvw本日の売上";
            this.lvw本日の売上.Size = new System.Drawing.Size(312, 399);
            this.lvw本日の売上.TabIndex = 0;
            this.lvw本日の売上.UseCompatibleStateImageBehavior = false;
            this.lvw本日の売上.View = System.Windows.Forms.View.Details;
            // 
            // btn商品登録
            // 
            this.btn商品登録.Location = new System.Drawing.Point(341, 12);
            this.btn商品登録.Name = "btn商品登録";
            this.btn商品登録.Size = new System.Drawing.Size(158, 76);
            this.btn商品登録.TabIndex = 1;
            this.btn商品登録.Text = "商品登録";
            this.btn商品登録.UseVisualStyleBackColor = true;
            this.btn商品登録.Click += new System.EventHandler(this.btn商品登録_Click);
            // 
            // btn仕入処理
            // 
            this.btn仕入処理.Location = new System.Drawing.Point(341, 94);
            this.btn仕入処理.Name = "btn仕入処理";
            this.btn仕入処理.Size = new System.Drawing.Size(158, 76);
            this.btn仕入処理.TabIndex = 2;
            this.btn仕入処理.Text = "仕入処理";
            this.btn仕入処理.UseVisualStyleBackColor = true;
            this.btn仕入処理.Click += new System.EventHandler(this.btn仕入処理_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.btn仕入処理);
            this.Controls.Add(this.btn商品登録);
            this.Controls.Add(this.lvw本日の売上);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvw本日の売上;
        private System.Windows.Forms.Button btn商品登録;
        private System.Windows.Forms.Button btn仕入処理;
    }
}