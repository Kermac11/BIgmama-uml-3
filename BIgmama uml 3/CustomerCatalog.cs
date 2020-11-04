using System;
using System.Collections.Generic;
using System.Text;

namespace BIgmama_uml_3
{
    public class CustomerCatalog : ICustomerCatalog
    {
       private readonly List<ICustomer>  customers;
       private int count = 0;

        public CustomerCatalog()
        {
            customers = new List<ICustomer>();
        }
        public int Count
        {
            get { return count; }
        }
        public void AddCustomer(ICustomer aCustomer)
        {
            customers.Add(aCustomer);
            count += 1;
        }

        public ICustomer LookupCustomerName(string name)
        {
            throw new NotImplementedException();
        }

        public ICustomer LookupCustomerID(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(string phoneNo, ICustomer theCustomer)
        {
            throw new NotImplementedException();
        }

        public void PrintCustomerList()
        {
            foreach (ICustomer customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
        }
    }
}
