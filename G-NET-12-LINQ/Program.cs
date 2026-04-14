using LINQ.DataSources;
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

            //var result = from p in ProductList
            //             where p.UnitsInStock > 0 && p.Category == "Condiments"
            //             select p.UnitPrice;


            //var result = ProductList.Take(5);

            //var result = ProductList.Skip(10).Take(10);
            int[] numbers = { 5, 4, 3, 1, 6, 9, 2, 8 };

            //var result = numbers.TakeWhile(n => n < 6);

            //var result = numbers.TakeWhile((n, i) => n >= i);

            //var result = numbers.TakeWhile(n => n % 3 == 0);
            //var result = ProductList.Any(n => n.UnitsInStock == 0);


            //var result = ProductList.Where(n => n.Category == "Seafood").All(n => n.UnitsInStock > 0);
            //Console.WriteLine(result);


            var result = from p in ProductList
                         let DiscountPrice = p.UnitPrice * 0.5M
                         where DiscountPrice < 10
                         select new
                         {
                             p.ProductName,
                             p.UnitPrice,
                             PriceAfterDiscount = p.UnitPrice * 0.5M
                         };

            
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question07
            #endregion

            #region Question08
            #endregion

            #region Question09
            #endregion

            #region Question10
            #endregion

            #region Question11
            #endregion

            #region Question12
            #endregion

            #region Question13
            #endregion


        }
    }
}
