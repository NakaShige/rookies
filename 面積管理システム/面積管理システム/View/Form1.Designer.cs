namespace 面積管理システム.View
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lvwFigure = new System.Windows.Forms.ListView();
            this.図形名称 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Area = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddFigure = new System.Windows.Forms.Button();
            this.btnDeleteFigure = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwFigure
            // 
            this.lvwFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwFigure.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.図形名称,
            this.Area});
            this.lvwFigure.FullRowSelect = true;
            this.lvwFigure.Location = new System.Drawing.Point(12, 12);
            this.lvwFigure.MultiSelect = false;
            this.lvwFigure.Name = "lvwFigure";
            this.lvwFigure.Size = new System.Drawing.Size(268, 252);
            this.lvwFigure.TabIndex = 0;
            this.lvwFigure.UseCompatibleStateImageBehavior = false;
            this.lvwFigure.View = System.Windows.Forms.View.Details;
            this.lvwFigure.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwFigure_ItemSelectionChanged);
            // 
            // 図形名称
            // 
            this.図形名称.Text = "図形名称";
            this.図形名称.Width = 120;
            // 
            // Area
            // 
            this.Area.Text = "面積(㎡)";
            this.Area.Width = 120;
            // 
            // btnAddFigure
            // 
            this.btnAddFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFigure.Location = new System.Drawing.Point(286, 56);
            this.btnAddFigure.Name = "btnAddFigure";
            this.btnAddFigure.Size = new System.Drawing.Size(104, 41);
            this.btnAddFigure.TabIndex = 1;
            this.btnAddFigure.Text = "追加";
            this.btnAddFigure.UseVisualStyleBackColor = true;
            this.btnAddFigure.Click += new System.EventHandler(this.btnAddFigure_Click);
            // 
            // btnDeleteFigure
            // 
            this.btnDeleteFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFigure.Location = new System.Drawing.Point(286, 103);
            this.btnDeleteFigure.Name = "btnDeleteFigure";
            this.btnDeleteFigure.Size = new System.Drawing.Size(104, 41);
            this.btnDeleteFigure.TabIndex = 2;
            this.btnDeleteFigure.Text = "削除";
            this.btnDeleteFigure.UseVisualStyleBackColor = true;
            this.btnDeleteFigure.Click += new System.EventHandler(this.btnDeleteFigure_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(284, 31);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 12);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 276);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnDeleteFigure);
            this.Controls.Add(this.btnAddFigure);
            this.Controls.Add(this.lvwFigure);
            this.Name = "Form1";
            this.Text = "面積管理システム";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwFigure;
        private System.Windows.Forms.Button btnAddFigure;
        private System.Windows.Forms.ColumnHeader 図形名称;
        private System.Windows.Forms.ColumnHeader Area;
        private System.Windows.Forms.Button btnDeleteFigure;
        private System.Windows.Forms.Label lblTotal;
    }
}

