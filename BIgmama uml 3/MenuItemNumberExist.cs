using System;
using System.Collections.Generic;
using System.Text;

namespace BIgmama_uml_3
{
    public class MenuItemNumberExist : Exception
    {
        public MenuItemNumberExist()
        {
        }

        public MenuItemNumberExist(string message) : base(message)
        {

        }
    }
}
