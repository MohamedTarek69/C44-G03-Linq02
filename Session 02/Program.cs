using static Session_02.ListGenerator;
using Session_02.Data;
using System.Collections;
using System.Text.RegularExpressions;
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

            //--------------------------------------- Vedio 04 ---------------------------------------//
            #region Set Operators
            //var Seq01 = Enumerable.Range(0, 100); // 0 => 99

            //var Seq02 = Enumerable.Range(50, 100); // 50 => 149 

            //var Seq03 = Seq01.Union(Seq02);

            //Seq03 = Seq01.Concat(Seq02);

            //Seq03 = Seq03.Distinct();

            //Seq03 = Seq01.Except(Seq02);

            //Seq03 = Seq01.Intersect(Seq02);

            //Console.WriteLine("//---------------Seq01---------------//");
            //foreach (var i in Seq01)
            //    Console.Write($"{i} ");

            //Console.WriteLine();
            //Console.WriteLine("//---------------Seq02---------------//");
            //foreach (var i in Seq02)
            //    Console.Write($"{i} ");

            //Console.WriteLine();
            //Console.WriteLine("//---------------Seq03---------------//");
            //foreach (var i in Seq03)
            //    Console.Write($"{i} ");

            #endregion

            //--------------------------------------- Vedio 05 ---------------------------------------//
            #region Quantifier Operators

            //List<Product> TestProducts = new List<Product>();
            //var Result = ProductList.Any(P => P.UnitsInStock == 1000);

            //Console.WriteLine(Result);

            //var Result = ProductList.All(P => P.UnitsInStock >= 0);
            //Console.WriteLine(Result);

            //var Seq01 = Enumerable.Range(0, 100); // 0 => 99

            //var Seq02 = Enumerable.Range(50, 100); // 50 => 149 

            //var Result = Seq01.SequenceEqual(Seq02);

            //Result = TestProducts.Any();
            //Console.WriteLine(Result);

            #endregion

            //--------------------------------------- Vedio 06 ---------------------------------------//
            #region Zipping Operator

            //string[] Names = { "Ahmed", "Mona", "Aya", "Ali", "Mohamed" };

            //int[] Numbers = Enumerable.Range(1, 10).ToArray(); // 1 => 10

            //char[] Chars = { 'A', 'B', 'C', 'D', 'E' };


            //var Result = Names.Zip(Numbers,(Name,Number) => new {index = Number , Name = Name});

            //foreach (var i in Result)
            //    Console.WriteLine(i);

            //var Result = Names.Zip(Numbers, Chars);

            //foreach (var i in Result)
            //    Console.WriteLine(i);

            #endregion

            //--------------------------------------- Vedio 07 ---------------------------------------//
            #region Grouping Operators

            #region Get Products Grouped by Category 
            //var Result = from P in ProductList
            //             group P by P.Category;

            //Result = ProductList.GroupBy(p => p.Category);

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //        Console.WriteLine($"             {Product.ProductName}");
            //}

            #endregion

            #region Get Products in Stock Grouped by Category 
            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category;

            //Result = ProductList.Where(P => P.UnitsInStock > 0).GroupBy(p => p.Category);

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //        Console.WriteLine($"             {Product.ProductName}");
            //}

            #endregion

            #region  Get Products in Stock Grouped by Category That Contains More Than 10 Products
            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             where Category.Count() > 10
            //             select Category;

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //        Console.WriteLine($"             {Product.ProductName}");
            //}

            //var Result = ProductList.Where(P => P.UnitsInStock > 0).GroupBy(p => p.Category).Where(Category => Category.Count() > 10);

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //        Console.WriteLine($"             {Product.ProductName}");
            //}

            #endregion

            #region Get Category Name of Products in Stock That Contains More Than 10 Product and Number of Product In Each Category
            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             where Category.Count() > 10
            //             select new
            //             {
            //                 CategoryName = Category.Key,
            //                 NumberOfProducts = Category.Count(),
            //             };

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category);
            //}

            //var Result = ProductList.Where(P => P.UnitsInStock > 0).GroupBy(p => p.Category).Where(Category => Category.Count() > 10).Select(Category => new
            //{
            //    CategoryName = Category.Key,
            //    NumberOfProducts = Category.Count()
            //});

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category);
            //}

            #endregion

            #endregion

            //--------------------------------------- Vedio 08 ---------------------------------------//
            #region Partitioning Operartor

            //int[] Numbers = { 5, 4, 1, 9, 7, 6, 2, 3 };

            //var Result = ProductList.Where(P => P.UnitsInStock > 0).Take(10);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            //var Result = ProductList.TakeLast(10);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            //var Result = ProductList.Where(P => P.UnitsInStock == 0).Skip(2);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            //var Result = ProductList.Where(P => P.UnitsInStock == 0).SkipLast(2);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            //var Result = Numbers.TakeWhile((Number, I) => Number > I);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            //var Result = Numbers.SkipWhile(N => N < 9);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            //var Result = ProductList.Skip(20).Take(10);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            //--------------------------------------- Vedio 09 ---------------------------------------//
            #region Let and Into [valid with Query Syntax Only]

            //List<string> Names = new List<string>()
            //{
            //    "Omar",
            //    "Ahmed",
            //    "Sally",
            //    "Mohamed",
            //    "Ali"
            //};

            //// A , O , U , I , E 

            //var Result = from N in Names
            //             select Regex.Replace(N, "[AOUIEaouie]", string.Empty)
            //             into NoVowelNames
            //             where NoVowelNames.Length > 3
            //             select NoVowelNames;

            //foreach (var N in Result)
            //    Console.WriteLine(N);

            //var Result = from N in Names
            //             let NoVowelNames = Regex.Replace(N, "[AOUIEaouie]", string.Empty)
            //             where NoVowelNames.Length > 3
            //             select NoVowelNames;

            //foreach (var N in Result)
            //    Console.WriteLine(N);

            #endregion



        }
    }
}