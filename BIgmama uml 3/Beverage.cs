using System;
using System.Collections.Generic;
using System.Text;

namespace BIgmama_uml_3
{
    public class Beverage : MenuItem
    {
        private bool _alcohol;

        public bool Alcohol
        {
            get { return _alcohol; }
            set { _alcohol = value; }
        }
        public Beverage(int number, string name, string description, double price, MenuType menuType, bool isVegan, bool isOrganic, bool alcohol) : base(number, name, description, price, menuType, isVegan, isOrganic)
        {
            _alcohol = alcohol;
        }
        public override string PrintInfo()
        {
            return base.PrintInfo() + " " + $"Alcoholic {Alcohol}";
        }
    }
}
