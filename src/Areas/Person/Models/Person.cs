using System.Data;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Application.Models;

public class Person
{
    public string Name { get; set; }
    public string PrimaryDocument { get; set; }

    // public Export(Person persons)
    // {
    //     this.Name = persons.Name;
    //     this.PrimaryDocument = persons.PrimaryDocument;
    // }
}