
using Microsoft.AspNetCore.Mvc;
using Areas.Person.Models.Persons;

class PersonController : ControllerBase
{
    public PersonController(){
        
    }

    public string ListPersons(){
        return "Lista";
    }

}
