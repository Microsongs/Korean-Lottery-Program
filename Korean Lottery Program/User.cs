using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korean_Lottery_Program
{
    class User
    {
        List<Lottery> myLotto = new List<Lottery>();    //나의 로또 리스트
        int myMoney;  //돈
        public User()
        {
            myMoney = 0;
        }
        public List<Lottery> MyLotto
        {
            get { return myLotto; }
        }
        public int MyMoney
        {
            get { return myMoney; }
            set { myMoney += value; }
        }
        public void AddMoney(int money)
        {
            myMoney += 1000;
        }
        public bool buyLottery(int n)
        {
            if (myMoney < (n * 1000))   //돈이 없는 경우 false 반환
            {
                return false;
            }
            for(int i=0; i<n; i++)
            {
                myMoney -= 1000;
                Lottery lottery = new Lottery();
                myLotto.Add(lottery);
            }
            return true;
        }
    }
}
