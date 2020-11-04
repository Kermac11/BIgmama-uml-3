using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BIgmama_uml_3
{
    public class MenuCatalog : IMenuCatalog
    {
        private readonly Dictionary<int, IMenuItem> _menu;

        public int Count
        {
            get { return _menu.Count; }
        }

        public MenuCatalog()
        {
            _menu = new Dictionary<int, IMenuItem>();
        }

        public void Add(IMenuItem aMenuItems)
        {
            if (_menu.ContainsKey(aMenuItems.Number))
            {
                throw new MenuItemNumberExist($" {aMenuItems.Number} already exist");
            }
            else
            {
                _menu.Add(aMenuItems.Number, aMenuItems);
            }

        }

        public IMenuItem Search(int number)
        {
            if (_menu.ContainsKey(number))
            {
                foreach (IMenuItem item in _menu.Values)
                {
                    if (item.Number == number)
                    {
                        return item;
                    }
                }
            }

            else
            {
                
                throw new MenuItemDoesNotExist($" {number}´does not exist");
                
            }

            return null;
        }

        public void Delete(int number)
        {
            IMenuItem placeholder = Search(number);
            if (placeholder != null)
            {
                _menu.Remove(number);
            }
            else
            {
                throw new MenuItemDoesNotExist($"{number} does not exist");
            }

        }

        public void PrintPizzasMenu()
        {
            foreach (IMenuItem item in _menu.Values)
            {
                if (item is Pizza)
                {
                    Console.WriteLine(item.PrintInfo());
                }
            }
        }

        public void PrintBeveragesMenu()
        {
            foreach (IMenuItem itemE in _menu.Values)
            {
                if (itemE is Beverage)
                {
                    Console.WriteLine(itemE.PrintInfo());
                }
            }
        }

        public void PrintSandwichsMenu()
        {
            foreach (IMenuItem item in _menu.Values)
            {
                if (item is Sandwich)
                {
                    Console.WriteLine(item.PrintInfo());
                }
            }
        }

        public void PrintToppingsMenu()
        {
            foreach (IMenuItem item in _menu.Values)
            {
                if (item is Toppings)
                {
                    Console.WriteLine(item.PrintInfo());
                }
            }
        }

        public void Update(int number, IMenuItem theMenuItem)
        {
            if (_menu.ContainsKey(number))
            {
                theMenuItem.Number = number;
                _menu[number] = theMenuItem;
            }
            else
            {
                throw new MenuItemDoesNotExist($" {number} does not exist");
            }
        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> veganContainer = new List<IMenuItem>();
            foreach (IMenuItem item in _menu.Values)
            {
                if (item.IsVegan == true)
                {
                    veganContainer.Add(item);
                }
            }

            return veganContainer;
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            List<IMenuItem> organicContainer = new List<IMenuItem>();
            foreach (IMenuItem item in _menu.Values)
            {
                if (item.IsOrganic == true)
                {
                    organicContainer.Add(item);
                }
            }

            return organicContainer;
        }

        public IMenuItem MostExpensiveMenuItem()
        {
            IMenuItem placeholder = null;
            double Count = 0.0;
            foreach (IMenuItem item in _menu.Values)
            {
                if (item.Price > Count)
                {
                    Count = item.Price;
                    placeholder = item;
                }
            }

            return placeholder;
        }

        public override string ToString()
        {
            string info = null;
            foreach (IMenuItem item in _menu.Values)
            {
                info += $"\n\t {item}";
            }

            return info;
        }
    }
}
