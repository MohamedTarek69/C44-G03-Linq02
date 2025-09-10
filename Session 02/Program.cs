using Session_02.Data;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading;
using static Session_02.ListGenerator;
namespace Session_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Aggregate Operators

            #region Q1
            ////1. Get the total units in stock for each product category.

            //var Result = ProductList.GroupBy(p => p.Category).Select(Category => new
            //{
            //    CategoryName = Category.Key,
            //    TotalUnitsInStock = Category.Sum(p => p.UnitsInStock)
            //});

            //foreach (var unit in Result)
            //    Console.WriteLine(unit);

            #endregion

            #region Q2
            //2.Get the cheapest price among each category's products

            //var Result = ProductList.GroupBy(p => p.Category).Select(Category => new
            //{
            //    CategoryName = Category.Key,
            //    CheapestProductPrice = Category.Min(p => p.UnitPrice)
            //});

            //foreach (var unit in Result)
            //    Console.WriteLine(unit);

            #endregion

            #region Q3
            //3.Get the products with the cheapest price in each category(Use Let)

            //var Result = from p in ProductList
            //             group p by p.Category into Category
            //             let CheapestPrice = Category.Min(p => p.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = Category.Key,
            //                 CheapestPriceProducts = Category.Where(p => p.UnitPrice == CheapestPrice)
            //             };

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.CategoryName);
            //    foreach (var Product in Category.CheapestPriceProducts)
            //    {
            //        Console.WriteLine($"             ProductName:{Product.ProductName}");
            //        Console.WriteLine($"             UnitPrice:{Product.UnitPrice}");
            //    }

            //}

            #endregion

            #region Q4
            //4.Get the most expensive price among each category's products

            //var Result = ProductList.GroupBy(p => p.Category).Select(Category => new
            //{
            //    CategoryName = Category.Key,
            //    MostExpensiveProductPrice = Category.Max(p => p.UnitPrice)
            //});

            //foreach (var unit in Result)
            //    Console.WriteLine(unit);

            #endregion

            #region Q5
            //5.Get the products with the most expensive price in each category.

            //var Result = from p in ProductList
            //                group p by p.Category into Category
            //                let MostExpensivePrice = Category.Max(p => p.UnitPrice)
            //                select new
            //                {
            //                    CategoryName = Category.Key,
            //                    MostExpensivePriceProducts = Category.Where(p => p.UnitPrice == MostExpensivePrice)
            //                };

            //foreach (var Category in Result)
            //    {
            //    Console.WriteLine(Category.CategoryName);
            //    foreach (var Product in Category.MostExpensivePriceProducts)
            //    {
            //        Console.WriteLine($"             ProductID:{Product.ProductID}");
            //        Console.WriteLine($"             ProductName:{Product.ProductName}");
            //        Console.WriteLine($"             UnitPrice:{Product.UnitPrice}");
            //        Console.WriteLine($"             UnitsInStock:{Product.UnitsInStock}");

            //    }
            //}

            #endregion

            #region Q6
            //6.Get the average price of each category's products.

            //var Result = ProductList.GroupBy(p => p.Category).Select(Category => new
            //{
            //    CategoryName = Category.Key,
            //    AveragePrice = Category.Average(p => p.UnitPrice)
            //});

            //foreach (var unit in Result)
            //    Console.WriteLine(unit);

            #endregion

            #endregion

            #region LINQ - Set Operators

            #region Q1
            //1.Find the unique Category names from Product List

            //var Result = ProductList.Select(p => p.Category).Distinct();

            //foreach (var category in Result)
            //    Console.WriteLine(category);

            #endregion

            #region Q2
            //2.Produce a Sequence containing the unique first letter from both product and customer names.

            //var Result = ProductList.Select(P => P.ProductName[0]).Union(CustomerList.Select(C => C.CustomerName[0]));

            //foreach (var item in Result)
            //    Console.Write($"{item} ");

            #endregion

            #region Q3
            //3.Create one sequence that contains the common first letter from both product and customer names.

            //var Result = ProductList.Select(P=> P.ProductName[0]).Intersect(CustomerList.Select(C=> C.CustomerName[0]));

            //foreach (var item in Result)
            //    Console.Write($"{item} ");

            #endregion

            #region Q4
            //4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var Result = ProductList.Select(P => P.ProductName[0]).Except(CustomerList.Select(C => C.CustomerName[0]));

            //foreach (var item in Result)
            //    Console.Write($"{item} ");


            #endregion

            #region Q5
            //5.Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates using takelast

            //var Result = ProductList.Select(p => p.ProductName.TakeLast(3)).Concat(CustomerList.Select(c => c.CustomerName.TakeLast(3)));

            //foreach (var item in Result)
            //{
            //    foreach (var ch in item)
            //        Console.Write(ch);
            //    Console.WriteLine();
            //}


            #endregion

            #endregion



        }
    }
}
