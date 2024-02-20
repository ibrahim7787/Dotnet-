using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelCoreMVC.Models;
using ViewModelCoreMVC.ViewModels;

namespace ViewModelCoreMVC.Controllers
{
    public class HomeController : Controller
    {
      public ViewResult EmpDetails()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                LastName="Sagili",
                Email="pavan@gmail.com",
                Phone="8297093253",
                Salary=35000.00
            };
            Department department = new Department()
            {
                EmployeeId = employee.EmployeeId,
                DepName = "IT",
                DomainName = "DotNet",
                JoinDate = new DateOnly(2000,10,10)
            };
            EmployeeDetails EmpD = new EmployeeDetails()
            {
                Employee= employee,
                Department= department,
                Title="Employee Details page",
                Header="Employee Details",
            };
            return View(EmpD);
        }
    }
}