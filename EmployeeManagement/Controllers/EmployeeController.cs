using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Data;
using Microsoft.EntityFrameworkCore;


public class EmployeeController : Controller

{
    private EMSContext db;
    public EmployeeController(EMSContext _db)
    {
        db =_db;

    }
    public ActionResult Index()
    {
        //List<Person> employees = Person.GetPerson();
       var employees =db.Employees.Include(x => x.Department).ToList();
        
        return View(employees);
    }
    public ActionResult Detail(int id)
    {
        var employee=db.Employees.Find(id);
        return View(employee);
        
        
    }
    public ActionResult Add()
    {
        return View();
    }
    public ActionResult Delete()
    {
        return View();
    }
    [HttpPost]
    public ActionResult<bool> Add(Person person)
    {
        db.Employees.Add(person);
        db.SaveChanges();

        //var rowsAffected=db.SaveChanges();
        return RedirectToAction(nameof(Index));


    }

    [HttpPost]
    public ActionResult Delete(int id)
    {
        var person=db.Employees.Find(id);
        db.Employees.Remove(person);
        db.SaveChanges();

        //var rowsAffected=db.SaveChanges();
        return RedirectToAction(nameof(Index));


    }
    public ActionResult Edit(int id)
    {
        var person=db.Employees.Find(id);
        

        //var rowsAffected=db.SaveChanges();
        
        return View(person);


    }

    [HttpPost]
    public ActionResult Edit(Person person)
    {
        db.Employees.Attach(person);
        
        db.Employees.Update(person);
        db.SaveChanges();
        
        return RedirectToAction(nameof(Index));


    }

}
