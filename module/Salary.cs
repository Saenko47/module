using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module
{
    internal class Salary: Person
    {
        public int Id { get; set; }
        public decimal AmountFirst { get; set; }
        public decimal AmountSecond { get; set; }
        public Salary() { }

        public Salary(int workerId, decimal AmountFirst, decimal AmountSecond)
        {
            this.Id = workerId;
            this.AmountFirst = AmountFirst;
            this.AmountSecond = AmountSecond;
        }
    }
}
