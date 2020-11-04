using System;
using System.Collections.Generic;
using System.Text;

namespace BIgmama_uml_3
{
    public class MenuItemDoesNotExist : Exception
    {
        public MenuItemDoesNotExist()
        {

        }

        public MenuItemDoesNotExist(string message) : base(message)
        {

        }
    }
}
