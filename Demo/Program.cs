using Demo.Contexts;
using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            //using AppDbContext Context = new AppDbContext();

            //var departments = new List<Department>() 
            //{ 
            //  new Department() { Name="HR"},
            //  new Department() { Name="PR"},
            //  new Department() { Name="IT"}
            //};

            //var employees = new List<Employee>() 
            //{
            //    new Employee(){Name="Ahmed Ali",Address="Cairo",Age=29,Salary=12000,DeptId=100},
            //    new Employee(){Name="Omar Ali",Address="Giza",Age=32,Salary=15000,DeptId=100},
            //    new Employee(){Name="Mona Ali",Address="Cairo",Age=25,Salary=13000,DeptId=100},
            //    new Employee(){Name="Ahmed Khaled",Address="Nasr city",Age=30,Salary=17000,DeptId=200},
            //    new Employee(){Name="Mariam Ahmed",Address="Alex",Age=24,Salary=10000,DeptId=200},
            //    new Employee(){Name="Maha Ahmed",Address="Alex",Age=25,Salary=14000,DeptId=300},
            //    new Employee(){Name="Mohamed Ali",Address="Cairo",Age=33,Salary=18000,DeptId=100},
            //};

            //Context.Departments.AddRange(departments);
            //Context.Employees.AddRange(employees);

            //Context.SaveChanges();

            //var employee=Context.Employees.FirstOrDefault(E => E.Id == 10);
            //Console.WriteLine(employee?.Id??0);
            //Console.WriteLine(employee?.Name??"NA");
            //Console.WriteLine(employee?.Salary??0.0f);
            //Console.WriteLine(employee?.Address??"NA");
            //Console.WriteLine(employee?.HiringDate??DateTime.UtcNow);
            //Console.WriteLine(employee?.DeptId??0);
            //Console.WriteLine(employee?.WorkFor?.Name??"NA");

            //var department = Context.Departments.FirstOrDefault(D => D.Id == 100);

            //Console.WriteLine(department.Name);
            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //EF Core Doesnt load any navigational property [By Default]
            //1.Explicit loading
            //2.Eager loading
            //3.Lazy loading

            #region Explicit loading
            //1.Explicit loading

            //var employee = Context.Employees.FirstOrDefault(E => E.Id == 10);
            //Context.Entry(employee).Reference(nameof(employee.WorkFor)).Load();//explicit loading
            //Context.Entry(employee).Reference(E=>E.WorkFor).Load();//explicit loading

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.UtcNow);
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");

            //var department = Context.Departments.FirstOrDefault(D => D.Id == 100);
            //Context.Entry(department).Collection(D=>D.Employees).Load();//explicit loading

            //Console.WriteLine(department.Name);
            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

            #region Eager loading

            //var employee = Context.Employees.Include(E=>E.WorkFor).FirstOrDefault(E => E.Id == 10);
            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.UtcNow);
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");

            //var department = Context.Departments.Include(D=>D.Employees).FirstOrDefault(D => D.Id == 100);

            //Console.WriteLine(department.Name);
            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            #endregion

            #region Lazy loading

            //3.Lazy Loading
            //1.Install Package Proxies
            //2.Update OnConfiguring(),Use UseLazyLoadingProxies
            //3.Make All Entities public
            //4.Make All Navigational Properties Virtual

            //var employee=Context.Employees.FirstOrDefault(E => E.Id == 10);
            //Console.WriteLine(employee?.Id??0);
            //Console.WriteLine(employee?.Name??"NA");
            //Console.WriteLine(employee?.Salary??0.0f);
            //Console.WriteLine(employee?.Address??"NA");
            //Console.WriteLine(employee?.HiringDate??DateTime.UtcNow);
            //Console.WriteLine(employee?.DeptId??0);
            //Console.WriteLine(employee?.WorkFor?.Name??"NA");

            //var department = Context.Departments.FirstOrDefault(D => D.Id == 100);

            //Console.WriteLine(department.Name);
            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            #endregion

            #region Join Operators - Join

            /*
             Select E.Id,E.Name,D.Id,D.Name
             From Employees E , Departments D
             Where D.Id = E.DeptId
             */

            //using AppDbContext Context = new AppDbContext();

            //Fluent Syntax
            //var result = Context.Employees.Join(Context.Departments, E => E.DeptId, D => D.Id, (E, D) => new
            //{
            //    EmpId = E.Id,
            //    EmpName = E.Name,
            //    DeptId = D.Id,
            //    DeptName = D.Name,
            //}).Where(E=>E.DeptName=="HR");

            //Query Syntax

            //var result = from E in Context.Employees
            //             join D in Context.Departments
            //             on E.DeptId equals D.Id
            //             where D.Name=="HR"
            //             select new
            //             {
            //                 EmpId = E.Id,
            //                 EmpName = E.Name,
            //                 DeptId = D.Id,
            //                 DeptName = D.Name,
            //             };


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Tracking vs NoTracking

            //using AppDbContext Context = new AppDbContext();

            //var result = Context.Employees.AsNoTracking().FirstOrDefault(E => E.Id == 10);

            //Console.WriteLine(Context.Entry(result).State);//Unchanged

            //result.Name = "Amr";//Local

            //Console.WriteLine(Context.Entry(result).State);//Modified

            //Console.WriteLine(result.Name);

            //Context.SaveChanges();//Remotely

            #endregion

            #region Remote Vs Local

            //using AppDbContext Context = new AppDbContext();

            //Remotely
            //Context.Employees.Any();
            //Context.Employees.Any();
            //Context.Employees.Any();
            //Context.Employees.Any();
            //Context.Employees.Any();
            //Context.Employees.Any();

            //Context.Employees.Load();

            //Context.Employees.Local.Any();
            //Context.Employees.Local.Any();
            //Context.Employees.Local.Any();
            //Context.Employees.Local.Any();
            //Context.Employees.Local.Any();

            #endregion

            #region View
            
            //using AppDbContext Context = new AppDbContext();

            //var Result = Context.DepartmentManager.FromSqlRaw("Select * From DepartmentMangersView");
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.DeptName);
            //}
             
            #endregion

        }
    }
}
