using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korean_Lottery_Program
{
    class Lottery
    {
        int[] lottoNumber = new int[6];
        Random random;
        public Lottery()    //생성자
        {
            random = new Random();
            int temp;
            for(int i=0; i<6; i++)
            {
                temp = random.Next(1,45);
                if(isEquals(temp,i) == true)
                {
                    lottoNumber[i] = temp;
                }
                else
                {
                    i--;
                    continue;
                }
            }
        }
        private bool isEquals(int num, int loc) //중복 숫자 체크
        {
            for(int i=0; i<loc; i++)
            {
                if (num == lottoNumber[i])
                    return false;
            }
            return true;
        }
        public int[] LottoNumber    //로또 배열 반환 프로퍼티
        {
            get { return lottoNumber; }
        }
    }
}
