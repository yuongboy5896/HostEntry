namespace HostEntry
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Domainlist = new System.Windows.Forms.TextBox();
            this.tBoutDir = new System.Windows.Forms.TextBox();
            this.btnDir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 579);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "导出对应IP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "域名列表：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Domainlist
            // 
            this.Domainlist.Location = new System.Drawing.Point(191, 68);
            this.Domainlist.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Domainlist.Multiline = true;
            this.Domainlist.Name = "Domainlist";
            this.Domainlist.Size = new System.Drawing.Size(424, 221);
            this.Domainlist.TabIndex = 2;
            // 
            // tBoutDir
            // 
            this.tBoutDir.Location = new System.Drawing.Point(191, 399);
            this.tBoutDir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tBoutDir.Name = "tBoutDir";
            this.tBoutDir.Size = new System.Drawing.Size(424, 31);
            this.tBoutDir.TabIndex = 3;
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(629, 399);
            this.btnDir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(79, 42);
            this.btnDir.TabIndex = 4;
            this.btnDir.Text = "...";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 399);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "导出目录：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 807);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.tBoutDir);
            this.Controls.Add(this.Domainlist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "域名小工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Domainlist;
        private System.Windows.Forms.TextBox tBoutDir;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Label label2;
    }
}

