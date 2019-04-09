using FullStak.Lotfi.Shop.Entities;
using System;
using System.Collections.Generic;

namespace FullStak.Lotfi.Shop.Contracts.Repositories
{
    public interface ICustomerRepository
    {
        ICollection<Customer> Get();
        ICollection<Customer> Get(Func<Customer,bool> condition);
        Customer GetById(int id);
        Customer Insert(Customer customer);
        Customer Update(Customer customer);
        Customer Delete(int id);
        Customer Delete(Customer customer);
    }
}
