
namespace OpenEnvLite
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
            this.title = new System.Windows.Forms.Label();
            this.土壤湿度 = new System.Windows.Forms.Label();
            this.土壤湿度显示 = new System.Windows.Forms.Label();
            this.亮度 = new System.Windows.Forms.Label();
            this.亮度显示 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 36);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(187, 29);
            this.title.TabIndex = 1;
            this.title.Text = "土壤属性探测";
            // 
            // 土壤湿度
            // 
            this.土壤湿度.AutoSize = true;
            this.土壤湿度.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.土壤湿度.ForeColor = System.Drawing.Color.White;
            this.土壤湿度.Location = new System.Drawing.Point(43, 89);
            this.土壤湿度.Name = "土壤湿度";
            this.土壤湿度.Size = new System.Drawing.Size(94, 21);
            this.土壤湿度.TabIndex = 6;
            this.土壤湿度.Text = "土壤湿度";
            // 
            // 土壤湿度显示
            // 
            this.土壤湿度显示.AutoSize = true;
            this.土壤湿度显示.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.土壤湿度显示.ForeColor = System.Drawing.Color.White;
            this.土壤湿度显示.Location = new System.Drawing.Point(143, 89);
            this.土壤湿度显示.Name = "土壤湿度显示";
            this.土壤湿度显示.Size = new System.Drawing.Size(73, 21);
            this.土壤湿度显示.TabIndex = 7;
            this.土壤湿度显示.Text = "检测中";
            // 
            // 亮度
            // 
            this.亮度.AutoSize = true;
            this.亮度.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.亮度.ForeColor = System.Drawing.Color.White;
            this.亮度.Location = new System.Drawing.Point(63, 110);
            this.亮度.Name = "亮度";
            this.亮度.Size = new System.Drawing.Size(52, 21);
            this.亮度.TabIndex = 8;
            this.亮度.Text = "亮度";
            // 
            // 亮度显示
            // 
            this.亮度显示.AutoSize = true;
            this.亮度显示.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.亮度显示.ForeColor = System.Drawing.Color.White;
            this.亮度显示.Location = new System.Drawing.Point(143, 110);
            this.亮度显示.Name = "亮度显示";
            this.亮度显示.Size = new System.Drawing.Size(73, 21);
            this.亮度显示.TabIndex = 9;
            this.亮度显示.Text = "检测中";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = " 微型土壤探测系统";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "相互科技 版权所有";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(191, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 39);
            this.button2.TabIndex = 13;
            this.button2.Text = "刷新";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(266, 228);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.亮度显示);
            this.Controls.Add(this.亮度);
            this.Controls.Add(this.土壤湿度显示);
            this.Controls.Add(this.土壤湿度);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label 土壤湿度;
        private System.Windows.Forms.Label 土壤湿度显示;
        private System.Windows.Forms.Label 亮度;
        private System.Windows.Forms.Label 亮度显示;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

