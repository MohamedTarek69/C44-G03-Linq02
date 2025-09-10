using static Session_02.ListGenerator;
using Session_02.Data;
using System.Collections;
namespace Session_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------- Vedio 02 ---------------------------------------//
            #region Casting Operators - Immediate Execution  

            //List<Product> Results = ProductList.Where(P => P.UnitsInStock == 0).ToList();

            //Product[] Result = ProductList.Where(P => P.UnitsInStock == 0).ToArray();

            //Dictionary<long, string> Result = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID, P => P.ProductName);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            //foreach (var item in Result)
            //    Console.WriteLine($"Key = {item.Key} , Value = {item.Value}");

            //HashSet<Product> Result = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            //ArrayList arrayList = new ArrayList()
            //    {
            //        "Ahmed",
            //        "Mona",
            //        "Aya",
            //        1,
            //        2,
            //        3
            //    };

            //var Result = arrayList.OfType<int>();

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            //--------------------------------------- Vedio 03 ---------------------------------------//
            #region Generation Operators

            //var Result = Enumerable.Range(0, 100);

            //Result = Enumerable.Repeat(2, 100);
            //foreach (var i in Result)
            //    Console.Write($"{i} ");

            //var Result = Enumerable.Repeat(new Product(), 100);

            //var Result02 = Enumerable.Empty<Product>().ToArray;
            //var Result02 = Enumerable.Empty<Product>().ToList();
            //Product[] products = new Product[0];

            //foreach (var i in Result)
            //    Console.Write($"{i} ");

            #endregion

        }
    }
}