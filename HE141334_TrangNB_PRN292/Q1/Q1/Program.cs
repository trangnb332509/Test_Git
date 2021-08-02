using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1
{
    public class Product
    {
        int productID;
        double price;

        public Product(int productID, double price)
        {
            this.productID = productID;
            this.price = price;
        }

        public int ProductID { get => productID; set => productID = value; }
        public double Price { get => price; set => price = value; }
    }
    public class Order
    {
        public delegate void changAmount(Product p);
        public event changAmount OnProductInfoChanged;

        private string id;
        private DateTime date;
        private Dictionary<Product,int> productList = new Dictionary<Product, int>() ;

        public Order(string id, DateTime date)
        {
            this.id = id;
            this.date = date;
        }
        public void AddProduct(Product p, int quantity)
        {
            productList.Add(p, quantity);
        }
        public void Display()
        {
            string mess = "";
            mess += "Order's info: Code: " + this.id + " - Date:" + this.date;
            mess += "\nList of Product:";
            
            foreach(Product p in productList.Keys)
            {
                mess += "\nProduct: " + p.ProductID + " - price: " + p.Price + "- Quantity: ";
            }
            //int total = 
            Console.WriteLine(mess);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product(1, 10.5);
            Order o = new Order("01", new DateTime(2021, 5, 1));
            o.AddProduct(p, 1);
            o.AddProduct(new Product(2, 20), 2);
            o.AddProduct(new Product(1, 10.5), 2);
            o.Display();
            Console.ReadLine();
        }
    }
}
