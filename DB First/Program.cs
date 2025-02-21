using DB_First.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DB_First
{
    internal class Program
    {
        static void Main()
        {
            using NorthwindDbContext dbContext = new NorthwindDbContext();

            //var Result = dbContext.Categories.ToList();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.CategoryName);
            //}

            #region Run Sql Query
            //Run Sql Query
            //1.Select Statment : FromSqlRaw(),FromSqlInterpolated()

            //var Result = dbContext.Categories.FromSqlRaw("Select * from Categories");
            //var Result = dbContext.Products.FromSqlRaw("Select * from Products where UnitsInStock=0");
            //int price = 10;

            //var Result = dbContext.Products.FromSqlRaw($"Select * from Products where UnitPrice>{0}",price);
            //var Result = dbContext.Products.FromSqlInterpolated($"Select * from Products where UnitPrice>{price}");


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            //2.DML Statments [Update - Insert - Delete] : ExecuteSql(),ExecuteSqlInterpolated()

            //int Id = 1;
            //dbContext.Database.ExecuteSqlRaw("Delete from Products Where ProductID={0}",Id);
            //dbContext.Database.ExecuteSqlRaw($"Delete from Products Where ProductID={Id}");
            //dbContext.Database.ExecuteSqlInterpolated($"Delete from Products Where ProductID = {Id} "); 
            #endregion

            
        }
    }
}
