using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class bankAccount
    {
        public void humaneSocietyAccount(int income)
        {
            fileWriter moneyBalance = new fileWriter();
            moneyBalance.bankAccount(income);
        }
        public int getMoney()
        {
            int balance;
            fileReader retrieve = new fileReader();
            balance = retrieve.loadMoney();
            return balance;
        }
    }
}
