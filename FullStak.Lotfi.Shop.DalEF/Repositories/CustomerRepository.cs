using FullStak.Lotfi.Shop.Core.Contracts.Repositories;
using FullStak.Lotfi.Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FullStak.Lotfi.Shop.DalEF.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly StoreContext _storeContext;

        public CustomerRepository(StoreContext storeContext)
        {
            this._storeContext = storeContext;
        }

        #region Command
        public Customer Delete(int id)
        {
            var customer = _storeContext.Customers.Find(id);
            var result = _storeContext.Customers.Remove(customer);
            _storeContext.SaveChanges();
            return result.Entity;
        }
        public Customer Delete(Customer customer)
        {
            var result = _storeContext.Customers.Remove(customer);
            _storeContext.SaveChanges();
            return result.Entity;

        }
        public Customer Insert(Customer customer)
        {
            var result = _storeContext.Customers.Add(customer);
            _storeContext.SaveChanges();
            return result.Entity;

        }
        public Customer Update(Customer customer)
        {
            var result = _storeContext.Customers.Update(customer);
            _storeContext.SaveChanges();
            return result.Entity;
        }
        #endregion

        #region Query
        public ICollection<Customer> Get()
        {
            return _storeContext.Customers.ToList();
        }
        public ICollection<Customer> Get(Func<Customer, bool> condition)
        {
            return _storeContext.Customers.Where(condition).ToList();
        }
        public Customer GetById(int id)
        {
            return _storeContext.Customers.Where(c => c.CustomerId == id).FirstOrDefault();
        }
        #endregion
    }
}
