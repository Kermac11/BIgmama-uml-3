using System;
using System.Collections.Generic;
using System.Text;

namespace BIgmama_uml_3
{
    public class Customer : ICustomer
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string PhoneNo { get; set; }

        public Customer(int id, string name, string adress, string phoneNo)
        {
            Id = id;
            Name = name;
            Adress = adress;
            PhoneNo = phoneNo;
        }

    }
}