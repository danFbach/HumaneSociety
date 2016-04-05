using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class bankAccount
    {
        public int totalMoney = 500;
        public bankAccount()
        {
        }
        public void humaneSocietyAccount(int income)
        {
            totalMoney += income;
        }
    }
}
