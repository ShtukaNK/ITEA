using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void SpendingAction (ISpendable spendable)
        {
            spendable.Spend();
        }

        static void Main(string[] args)
        {
            Client client = new Client("Kate", 200);
            client.Put(30);
            Console.WriteLine("Катя положила на счет 30 грн, стало " + client.CurrentSum);
            client.Withdraw(100);
            Console.WriteLine("Моня втюхал Кате услугу банка в размере 100 грн, стало " + client.CurrentSum);
            Banker employee = new Banker("Monya", "Consultant");
            client.Display();
            employee.Display();
            Money money = new Money();
            SpendingAction(money);
            Console.ReadKey();
        }
    }
}
