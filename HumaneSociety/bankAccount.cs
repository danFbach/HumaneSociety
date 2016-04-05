using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class bankAccount
    {
        int totalMoney;
        public bankAccount()
        {
        }
        public void humaneSocietyAccount(int income)
        {
            totalMoney += income;
        }
    }
}
