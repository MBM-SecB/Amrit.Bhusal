using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Data;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        //List<Person> employees = Person.GetPerson();
        var db = new EMSContext();
        var employees = db.Employees.Select(x => x.Gender == 'm');
        
        return View(employees);
    }
    public ActionResult Detail(string firstName)
    {
        List<Person> employees =Person.GetPerson();
        var employee = employees.Where(x =>x.FirstName == firstName).First();
        return View(employee);
        
        
    }
    public ActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public ActionResult<bool> Add(Person person)
    {
        return true;


    }
}
