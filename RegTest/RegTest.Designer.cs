namespace RegTest
{
    partial class RegTest
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
            this.lbSrcText = new System.Windows.Forms.Label();
            this.tbSrc = new System.Windows.Forms.TextBox();
            this.lbReg = new System.Windows.Forms.Label();
            this.tbReg = new System.Windows.Forms.TextBox();
            this.lbMatch = new System.Windows.Forms.Label();
            this.tbMatch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbSrcText
            // 
            this.lbSrcText.AutoSize = true;
            this.lbSrcText.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSrcText.Location = new System.Drawing.Point(12, 9);
            this.lbSrcText.Name = "lbSrcText";
            this.lbSrcText.Size = new System.Drawing.Size(110, 31);
            this.lbSrcText.TabIndex = 0;
            this.lbSrcText.Text = "源文本：";
            // 
            // tbSrc
            // 
            this.tbSrc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSrc.Location = new System.Drawing.Point(127, 7);
            this.tbSrc.Name = "tbSrc";
            this.tbSrc.Size = new System.Drawing.Size(912, 34);
            this.tbSrc.TabIndex = 1;
            this.tbSrc.TextChanged += new System.EventHandler(this.tbTextChanged);
            // 
            // lbReg
            // 
            this.lbReg.AutoSize = true;
            this.lbReg.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbReg.Location = new System.Drawing.Point(12, 53);
            this.lbReg.Name = "lbReg";
            this.lbReg.Size = new System.Drawing.Size(110, 31);
            this.lbReg.TabIndex = 0;
            this.lbReg.Text = "正　则：";
            // 
            // tbReg
            // 
            this.tbReg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbReg.Location = new System.Drawing.Point(127, 51);
            this.tbReg.Name = "tbReg";
            this.tbReg.Size = new System.Drawing.Size(912, 34);
            this.tbReg.TabIndex = 1;
            this.tbReg.TextChanged += new System.EventHandler(this.tbTextChanged);
            // 
            // lbMatch
            // 
            this.lbMatch.AutoSize = true;
            this.lbMatch.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMatch.Location = new System.Drawing.Point(12, 97);
            this.lbMatch.Name = "lbMatch";
            this.lbMatch.Size = new System.Drawing.Size(110, 31);
            this.lbMatch.TabIndex = 0;
            this.lbMatch.Text = "匹　配：";
            // 
            // tbMatch
            // 
            this.tbMatch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMatch.Location = new System.Drawing.Point(18, 131);
            this.tbMatch.Multiline = true;
            this.tbMatch.Name = "tbMatch";
            this.tbMatch.Size = new System.Drawing.Size(1022, 570);
            this.tbMatch.TabIndex = 1;
            // 
            // RegTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 713);
            this.Controls.Add(this.tbMatch);
            this.Controls.Add(this.lbMatch);
            this.Controls.Add(this.tbReg);
            this.Controls.Add(this.lbReg);
            this.Controls.Add(this.tbSrc);
            this.Controls.Add(this.lbSrcText);
            this.Name = "RegTest";
            this.Text = "RegTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSrcText;
        private System.Windows.Forms.TextBox tbSrc;
        private System.Windows.Forms.Label lbReg;
        private System.Windows.Forms.TextBox tbReg;
        private System.Windows.Forms.Label lbMatch;
        private System.Windows.Forms.TextBox tbMatch;
    }
}

