using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        List<Person> employees = Person.GetPerson();
        return View(employees);
    }
    public ActionResult Detail(string firstName)
    {
        List<Person> employees =Person.GetPerson();
        var employee = employees.Where(x =>x.FirstName == firstName).First();
        return View(employee);
        
        
    }
}
