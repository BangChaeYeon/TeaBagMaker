namespace TeaBagMaker
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
            this.components = new System.ComponentModel.Container();
            this.teaComboBox = new System.Windows.Forms.ComboBox();
            this.countDownBtn = new System.Windows.Forms.Button();
            this.timeTxt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teaComboBox
            // 
            this.teaComboBox.FormattingEnabled = true;
            this.teaComboBox.Location = new System.Drawing.Point(14, 14);
            this.teaComboBox.Name = "teaComboBox";
            this.teaComboBox.Size = new System.Drawing.Size(225, 22);
            this.teaComboBox.TabIndex = 0;
            this.teaComboBox.SelectedIndexChanged += new System.EventHandler(this.TeaComboBox_SelectedIndexChanged);
            // 
            // countDownBtn
            // 
            this.countDownBtn.Font = new System.Drawing.Font("나눔고딕OTF", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.countDownBtn.Location = new System.Drawing.Point(12, 44);
            this.countDownBtn.Name = "countDownBtn";
            this.countDownBtn.Size = new System.Drawing.Size(223, 92);
            this.countDownBtn.TabIndex = 1;
            this.countDownBtn.Text = "담그기!";
            this.countDownBtn.UseVisualStyleBackColor = true;
            this.countDownBtn.Click += new System.EventHandler(this.CountDownBtn_Click);
            // 
            // timeTxt
            // 
            this.timeTxt.AutoSize = true;
            this.timeTxt.Font = new System.Drawing.Font("나눔고딕OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeTxt.Location = new System.Drawing.Point(12, 140);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(108, 24);
            this.timeTxt.TabIndex = 2;
            this.timeTxt.Text = "남은 시간: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "2019-05-31 3108 방채연";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 236);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeTxt);
            this.Controls.Add(this.countDownBtn);
            this.Controls.Add(this.teaComboBox);
            this.Font = new System.Drawing.Font("나눔고딕OTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teaComboBox;
        private System.Windows.Forms.Button countDownBtn;
        private System.Windows.Forms.Label timeTxt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

