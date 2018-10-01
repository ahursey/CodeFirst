using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new HouseContext())
            {
                Console.WriteLine("Enter a house price.");
                var price = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter house city.");
                var location = Console.ReadLine();

                Console.WriteLine("Enter a down payment value.");
                var downPayment = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a loan length (in years).");
                var loanLength = Convert.ToInt32(Console.ReadLine());

                var monthlyPayment = (price - downPayment) / (12 * loanLength);

                var house = new House { price = price, city = location, downPayment = downPayment, loanLength = loanLength, monthlyPayment = monthlyPayment };

                
                db.Houses.Add(house);
                db.SaveChanges();

                Console.WriteLine("Thank you. Here is the list of added entries:");

                var query = from x in db.Houses orderby x.Id select x;
                foreach (var item in query)
                {
                    Console.WriteLine("$" + house.price + " in the city of " + house.city + ". With a downpayment of " + house.downPayment + " and loan length of " + house.loanLength + " years it would cost $" + house.monthlyPayment + " each month.");
                }

                Console.WriteLine("Press any key to exit.");
                Console.ReadLine();
            }
            

        }
    }
}
