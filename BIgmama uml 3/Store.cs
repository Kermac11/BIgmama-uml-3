using System;

namespace BIgmama_uml_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenuItem p1 = new Pizza(2, "COMBAYA", "Masser af ost", 87, MenuType.Pizza, false, false, true);
            IMenuItem s1 = new Sandwich(1, "CHARLES", "God Mayonaise", 60, MenuType.Sandwich, false, true, Sandwich.Meat.Chicken);
            IMenuItem d1 = new Beverage(3, "Cola", "Sukker", 50, MenuType.SoftDrink, false, false, false);
            IMenuItem p2 = new Pizza(1,"BIG BERT" , "2 ananas" , 900, MenuType.Pizza, false, false , true);
            IMenuCatalog m1 = new MenuCatalog();
            m1.Add(p1);
            m1.Add(s1);
            m1.Add(d1);
            m1.PrintPizzasMenu();
            Console.WriteLine(m1.Search(3));
            m1.Delete(3);

            try
            { 
                m1.Update(28, p1);
            }
            catch (MenuItemDoesNotExist e)
            {
                Console.WriteLine("The item " + e.Message);
            }

            try
            {
                m1.Add(p2);
            }
            catch (MenuItemNumberExist e)
            {
                Console.WriteLine("The item" + e.Message);
            }


            Console.ReadLine();

        }
    }
}
