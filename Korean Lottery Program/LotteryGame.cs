using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korean_Lottery_Program
{
    class LotteryGame
    {
        Lottery lottery;
        public LotteryGame()
        {
            lottery = new Lottery();
        }
        public Lottery Result
        {
            get { return lottery; }
        }
    }
}
