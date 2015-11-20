namespace 面積管理システム.View
{
    partial class AddFigureDialog
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
            this.btnOK = new System.Windows.Forms.Button();
            this.rbnSquare = new System.Windows.Forms.RadioButton();
            this.rbnTriangle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 125);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 39);
            this.btnOK.TabIndex = 6;
            this.btnOK.Tag = "OK";
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rbnSquare
            // 
            this.rbnSquare.AutoSize = true;
            this.rbnSquare.Checked = true;
            this.rbnSquare.Location = new System.Drawing.Point(6, 28);
            this.rbnSquare.Name = "rbnSquare";
            this.rbnSquare.Size = new System.Drawing.Size(59, 16);
            this.rbnSquare.TabIndex = 1;
            this.rbnSquare.TabStop = true;
            this.rbnSquare.Text = "四角形";
            this.rbnSquare.UseVisualStyleBackColor = true;
            // 
            // rbnTriangle
            // 
            this.rbnTriangle.AutoSize = true;
            this.rbnTriangle.Location = new System.Drawing.Point(121, 28);
            this.rbnTriangle.Name = "rbnTriangle";
            this.rbnTriangle.Size = new System.Drawing.Size(59, 16);
            this.rbnTriangle.TabIndex = 2;
            this.rbnTriangle.Text = "三角形";
            this.rbnTriangle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnSquare);
            this.groupBox1.Controls.Add(this.rbnTriangle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "種類";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "一辺の長さ";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(83, 93);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(155, 19);
            this.txtLength.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(133, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 39);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Tag = "Cancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddFigureDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 180);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddFigureDialog";
            this.Text = "図形追加";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rbnSquare;
        private System.Windows.Forms.RadioButton rbnTriangle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button btnCancel;
    }
}