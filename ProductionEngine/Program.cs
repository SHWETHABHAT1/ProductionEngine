using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.WriteLine("Enter the number of products");
            int t = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<t;i++)
            {
                Console.WriteLine("Enter the type of product, 'A','B','C' or 'D'");
                string prdname = Console.ReadLine();
                Product prod = new Product();
                prod.productName = prdname;
                GetPriceByType(prod);
                products.Add(prod);
            }
            int final=GetTotalPrice(products);
            Console.WriteLine("The Amount is ", final);
            Console.ReadKey();
        }

        public static void GetPriceByType(Product product)
        {
            switch (product.productName)
            {
                case "A":
                    product.productPrice = 50m;

                    break;
                case "B":
                    product.productPrice = 30m;

                    break;
                case "C":
                    product.productPrice = 20m;

                    break;
                case "D":
                    product.productPrice = 2015m;
                    break;
            }
        }
        public static int GetTotalPrice(List<Product> products)
        {
            int countA = 0;
            int priceOfA = 50;
            int countB = 0;
            int priceOfB = 30;
            int countC = 0;
            int priceOfC = 20;
            int countD = 0;
            int priceOfD = 15;

            foreach (Product pr in products)
            {
                switch (pr.productName)
                {
                    case "A":
                    case "a":
                        countA += 1;
                        break;
                    case "B":
                    case "b":
                        countB += 1;
                        break;
                    case "C":
                    case "c":
                        countC += 1;
                        break;
                    case "D":
                    case "d":
                        countD += 1;
                        break;
                }
            }
            int totalPriceOfA = (countA / 3) * 130 + (countA % 3 * priceOfA);
            int totalPriceOfB = (countB / 2) * 45 + (countB % 2 * priceOfB);
            int commonamt = 0;
            if (countC>=1 && countD>=1)
            {
                if (countC > countD)
                {
                     commonamt = (countD * 30) + (countC - countD)*priceOfC;
                }
                else if(countD>countC)
                {
                    commonamt = (countC * 30) + (countD - countC) * priceOfD;
                }
                else if(countD==countC)
                {
                    commonamt = (countC * 30);
                }
            }
            else
            {
                commonamt= (countC * priceOfC)+ (countD * priceOfD);
            }
            int final = totalPriceOfA + totalPriceOfB + commonamt;
            return final;
        }
    }
}
