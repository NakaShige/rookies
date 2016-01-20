namespace 販売管理システム.View.Forms
{
    partial class 仕入処理Form
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
            this.txt仕入価格 = new System.Windows.Forms.TextBox();
            this.txt販売価格 = new System.Windows.Forms.TextBox();
            this.txt仕入数 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn仕入処理 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvw商品
            // 
            this.lvw商品.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvw商品.FullRowSelect = true;
            this.lvw商品.GridLines = true;
            this.lvw商品.Location = new System.Drawing.Point(12, 12);
            this.lvw商品.MultiSelect = false;
            this.lvw商品.Name = "lvw商品";
            this.lvw商品.Size = new System.Drawing.Size(221, 343);
            this.lvw商品.TabIndex = 3;
            this.lvw商品.UseCompatibleStateImageBehavior = false;
            this.lvw商品.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名";
            this.columnHeader1.Width = 200;
            // 
            // txt仕入価格
            // 
            this.txt仕入価格.Location = new System.Drawing.Point(299, 12);
            this.txt仕入価格.Name = "txt仕入価格";
            this.txt仕入価格.Size = new System.Drawing.Size(61, 19);
            this.txt仕入価格.TabIndex = 5;
            // 
            // txt販売価格
            // 
            this.txt販売価格.Location = new System.Drawing.Point(299, 37);
            this.txt販売価格.Name = "txt販売価格";
            this.txt販売価格.Size = new System.Drawing.Size(61, 19);
            this.txt販売価格.TabIndex = 6;
            // 
            // txt仕入数
            // 
            this.txt仕入数.Location = new System.Drawing.Point(299, 62);
            this.txt仕入数.Name = "txt仕入数";
            this.txt仕入数.Size = new System.Drawing.Size(61, 19);
            this.txt仕入数.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "仕入価格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "販売価格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "仕入数";
            // 
            // btn仕入処理
            // 
            this.btn仕入処理.Location = new System.Drawing.Point(239, 87);
            this.btn仕入処理.Name = "btn仕入処理";
            this.btn仕入処理.Size = new System.Drawing.Size(121, 268);
            this.btn仕入処理.TabIndex = 11;
            this.btn仕入処理.Text = "仕入処理";
            this.btn仕入処理.UseVisualStyleBackColor = true;
            this.btn仕入処理.Click += new System.EventHandler(this.btn仕入処理_Click);
            // 
            // 仕入処理Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 367);
            this.Controls.Add(this.btn仕入処理);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt仕入数);
            this.Controls.Add(this.txt販売価格);
            this.Controls.Add(this.txt仕入価格);
            this.Controls.Add(this.lvw商品);
            this.Name = "仕入処理Form";
            this.Text = "仕入処理Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvw商品;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txt仕入価格;
        private System.Windows.Forms.TextBox txt販売価格;
        private System.Windows.Forms.TextBox txt仕入数;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn仕入処理;
    }
}