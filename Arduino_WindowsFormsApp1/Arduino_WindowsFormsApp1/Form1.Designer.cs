namespace Arduino_WindowsFormsApp1
{
    partial class Form1
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
            this.ButtonOn = new System.Windows.Forms.Button();
            this.ButtonOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonOn
            // 
            this.ButtonOn.Location = new System.Drawing.Point(64, 133);
            this.ButtonOn.Name = "ButtonOn";
            this.ButtonOn.Size = new System.Drawing.Size(217, 102);
            this.ButtonOn.TabIndex = 0;
            this.ButtonOn.Text = "ON";
            this.ButtonOn.UseVisualStyleBackColor = true;
            this.ButtonOn.Click += new System.EventHandler(this.ButtonOn_Click);
            // 
            // ButtonOff
            // 
            this.ButtonOff.Location = new System.Drawing.Point(334, 133);
            this.ButtonOff.Name = "ButtonOff";
            this.ButtonOff.Size = new System.Drawing.Size(217, 102);
            this.ButtonOff.TabIndex = 0;
            this.ButtonOff.Text = "OFF";
            this.ButtonOff.UseVisualStyleBackColor = true;
            this.ButtonOff.Click += new System.EventHandler(this.ButtonOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 370);
            this.Controls.Add(this.ButtonOff);
            this.Controls.Add(this.ButtonOn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonOn;
        private System.Windows.Forms.Button ButtonOff;
    }
}

