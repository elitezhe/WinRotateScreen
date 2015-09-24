namespace ScreenRotater
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAntiClockwise = new System.Windows.Forms.Button();
            this.buttonClockwise = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAntiClockwise
            // 
            this.buttonAntiClockwise.Location = new System.Drawing.Point(12, 12);
            this.buttonAntiClockwise.Name = "buttonAntiClockwise";
            this.buttonAntiClockwise.Size = new System.Drawing.Size(75, 23);
            this.buttonAntiClockwise.TabIndex = 0;
            this.buttonAntiClockwise.Text = "逆时针转动";
            this.buttonAntiClockwise.UseVisualStyleBackColor = true;
            this.buttonAntiClockwise.Click += new System.EventHandler(this.buttonAntiClockwise_Click);
            // 
            // buttonClockwise
            // 
            this.buttonClockwise.Location = new System.Drawing.Point(122, 12);
            this.buttonClockwise.Name = "buttonClockwise";
            this.buttonClockwise.Size = new System.Drawing.Size(75, 23);
            this.buttonClockwise.TabIndex = 1;
            this.buttonClockwise.Text = "顺时针转动";
            this.buttonClockwise.UseVisualStyleBackColor = true;
            this.buttonClockwise.Click += new System.EventHandler(this.buttonClockwise_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonTest.Location = new System.Drawing.Point(135, 237);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 2;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 216);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 272);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonClockwise);
            this.Controls.Add(this.buttonAntiClockwise);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAntiClockwise;
        private System.Windows.Forms.Button buttonClockwise;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

