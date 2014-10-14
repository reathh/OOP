using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Bank_of_Kurtovo_Konare
{
    class _DemoBankKonare
    {
        static void Main(string[] args)
        {
            Deposit depo = new Deposit(Customer.Individual, 12112m, 3.4m);
            Console.WriteLine(depo.Balance);
            depo.DepositMoney(100m);
            Console.WriteLine(depo.Balance);
            depo.Withdraw(1000m);
            Console.WriteLine(depo.Balance);
        }
    }
}
