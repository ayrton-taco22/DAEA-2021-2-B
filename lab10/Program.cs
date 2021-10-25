using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwndDataContext context = new NorthwndDataContext();

            // Ejercicio propuesto
            var query = from su in context.Suppliers
                        from ca in context.Categories
                        join pr in context.Products
                        on su.SupplierID equals pr.SupplierID
                        where pr.CategoryID == 4
                        select new { su, ca, pr };

            var query2 = from su in context.Suppliers
                         join pr in context.Products
                         on su.SupplierID equals pr.SupplierID
                         where su.Country.Equals("USA")
                         select new { su, pr };

            foreach (var pro in query)
            {
                Console.WriteLine("ID={0} \t ProductName={1} \t ProductProvidere={2}", pro.pr.ProductID, pro.pr.ProductName, pro.su.CompanyName);
            }

            foreach (var us in query2)
            {
                Console.WriteLine("ID={0} \t ProductName={1} \t IDSupplier={2} \t SupplierName={3}", us.pr.ProductID, us.pr.ProductName, us.su.SupplierID, us.su.CompanyName);
            }
            // End  Ejercicios propuestos

            //Insertar  datos
            //Products p = new Products();

            //p.ProductName = "Peruvian Coffee";
            //p.SupplierID = 20;
            //p.CategoryID = 1;
            //p.QuantityPerUnit = "10 pkgs";
            //p.UnitPrice = 25;

            //context.Products.InsertOnSubmit(p);
            //context.SubmitChanges();

            ////Insercion tabla Category
            //Categories c = new Categories();
            //c.CategoryName = "Wines";
            //c.Description = "Selection of wines according to place of age";

            //context.Categories.InsertOnSubmit(c);
            //context.SubmitChanges();

            //var query1 = from ca in context.Categories
            //             select ca;

            ////var query = from p in context.Products
            ////            select p;

            ////var query = from p in context.Products
            ////            where p.Categories.CategoryName == "Beverages"
            ////            select p;

            ////var query = from prod in context.Products
            ////            where prod.UnitPrice < 20
            ////            select prod;

            //var query = from pr in context.Products
            //            where pr.CategoryID == 1
            //            select pr;


            //// Ejercicio J.1
            ////var query = from p in context.Products
            ////            where p.ProductName.Contains(@"queso")
            ////            select p;

            //// Ejercicio J.2
            ////var query = from p in context.Products
            ////            where p.QuantityPerUnit.Contains(@"pkg")
            ////            || p.QuantityPerUnit.Contains(@"pkgs")
            ////            select p;

            //// Ejercicio J.3
            ////var query = from p in context.Products
            ////            where p.ProductName.StartsWith("a")
            ////            select p;

            //// Ejercicio J.4
            ////var query = from p in context.Products
            ////            where p.UnitsInStock == 0
            ////            select p;

            //// Ejercicio J.5
            ////var query = from p in context.Products
            ////            where p.Discontinued == true
            ////            select p;

            ///*foreach (var cate in query1)
            //{
            //    Console.WriteLine("ID={0} \t Name={1} \t Description={2}", cate.CategoryID, cate.CategoryName, cate.Description);
            //}*/

            //foreach (var prod in query)
            //{
            //    //Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            //    Console.WriteLine("ID={0} \t Price={1} \t Name={2}", prod.ProductID, prod.UnitPrice,prod.ProductName);
            //    // Ejercicio J.1//Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            //    // Ejercicio J.2//Console.WriteLine("ID={0} \t Name={1} \t Presentation={2}", prod.ProductID, prod.ProductName, prod.QuantityPerUnit);
            //    // Ejercicio J.3//Console.WriteLine("Name={0} \t Price={1}", prod.ProductName, prod.UnitPrice);
            //    // Ejercicio J.4//Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            //    // Ejercicio J.5 //Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            //}

            //var query = from pr in context.Products
            //            where pr.ProductName == "Tofu"
            //            select pr;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t  Name={1} \t Price={2} \t Stock={3} \t Discontinued={4}", prod.ProductID, prod.ProductName, prod.UnitPrice, prod.UnitsInStock, prod.Discontinued);
            //}

            ////Modificar datos

            //var product = (from p in context.Products
            //              where p.ProductName == "Tofu"
            //              select p).FirstOrDefault();
            //product.UnitPrice = 100;
            //product.UnitsInStock = 15;
            //product.Discontinued = true;

            //context.SubmitChanges();

            //var query2= from pr2 in context.Products
            //            where pr2.ProductName == "Tofu"
            //            select pr2;

            //foreach (var prod2 in query2)
            //{
            //    Console.WriteLine("ID={0} \t  Name={1} \t Price={2} \t Stock={3} \t Discontinued={4}", prod2.ProductID, prod2.ProductName, prod2.UnitPrice, prod2.UnitsInStock, prod2.Discontinued);
            //}

            ////Eliminar registro
            //var productEliminar = (from pr3 in context.Products
            //                where pr3.ProductID == 78
            //                select pr3).FirstOrDefault();

            //context.Products.DeleteOnSubmit(productEliminar);
            //context.SubmitChanges();



            //var queryEliminar = from pr4 in context.Products
            //             where pr4.CategoryID == 1
            //             select pr4;

            //foreach (var prod4 in queryEliminar)
            //{
            //    Console.WriteLine("ID={0} \t  Name={1} \t Price={2} \t Stock={3} \t Discontinued={4}", prod4.ProductID, prod4.ProductName, prod4.UnitPrice, prod4.UnitsInStock, prod4.Discontinued);
            //}

            Console.ReadKey();

        }
    }
}
