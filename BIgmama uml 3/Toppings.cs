using System;
using System.Collections.Generic;
using System.Text;

namespace BIgmama_uml_3
{
    class Toppings : MenuItem
    {
        public Toppings(int number, string name, string description, double price, MenuType menuType, bool isVegan, bool isOrganic) : base(number, name, description, price, menuType, isVegan, isOrganic)
        {
        }
    }
}
