using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCar
{
    internal class Program
    {

        public static double[] vehicles = new double[31];
        //   To find coorporate sales gien no. of days
        public static double count(int num)
        {
            double CorporateSales = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 5 == 0)
                {
                    CorporateSales += vehicles[i - 1];
                }

            }
            return CorporateSales;
        }
        //   To find retail sales gien no. of days
        public static double count2(int num)
        {
            double RetailSales = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 5 != 0)
                {
                    RetailSales += vehicles[i - 1];
                }

            }
            return RetailSales;
        }
        static void Main(string[] args)
        {


            string[] Months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            vehicles[0] = 1;
            for (int i = 1; i < 31; i++)
            {
                vehicles[i] = vehicles[i - 1] + 2 * i;
                // Console.Write(vehicals[i]+" ");
            }
            Console.WriteLine();
            double month31Retail = count2(31);
            double month31Cor = count(31);
            double month30Retail = count2(30);
            double month30Cor = count(30);



            // a
            // Number of Vehicles sold each month
            Console.WriteLine("Number of Vehicles sold each month");
            for (int i = 3; i < 9; i++)
            {
                if (i == 4 || i == 6 || i == 7)
                {
                    Console.WriteLine($"{Months[i]}        Retail-   {month31Retail}          Corporate-  {month31Cor}     Total-   {month31Retail + month31Cor}");
                }
                else
                {
                    Console.WriteLine($"{Months[i]}        Retail-   {month30Retail}          Corporate-  {month30Cor}      Total-   {month30Retail + month30Cor}");

                }
            }
            Console.WriteLine();
            // b
            // Number of Vehicles sold to Retail Customers
            Console.WriteLine("Number of Vehicles sold to Retail Customers");
            double AprilToSept1 = (month30Retail * 3) + (month31Retail * 3);

            // b
            double AprilToSept2 = (month31Cor * 3) + month30Cor * 3;
            Console.WriteLine($"AprilToSept retail     -    {AprilToSept1}");
            Console.WriteLine();
            Console.WriteLine("Number of Vehicles sold to Corporate Customers");
            Console.WriteLine($"AprilToSept Corporate  -    {AprilToSept2}");
            Console.WriteLine();
            Console.WriteLine("Number of Vehicles sold to Retail Customers");
            Console.WriteLine($"Total  AprilToSept     -    {AprilToSept2 + AprilToSept1}");
            Console.WriteLine();
            // c
            Console.WriteLine("Number of Vehicles sold b/w Aug15 and sept15");
            double retailAug = 0;
            double corAug = 0;
            for (int i = 14; i < 31; i++)
            {
                if (i == 14 || i == 19 || i == 24 || i == 29)
                {
                    corAug += vehicles[i];

                }
                else
                {
                    retailAug += vehicles[i];
                }
            }
            for (int i = 0; i < 15; i++)
            {
                if (i == 4 || i == 9 || i == 14)
                {
                    corAug += vehicles[i];

                }
                else
                {
                    retailAug += vehicles[i];
                }
            }

            Console.WriteLine($"Aug 15 to sept 15 Retaill    -   {retailAug}");
            Console.WriteLine($"Aug 15 to sept 15 Corporate  -   {corAug}");
            Console.WriteLine($"Aug 15 to sept 15 Total      -   {corAug + retailAug}");
        }
    }
}
