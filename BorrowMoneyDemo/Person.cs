using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyRecordPractice
{
    class Person
    {
        public string Name;
        public int Money;

        public Person(string Name, int Money)
        {
            this.Name = Name;
            this.Money = Money;
        }

        public void Borrow(Person lender,int money)
        {
            if (lender.Money >= money)
            {
            lender.Money -= money;
            this.Money += money;
            }

        }

        public void PayBack(Person lender, int money)
        {
            if (this.Money >= money)
            {
            this.Money -= money;
            lender.Money += money;
            }

        }
    }
}
