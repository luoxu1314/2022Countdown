
namespace YourBelief
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
            this.textbox_tm2 = new WinFormsApp1.textbox_tm();
            this.textbox_tm1 = new WinFormsApp1.textbox_tm();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = " 刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox_tm2
            // 
            this.textbox_tm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_tm2.BackColor = System.Drawing.SystemColors.Window;
            this.textbox_tm2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_tm2.Enabled = false;
            this.textbox_tm2.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textbox_tm2.ForeColor = System.Drawing.Color.White;
            this.textbox_tm2.Location = new System.Drawing.Point(-1, 1);
            this.textbox_tm2.Multiline = true;
            this.textbox_tm2.Name = "textbox_tm2";
            this.textbox_tm2.Size = new System.Drawing.Size(346, 44);
            this.textbox_tm2.TabIndex = 1;
            this.textbox_tm2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_tm2.TextChanged += new System.EventHandler(this.textbox_tm2_TextChanged);
            // 
            // textbox_tm1
            // 
            this.textbox_tm1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_tm1.Enabled = false;
            this.textbox_tm1.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textbox_tm1.ForeColor = System.Drawing.Color.White;
            this.textbox_tm1.Location = new System.Drawing.Point(-1, 51);
            this.textbox_tm1.Multiline = true;
            this.textbox_tm1.Name = "textbox_tm1";
            this.textbox_tm1.Size = new System.Drawing.Size(346, 291);
            this.textbox_tm1.TabIndex = 0;
            this.textbox_tm1.TextChanged += new System.EventHandler(this.textbox_tm1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "关";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 355);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textbox_tm2);
            this.Controls.Add(this.textbox_tm1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinFormsApp1.textbox_tm textbox_tm1;
        private WinFormsApp1.textbox_tm textbox_tm2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

