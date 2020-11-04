using System;
using System.Collections.Generic;
using System.Text;

namespace BIgmama_uml_3
{
   public class Pizza : MenuItem
   {
       private bool _deepPan;

       public bool DeepPan
       {
           get { return _deepPan; }
           set { _deepPan = value; }
       }
       public Pizza(int number, string name, string description, double price, MenuType menuType, bool isVegan, bool isOrganic, bool deepPan) : base(number, name, description, price, menuType, isVegan, isOrganic)
        {
            _deepPan = deepPan;
        }
        public override string PrintInfo()
        {
            return base.PrintInfo() + " " + $"DeepPan {DeepPan}";
        }
   }
}
