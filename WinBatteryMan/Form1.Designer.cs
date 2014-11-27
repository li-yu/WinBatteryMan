namespace WinBatteryMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label_powersource = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar_level = new System.Windows.Forms.ProgressBar();
            this.label_level = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(340, 232);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "电量记录";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(370, 199);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(200, 72);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "开始监控";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_powersource
            // 
            this.label_powersource.AutoSize = true;
            this.label_powersource.Location = new System.Drawing.Point(71, 20);
            this.label_powersource.Name = "label_powersource";
            this.label_powersource.Size = new System.Drawing.Size(17, 12);
            this.label_powersource.TabIndex = 3;
            this.label_powersource.Text = "NA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "电源类型:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_status);
            this.groupBox2.Controls.Add(this.label_level);
            this.groupBox2.Controls.Add(this.progressBar_level);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label_powersource);
            this.groupBox2.Location = new System.Drawing.Point(370, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 180);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "电源信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "当前电量:";
            // 
            // progressBar_level
            // 
            this.progressBar_level.Location = new System.Drawing.Point(8, 59);
            this.progressBar_level.Name = "progressBar_level";
            this.progressBar_level.Size = new System.Drawing.Size(186, 23);
            this.progressBar_level.Step = 100;
            this.progressBar_level.TabIndex = 6;
            // 
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.Location = new System.Drawing.Point(71, 44);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(17, 12);
            this.label_level.TabIndex = 7;
            this.label_level.Text = "NA";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_status.Location = new System.Drawing.Point(40, 104);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 46);
            this.label_status.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 278);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinBatteryMan v1.0.0 20141127";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_powersource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.ProgressBar progressBar_level;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_status;
    }
}

