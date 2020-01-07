namespace SampleAppConfigUse
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtConfigInfo = new System.Windows.Forms.TextBox();
            this.btnConfigInfo = new System.Windows.Forms.Button();
            this.btnConnString = new System.Windows.Forms.Button();
            this.txtConnString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtConfigInfo
            // 
            this.txtConfigInfo.Location = new System.Drawing.Point(25, 132);
            this.txtConfigInfo.Name = "txtConfigInfo";
            this.txtConfigInfo.Size = new System.Drawing.Size(625, 25);
            this.txtConfigInfo.TabIndex = 7;
            //this.txtConfigInfo.TextChanged += new System.EventHandler(this.txtConfigInfo_TextChanged);
            // 
            // btnConfigInfo
            // 
            this.btnConfigInfo.Location = new System.Drawing.Point(656, 109);
            this.btnConfigInfo.Name = "btnConfigInfo";
            this.btnConfigInfo.Size = new System.Drawing.Size(105, 48);
            this.btnConfigInfo.TabIndex = 6;
            this.btnConfigInfo.Text = "설정정보AppConfig";
            this.btnConfigInfo.UseVisualStyleBackColor = true;
            this.btnConfigInfo.Click += new System.EventHandler(this.btnConfigInfo_Click);
            // 
            // btnConnString
            // 
            this.btnConnString.Location = new System.Drawing.Point(656, 54);
            this.btnConnString.Name = "btnConnString";
            this.btnConnString.Size = new System.Drawing.Size(105, 23);
            this.btnConnString.TabIndex = 5;
            this.btnConnString.Text = "연결문자열";
            this.btnConnString.UseVisualStyleBackColor = true;
            this.btnConnString.Click += new System.EventHandler(this.btnConnString_Click);
            // 
            // txtConnString
            // 
            this.txtConnString.Location = new System.Drawing.Point(25, 55);
            this.txtConnString.Name = "txtConnString";
            this.txtConnString.Size = new System.Drawing.Size(625, 25);
            this.txtConnString.TabIndex = 4;
            //this.txtConnString.TextChanged += new System.EventHandler(this.txtConnString_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtConfigInfo);
            this.Controls.Add(this.btnConfigInfo);
            this.Controls.Add(this.btnConnString);
            this.Controls.Add(this.txtConnString);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfigInfo;
        private System.Windows.Forms.Button btnConfigInfo;
        private System.Windows.Forms.Button btnConnString;
        private System.Windows.Forms.TextBox txtConnString;
    }
}

