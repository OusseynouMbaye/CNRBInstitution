using System.ComponentModel.DataAnnotations;

namespace CNRBInstitution.Domain.Entities
{
    public class Employee(string firstName, string lastName)
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; } 

        public MaritalStatus MaritalStatus { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

    }




}

/*-ProjectName
  - Domain
    - Entities
    - ValueObjects
    - Interfaces
    - Exceptions
  - Application
    - Services
    - DTOs
    - Interfaces
    - Validators
  - Infrastructure
    - Persistence
    - Configuration
    - Mapping
  - Presentation
    - Controllers
    - Views
*/

/* public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
*/