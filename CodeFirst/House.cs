using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirst
{
    public class House
    {
        
        public int Id { get; set; }
        public int price { get; set; }
        public string city { get; set; }
        public int downPayment { get; set; }
        public int loanLength { get; set; }
        public double monthlyPayment { get; set; }

        public virtual ICollection<House> Houses { get; set; }

    }
}
