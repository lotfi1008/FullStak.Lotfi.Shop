using System;

namespace FullStak.Lotfi.Shop.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while (input!="4")
            {
                ShowMainMenu();
                Console.Write("Please Enter Your Operation Number:");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1": ManageCustomers();break;
                    case "2": ManageProduct(); break;
                    case "3": break;
                    default:
                        Console.WriteLine("Invalid Input...!");
                        break;
                }
            }
        }

        private static void ManageProduct()
        {
            string input = "";
            while (input != "9")
            {
                ShowProductMenu();
                Console.Write("Please Enter Your Operation Number:");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1": break;
                    case "2": break;
                    case "3": break;
                    case "4": break;
                    case "5": break;
                    case "6": break;
                    case "7": break;
                    case "8": break;
                    default:
                        Console.WriteLine("Invalid Input...!");
                        break;
                }
            }
        }
        private static void ShowProductMenu()
        {
            Console.Clear();
            Console.WriteLine("Product Manager ...");
            Console.WriteLine("--------------------");
            Console.WriteLine("1-Add Product");
            Console.WriteLine("2-Update Product");
            Console.WriteLine("3-Delete Product ");
            Console.WriteLine("4-Show All Product");
            Console.WriteLine("5-Add Category");
            Console.WriteLine("6-Update Category");
            Console.WriteLine("7-Delete Category ");
            Console.WriteLine("8-Show All Category");
            Console.WriteLine("9-------Back To Main");
            Console.WriteLine("--------------------");
        }

        private static void ManageCustomers()
        {
            string input = "";
            while (input != "5")
            {
                ShowCustomerMenu();
                Console.Write("Please Enter Your Operation Number:");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1": break;
                    case "2": break;
                    case "3": break;
                    case "4": break;
                    default:
                        Console.WriteLine("Invalid Input...!");
                        break;
                }
            }
        }

        private static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("1-Customer Manager");
            Console.WriteLine("2-Product Manager");
            Console.WriteLine("3-Shopping");
            Console.WriteLine("4-Exit");
            Console.WriteLine("--------------------");
        }
        private static void ShowCustomerMenu()
        {
            Console.Clear();
            Console.WriteLine("Customer Manager ...");
            Console.WriteLine("--------------------");
            Console.WriteLine("1-Add");
            Console.WriteLine("2-Update");
            Console.WriteLine("3-Delete");
            Console.WriteLine("4-Show All");
            Console.WriteLine("5-------Back To Main");
            Console.WriteLine("--------------------");
        }
    }
}
