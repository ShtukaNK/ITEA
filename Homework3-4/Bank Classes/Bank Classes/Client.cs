using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Client : AbsHuman, IAccount, IClient
    {
        //public int Sum { get; set; }

        //public Client(string name, int sum) : base(name)
        //{
        //    Sum = sum;
        //}

        int _sum;
        public string Name { get; set; }
        public Client(string name, int sum) : base(name)
        {
            Name = name;
            _sum = sum;
        }

        public int CurrentSum { get { return _sum; } }

        public void Put(int sum) { _sum += sum; }

        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
            }
        }

        public override void Display()
        {
            Console.WriteLine($"{Name} счет общей суммой {_sum}");
        }
    }
}