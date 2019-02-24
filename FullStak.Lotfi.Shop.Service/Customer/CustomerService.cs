using FullStak.Lotfi.Shop.Core.Contracts.Repositories;
using FullStak.Lotfi.Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStak.Lotfi.Shop.Service.CustomerSrc
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
    }
}
