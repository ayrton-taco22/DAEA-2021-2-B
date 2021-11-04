using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;

namespace Lab11_A
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            //{
            //    var products = AWEntities.Product;

            //    //IQueryable<String> ProductNames = from p in products
            //    //                                  select p.Name;
            //    //IQueryable<String> ProductNames = products.Select(p => p.Name);
            //    IQueryable<Product> productsQuery = from p in products
            //                                        select p;
            //    IQueryable<Product> largeProducts = productsQuery.Where(p => p.Size == "L");

            //    Console.WriteLine("Productos de tamaño 'L': ");
            //    foreach (var product in largeProducts)
            //    {
            //        Console.WriteLine(product.Name + " - " + product.ProductID);
            //    }
            //    Console.ReadKey();
            //}

            // Ejercicio 4
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    IQueryable<Product> productsQuery = from product in context.Product
            //                                        select product;
            //    Console.WriteLine("Productos : ");
            //    foreach (var prod in productsQuery)
            //    {
            //        Console.WriteLine(prod.Name);
            //    }
            //    Console.ReadKey();
            //}

            // Ejercicio 5
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    var query = from product in context.Product
            //                select new
            //                {
            //                    ProductId = product.ProductID,
            //                    ProductName = product.Name
            //                };
            //    Console.WriteLine("Informacion de productos : ");
            //    foreach (var productInfo in query)
            //    {
            //        Console.WriteLine("Product ID: {0} Product name: {1} ",
            //            productInfo.ProductId,productInfo.ProductName);
            //    }
            //    Console.ReadKey();
            //}

            // Ejercicio 8
            //int orderQtyMin = 2;
            //int orderQtyMax = 6;
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    var query = from order in context.SalesOrderDetail
            //                where order.OrderQty > orderQtyMin
            //                && order.OrderQty < orderQtyMax
            //                select new 
            //                {
            //                    SalesOrderID = order.SalesOrderID,
            //                    OrderQty = order.OrderQty
            //                };
            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("Order ID: {0} \t Order quantity: {1}",
            //            order.SalesOrderID, order.OrderQty);
            //    }
            //    Console.ReadKey();
            //}

            // Ejercicio 9
            //String color = "Red";
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    var query = from product in context.Product
            //                where product.Color == color
            //                select new 
            //                {
            //                    Name = product.Name,
            //                    ProductNumber = product.ProductNumber,
            //                    ListPrice = product.ListPrice
            //                };
            //    foreach (var product in query)
            //    {
            //        Console.WriteLine("Name: {0}", product.Name);
            //        Console.WriteLine("Product number: {0}", product.ProductNumber);
            //        Console.WriteLine("List Price: ${0}", product.ListPrice);
            //        Console.WriteLine("");
            //    }
            //    Console.ReadKey();
            //}

            // Ejercicio 10
            //using (AdventureWorksEntities eje10Entities = new AdventureWorksEntities())
            //{
            //    int?[] productModelIds = { 19, 26, 118 };
            //    var products = from p in eje10Entities.Product
            //                   where productModelIds.Contains(p.ProductModelID)
            //                   select p;
            //    foreach (var product in products)
            //    {
            //        Console.WriteLine("{0}: {1}",
            //            product.ProductModelID, product.ProductID);
            //    }
            //    Console.ReadKey();
            //}
            // Ejercicio 12
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    IQueryable<Decimal> sortedPrices = from p in context.Product
            //                                       orderby p.ListPrice descending
            //                                       select p.ListPrice;

            //    Console.WriteLine("Lista de precios desde el mas alto al más bajo");
            //    foreach (Decimal price in sortedPrices)
            //    {
            //        Console.WriteLine(price);
            //    }
            //    Console.ReadKey();
            //}
            // Ejercicio 14
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    var products = context.Product;
            //    var query = from product in products
            //                group product by product.Style into g
            //                select new
            //                {
            //                    Style = g.Key,
            //                    AverageListPrice = g.Average(product => product.ListPrice)
            //                };
            //    foreach (var product in query)
            //    {
            //        Console.WriteLine("Estilo: {0} \t Precio promedio: {1}",
            //            product.Style, product.AverageListPrice);
            //    }
            //    Console.ReadKey();
            //}

            // Ejercicio 15
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    var products = context.Product;
            //    var query = from product in products
            //                group product by product.Color into g
            //                select new
            //                {
            //                    Color = g.Key,
            //                    ProductCount = g.Count()
            //                };

            //    foreach (var product in query)
            //    {
            //        Console.WriteLine("Color = {0} \t Cantidad = {1}",
            //            product.Color, product.ProductCount);
            //    }
            //    Console.ReadKey();
            //}

            // Ejercicio 16
            using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var orders = context.SalesOrderHeader;
                var query = from order in orders
                            group order by order.SalesPersonID into g
                            select new
                            {
                                Category = g.Key,
                                maxTotalDue = g.Max(order => order.TotalDue)
                            };

                foreach (var order in query)
                {
                    Console.WriteLine("PersonID = {0} \t TotalDue maximo = {1}",
                        order.Category, order.maxTotalDue);
                }
                Console.ReadKey();
            }
        }
    }
}
