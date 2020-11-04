using System.Collections.Generic;
using BIgmama_uml_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MamaTest
{
    [TestClass]
    public class TestCL
    {
        [TestMethod]
        public void AddCustomer()
        {
            CustomerCatalog cc = new CustomerCatalog();
            int numberBefore = cc.Count;
            Customer c1 = new Customer(2, "john", "Undulatsvej", "78674523");
            cc.AddCustomer(c1);
            int numberAfter = cc.Count;

            Assert.AreEqual(numberBefore + 1, numberAfter);
        }

        [TestMethod]
        public void AddItem()
        {
            IMenuCatalog mc = new MenuCatalog();
            int numberBefore = mc.Count;
            IMenuItem p1 = new Pizza(1, "LIVER KILLER", "ÅLdont eat this", 27, MenuType.Pizza, true, true, true);
            mc.Add(p1);
            int numberAfter = mc.Count;
            Assert.AreEqual(numberBefore + 1, numberAfter);
        }

        [TestMethod]
        public void DeleteItem()
        {
            IMenuCatalog mc = new MenuCatalog();
            IMenuItem p1 = new Pizza(1, "LIVER KILLER", "ÅLdont eat this", 27, MenuType.Pizza, true, true, true);
            IMenuItem p2 = new Pizza(2, "LIVER KILLER", "ÅLdont eat this", 27, MenuType.Pizza, true, true, true);
            IMenuItem p3 = new Pizza(3, "LIVER KILLER", "ÅLdont eat this", 27, MenuType.Pizza, true, true, true);
            mc.Add(p1);
            mc.Add(p2);
            mc.Add(p3);
            int numberBefore = mc.Count;
            mc.Delete(2);
            int numberAfter = mc.Count;
            Assert.AreEqual(numberBefore - 1, numberAfter);
        }

        [TestMethod]
        public void SearchItem()
        {
            IMenuCatalog mc = new MenuCatalog();
            IMenuItem p1 = new Pizza(1, "LIVER KILLER", "ÅLdont eat this", 27, MenuType.Pizza, true, true, true);
            mc.Add(p1);
            IMenuItem p2 = new Pizza(2, "LIVER KILLER", "ÅLdont eat this", 27, MenuType.Pizza, true, true, true);
            mc.Add(p2);
            IMenuItem placeHolder = mc.Search(2);
            Assert.AreSame(p2, placeHolder);
        }

        [TestMethod]
        public void UpdateItem()
        {
            IMenuCatalog mc = new MenuCatalog();
            IMenuItem p1 = new Pizza(1, "LIVER KILLER", "ÅLdont eat this", 27, MenuType.Pizza, true, true, true);
            mc.Add(p1);
            IMenuItem p2 = new Pizza(2, "LIVER KILLER", "ÅLdont eat this", 27, MenuType.Pizza, true, true, true);
            mc.Update(1,p2);
            Assert.AreSame(p2, mc.Search(1));
        }

        [TestMethod]
        public void MostExpensive()
        {
            IMenuCatalog mc = new MenuCatalog();
            IMenuItem p1 = new Pizza(1, "LIVER KILLER", "ÅLdont eat this", 27, MenuType.Pizza, true, true, true);
            mc.Add(p1);
            IMenuItem p2 = new Pizza(2, "LIVER KILLER", "ÅLdont eat this", 80, MenuType.Pizza, true, true, true);
            IMenuItem s1 = new Sandwich(3, "JUMPER", "meget fyld", 150, MenuType.Sandwich, true, true, Sandwich.Meat.Chicken);
            mc.Add(p2);
            mc.Add(s1);
            IMenuItem placeholder = mc.MostExpensiveMenuItem();
            Assert.AreEqual(150, placeholder.Price);
        }

        [TestMethod]
        public void Vegan()
        {
            IMenuCatalog mc = new MenuCatalog();
            IMenuItem p1 = new Pizza(1, "LIVER KILLER", "ÅLdont eat this", 27, MenuType.Pizza, true, true, true);
            mc.Add(p1);
            IMenuItem p2 = new Pizza(2, "LIVER KILLER", "ÅLdont eat this", 80, MenuType.Pizza, false, true, true);
            IMenuItem s1 = new Sandwich(3, "LIVER KILLER", "ÅLdont eat this", 150, MenuType.Pizza, true, true, Sandwich.Meat.Chicken);
            mc.Add(p2);
            mc.Add(s1);
            Assert.AreEqual(2, mc.FindAllVegan(MenuType.Pizza).Count);
        }

        [TestMethod]
        public void Organic()
        {
            IMenuCatalog mc = new MenuCatalog();
            IMenuItem p1 = new Pizza(1, "LIVER KILLER", "ÅLdont eat this", 27, MenuType.Pizza, true, false, true);
            mc.Add(p1);
            IMenuItem p2 = new Pizza(2, "LIVER KILLER", "ÅLdont eat this", 80, MenuType.Pizza, false, true, true);
            IMenuItem s1 = new Sandwich(3, "LIVER KILLER", "ÅLdont eat this", 150, MenuType.Pizza, true, true, Sandwich.Meat.Chicken);
            mc.Add(p2);
            mc.Add(s1);
            IMenuItem b1 = new Beverage(4,"cola", "Bobler",78, MenuType.Pizza, true, false, false);
            Assert.AreEqual(2, mc.FindAllOrganic(MenuType.Pizza).Count);
        }

        [TestMethod]
        [ExpectedException(typeof(MenuItemNumberExist))]
        public void DoubleAddFail()
        {
            IMenuCatalog mc = new MenuCatalog();
            IMenuItem p1 = new Pizza(1, "LIVER KILLER", "ÅLdont eat this", 27, MenuType.Pizza, true, false, true);
            mc.Add(p1);
            mc.Add(p1);

        }

        [TestMethod]
        [ExpectedException(typeof(MenuItemDoesNotExist))]
        public void RemoveFail()
        {
            IMenuCatalog mc = new MenuCatalog();
            IMenuItem p1 = new Pizza(1, "LIVER KILLER", "ÅLdont eat this", 27, MenuType.Pizza, true, false, true);
            mc.Delete(1);
        }
    }
}
