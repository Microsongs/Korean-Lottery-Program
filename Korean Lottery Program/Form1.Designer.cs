namespace Korean_Lottery_Program
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
            this.myCoin = new System.Windows.Forms.Label();
            this.buyLottery = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.coinImage = new System.Windows.Forms.Panel();
            this.chargeButton = new System.Windows.Forms.Button();
            this.buyList = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myCoin
            // 
            this.myCoin.AutoSize = true;
            this.myCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCoin.Location = new System.Drawing.Point(938, 48);
            this.myCoin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myCoin.Name = "myCoin";
            this.myCoin.Size = new System.Drawing.Size(46, 51);
            this.myCoin.TabIndex = 1;
            this.myCoin.Text = "0";
            this.myCoin.Click += new System.EventHandler(this.myCoin_Click);
            // 
            // buyLottery
            // 
            this.buyLottery.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyLottery.Location = new System.Drawing.Point(909, 253);
            this.buyLottery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyLottery.Name = "buyLottery";
            this.buyLottery.Size = new System.Drawing.Size(190, 52);
            this.buyLottery.TabIndex = 2;
            this.buyLottery.Text = "로또 구매";
            this.buyLottery.UseVisualStyleBackColor = true;
            this.buyLottery.Click += new System.EventHandler(this.buyLottery_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(55, 31);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(102, 55);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "결과";
            // 
            // coinImage
            // 
            this.coinImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.coinImage.BackgroundImage = global::Korean_Lottery_Program.Properties.Resources.goldcoin;
            this.coinImage.Location = new System.Drawing.Point(824, 21);
            this.coinImage.Margin = new System.Windows.Forms.Padding(4);
            this.coinImage.Name = "coinImage";
            this.coinImage.Size = new System.Drawing.Size(106, 104);
            this.coinImage.TabIndex = 0;
            // 
            // chargeButton
            // 
            this.chargeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargeButton.Location = new System.Drawing.Point(905, 142);
            this.chargeButton.Name = "chargeButton";
            this.chargeButton.Size = new System.Drawing.Size(194, 82);
            this.chargeButton.TabIndex = 4;
            this.chargeButton.Text = "잔액 충전";
            this.chargeButton.UseVisualStyleBackColor = true;
            this.chargeButton.Click += new System.EventHandler(this.chargeButton_Click);
            // 
            // buyList
            // 
            this.buyList.AutoSize = true;
            this.buyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyList.Location = new System.Drawing.Point(346, 119);
            this.buyList.Name = "buyList";
            this.buyList.Size = new System.Drawing.Size(232, 55);
            this.buyList.TabIndex = 5;
            this.buyList.Text = "구매 리스트";
            // 
            // resultButton
            // 
            this.resultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultButton.Location = new System.Drawing.Point(666, 31);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(151, 85);
            this.resultButton.TabIndex = 6;
            this.resultButton.Text = "결과 확인";
            this.resultButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 708);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.buyList);
            this.Controls.Add(this.chargeButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.buyLottery);
            this.Controls.Add(this.myCoin);
            this.Controls.Add(this.coinImage);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel coinImage;
        private System.Windows.Forms.Label myCoin;
        private System.Windows.Forms.Button buyLottery;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button chargeButton;
        private System.Windows.Forms.Label buyList;
        private System.Windows.Forms.Button resultButton;
    }
}

