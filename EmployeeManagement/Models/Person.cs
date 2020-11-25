
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    [Required(ErrorMessage="We need first name")]
    [Display(Name ="First Name")]
    
    public string FirstName {get; set;}

    [Required(ErrorMessage="We need last name")]
    [Display(Name ="Last Name")]
    public string Surname {get; set;}

    
    public string Address {get; set;}
    public char Gender {get; set;} = 'M';
    public double Salary {get; set;}

    public static List<Person> GetPerson()
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

        return new List<Person>() {empl1, empl2,empl3,empl4,empl5,empl6};
    }


}