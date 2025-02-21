using InheritanceExample.Contexts;
using InheritanceExample.Models;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main()
        {
            // 3 Ways to generate schema
            // 1.TPC :Table Per Class
            // 2.TPH :Table Per Heirarchy
            // 3.TPCC :Table Per Concrete Class
        
            using AppDbContext context = new AppDbContext();

            //FullTimeEmployee fullTime01 = new FullTimeEmployee()
            //{
            //    Name = "Ahmed Ali",
            //    Address = "Cairo",
            //    Email = "AhmedAli@gmail.com",
            //    Salary = 12000
            //};

            //FullTimeEmployee fullTime02 = new FullTimeEmployee()
            //{
            //    Name = "Ahmed Khaled",
            //    Address = "Alex",
            //    Email = "AhmedKhaled@gmail.com",
            //    Salary = 15000
            //};

            //FullTimeEmployee fullTime03 = new FullTimeEmployee()
            //{
            //    Name = "Mariam Ali",
            //    Address = "Giza",
            //    Email = "MariamAli@gmail.com",
            //    Salary = 15000
            //};

            //context.FullTimeEmployees.Add(fullTime03);
            //context.SaveChanges();

            //PartTimeEmployee partTime01 = new PartTimeEmployee()
            //{
            //    Name = "Mohamed Ahmed",
            //    Address = "Cairo",
            //    Email = "MohamedAhmed@gmail.com",
            //    NumberOfHours = 120,
            //    HourRate = 200
            //};

            //PartTimeEmployee partTime02 = new PartTimeEmployee()
            //{
            //    Name = "Maha Khaled",
            //    Address = "Alex",
            //    Email = "MahaKhaled@gmail.com",
            //    NumberOfHours = 200,
            //    HourRate = 300
            //};

            //PartTimeEmployee partTime03 = new PartTimeEmployee()
            //{
            //    Name = "Mariam Ahmed",
            //    Address = "Giza",
            //    Email = "MariamAhmed@gmail.com",
            //    NumberOfHours = 100,
            //    HourRate = 300
            //};

            //context.FullTimeEmployees.Add(fullTime03);
            //context.PartTimeEmployees.Add(partTime01);
            //context.PartTimeEmployees.Add(partTime02);
            //context.PartTimeEmployees.Add(partTime03);

            //context.SaveChanges();

            //var result= context.Employees.OfType < PartTimeEmployee>();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //foreach (var item in context.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //var result = context.FullTimeEmployees.FirstOrDefault(E => E.Id == 1);
            //Console.WriteLine(result.Name);
        }
    }
}
