using System;
using System.Collections.Generic;
using System.Text;

namespace BIgmama_uml_3
{
    public class Sandwich : MenuItem
    {
        public enum Meat
        {
            Beef, Chicken
        }

        private readonly Meat _meat;

        public Meat TypeMeat
        {
            get { return _meat; }
        }

        public Sandwich(int number, string name, string description, double price, MenuType menuType, bool isVegan, bool isOrganic, Meat meat) : base(number, name, description, price, menuType, isVegan, isOrganic)
        {
            _meat = meat;
        }
        public override string PrintInfo()
        {
            return base.PrintInfo() +" " + $"Meat {TypeMeat}";
        }
    }
}
