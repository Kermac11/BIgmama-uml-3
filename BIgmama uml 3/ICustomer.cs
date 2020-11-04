using System;
using System.Collections.Generic;
using System.Text;

namespace BIgmama_uml_3
{
   public interface ICustomer
    {
            int Id { get; }
            string Name { get; set; }
            string Adress { get; set; }
            string PhoneNo { get; set; }
   }

}
