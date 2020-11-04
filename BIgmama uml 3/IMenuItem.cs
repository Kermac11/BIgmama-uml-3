using System;
using System.Collections.Generic;
using System.Text;

namespace BIgmama_uml_3
{
    public enum MenuType { Pizza, Pasta, Topping, SoftDrink, AlcoholicDrink, Sandwich }
    public interface IMenuItem
    {
        int Number { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set; }
        MenuType Type { get; set; }
        bool IsVegan { get; set; }
        bool IsOrganic { get; set; }
        string PrintInfo();
    }

}
