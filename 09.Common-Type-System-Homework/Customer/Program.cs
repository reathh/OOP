using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer peshko = new Customer("Peshko", "Peshkanov", "Peshkov", "7604306423", "Hadji dimitar 32", "0879412364", "peshko@peshko.com", new List<Payment>() {
                new Payment("furna", 132.3m),
                new Payment("hladilnik", 322.5m),
                new Payment("mikrovulnowa", 75.2m)
            }, CustomerType.Golden);

            Customer peshko1 = new Customer("Peshko", "Peshkanov", "Peshkov", "7604306423", "Hadji dimitar 32", "0879412364", "peshko@peshko.com", new List<Payment>() {
                new Payment("furna", 132.3m),
                new Payment("hladilnik", 322.5m),
                new Payment("mikrovulnowa", 75.2m)
            }, CustomerType.Golden);

            Customer goshko = new Customer("Goshko", "Goshkanov", "Goshkov", "734534843", "Bul. Bulgaria 354", "098341231", "goshkancheto@goshk0.c0m", new List<Payment>() {
                new Payment("Nvidia GTX 880", 1032.4m),
                new Payment("Intel Core i7 4870", 650.21m),
            }, CustomerType.OneTime);

            Console.WriteLine(peshko.Equals(peshko1));
            Console.WriteLine(peshko != goshko);

            Console.WriteLine(peshko);
            Customer peshko2 = (Customer)peshko.Clone();
            peshko2.FirstName = "PromenenPeshkov";
            Console.WriteLine(peshko2.FirstName);
            Console.WriteLine(peshko.FirstName);

            Console.WriteLine(peshko.CompareTo(goshko));
            Console.WriteLine(goshko.CompareTo(peshko));


        }

    }
}
