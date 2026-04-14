using LINQ.DataSources;
using LINQ.Models;
using static LINQ.DataSources.Source;


namespace G_NET_12_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");



            #region Question01
            //var result = ProductList.Where(p => p.Category == "Seafood").Select(n => new { n.ProductName, n.UnitPrice, n.Category });

            //var result = from p in ProductList
            //             where p.Category == "Seafood"
            //             select new { p.ProductName, p.UnitPrice };




            #endregion

            #region Question02
            //var result = ProductList.Select(p => p.ProductName);
            #endregion

            #region Question03
            //var result = from p in ProductList
            //             orderby p.UnitPrice ascending
            //             select new { p.ProductName, p.UnitPrice };

            //var result = ProductList.OrderBy(p => p.UnitPrice).Select(p => new { p.ProductName, p.UnitPrice });


            #endregion

            #region Question04

            //var result = ProductList.Where(p => p.UnitPrice > 10 && p.UnitPrice < 20);


            #endregion

            #region Question05

            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            //var result = from p in ProductList
            //             where p.UnitsInStock > 0 && p.Category == "Condiments"
            //             select p;




            #endregion

            #region Question06

            var result = ProductList.Select(p => new { p.ProductName, p.UnitPrice, StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of stock" });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question07
            //var result = ProductList.Select((n, i) => new {i,n.ProductName});

            #endregion

            #region Question08
            //var result = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            #endregion

            #region Question09

            //var result = ProductList.Where(p => p.Category == "Beverges").OrderByDescending(p => p.UnitsInStock)
            //    .Select(p=>  p.ProductName);
            #endregion

            #region Question10

            //var result = from c in CustomerList
            //             from o in c.Orders
            //             where o.OrderDate.Year > 1997
            //             select new { c.CustomerID, o.OrderDate };


            #endregion

            #region Question11

            //var result = ProductList.Select((p,i) => new {position=i+1,p.ProductName});

            #endregion

            #region Question12

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderByDescending(a => a.Length);
            #endregion

            #region Question13
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.Where(x => char.ToLower(x[1]) == 'i').Reverse(); 

            #endregion


        }
    }
}
