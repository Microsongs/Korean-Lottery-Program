using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korean_Lottery_Program
{
    public partial class Form1 : Form
    {
        int width, height;  //좌/우
        User user;
        public Form1()
        {
            InitializeComponent();
            user = new User();
            MyInitialize();
        }
        private void MyInitialize()
        {
            myCoin.Text = user.MyMoney.ToString();
            width = 50;
            height = 50;
        }

        private void buyLottery_Click(object sender, EventArgs e)
        {
            if (user.buyLottery(1) == false)
            {
                MessageBox.Show("잔액 없음!");
            }
            else
            {
                MessageBox.Show("구매 완료!");
                showList();
            }
        }
        private void showList()
        {
            Lottery data = user.MyLotto[user.MyLotto.Count - 1];
            for (int i = 0; i < 6; i++)
            {
                
            }
            myCoin.Text = user.MyMoney.ToString();
        }

        private void chargeButton_Click(object sender, EventArgs e)
        {
            user.AddMoney(1000);
            MessageBox.Show("잔액 충전!");
            myCoin.Text = user.MyMoney.ToString();
            Debug.WriteLine(user.MyMoney);
        }

        private void myCoin_Click(object sender, EventArgs e)
        {

        }
    }
}
