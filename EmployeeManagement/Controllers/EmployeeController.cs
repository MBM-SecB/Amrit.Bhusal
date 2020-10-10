using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        

        //Object initializer syntax
        Person empl1 = new Person()
        {
            FirstName= "Sekhar",
            Surname= "Khanal",
            Address = "Sankhamul",
            Salary= 10000.0

        };
        Person empl2 = new Person{FirstName= "Rachan",Surname= "Nepal",Address = "Ktm",Salary= 15000};
        Person empl3 = new Person{FirstName= "Raman",Surname= "Shiwakoti",Address = "Koteshwor",Salary= 25000};
        Person empl4 = new Person{FirstName= "Nischal",Surname= "Karki",Address = "bhaktapur",Salary= 5000};
        Person empl5 = new Person{FirstName= "Sagar",Surname= "Neupane",Address = "Jumla",Salary= 35000};
        Person empl6 = new Person{FirstName= "Raj",Surname= "Tiwari",Address = "KOteshwor",Salary= 20000};

        List<Person> employees = new List<Person>() {empl1, empl2,empl3,empl4,empl5,empl6};
        return View(employees);
    }
}
