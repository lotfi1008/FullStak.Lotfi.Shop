using FullStak.Lotfi.Shop.Core.Contracts.Repositories;
using FullStak.Lotfi.Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStak.Lotfi.Shop.UI
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }
        public void AddNewCusmtomer()
        {
            Console.WriteLine("Adding New Customer ...!");
            Customer customer = new Customer();

            Console.Write("PLease Enter UserName:");
            customer.UserName = Console.ReadLine();
            Console.Write("PLease Enter FirstName:");
            customer.FirstName = Console.ReadLine();
            Console.Write("PLease Enter LastName:");
            customer.LastName = Console.ReadLine();
            Console.Write("PLease Enter Email:");
            customer.Email = Console.ReadLine();

            try
            {
                _customerRepository.Insert(customer);
                Console.WriteLine("Customer Added ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        public void ModifyCusmtomer()
        {
            throw new NotImplementedException();
        }

        public void DeleteCusmtomer()
        {
            Console.WriteLine("Delete Customer ...");
            var customers = _customerRepository.Get();
            foreach (var customer in customers)
            {
                Console.WriteLine($"id: {customer.CustomerId} - FName:{customer.FirstName} - FName:{customer.LastName} - EMail:{customer.Email}");
            }
            Console.Write("Please Enter customer ID:");
            int id = int.Parse(Console.ReadLine());
            try
            {
                _customerRepository.Delete(id);
                Console.WriteLine("Customer Deleted");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :"+ex.Message);
            }
            Console.WriteLine("Press eny key to continue");
            Console.ReadKey();
        }

        public void ShowAllCusmtomer()
        {
            Console.WriteLine("Show All Customers ...");
            var customers = _customerRepository.Get();
            foreach (var customer in customers)
            {
                Console.WriteLine($"id: {customer.CustomerId} - FName:{customer.FirstName} - FName:{customer.LastName} - EMail:{customer.Email}");
            }
            Console.WriteLine("Press eny key to continue");
            Console.ReadKey();
        }
    }
}
