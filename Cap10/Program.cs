using Cap10.Exercise01.Entities;
using Cap10.Exercise02.Entities;
using Cap10.Exercise03.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Cap10
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise03();
        }

        private static void Exercise01()
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int numberOfEmployess = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfEmployess; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours Worked: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (outsourced == 'y')
                {
                    Console.Write("Aditional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Payments:");

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Name + " - $ " + employee.Payment().ToString("f2", CultureInfo.InvariantCulture));
            }
        }

        private static void Exercise02()
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfProducts; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeOfProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (typeOfProduct == 'u')
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (typeOfProduct == 'i')
                {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Price Tags:");

            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }

        private static void Exercise03()
        {
            List<Taxpayer> taxpayers = new List<Taxpayer>();

            Console.Write("Enter the number of taxpayers: ");
            int numberOfTaxpayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfTaxpayers; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter Taxpayer #{i} Data:");
                Console.Write("Natual Person or Legal Person (n/l)? ");
                char typeOfPerson = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (typeOfPerson == 'n')
                {
                    Console.Write("Health Expenses: ");
                    double healthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxpayers.Add(new NaturalPerson(name, annualIncome, healthExpenses));
                }
                else if (typeOfPerson == 'l')
                {
                    Console.Write("Number of Employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxpayers.Add(new LegalPerson(name, annualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Taxes Paid:");
            double taxesSum = 0;
            foreach (Taxpayer taxpayer in taxpayers)
            {
                Console.WriteLine(taxpayer.Name + ": $ " + taxpayer.DueTax().ToString("f2", CultureInfo.InvariantCulture));
                taxesSum += taxpayer.DueTax();
            }
            Console.WriteLine();
            Console.WriteLine("Total Taxes: " + taxesSum.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
