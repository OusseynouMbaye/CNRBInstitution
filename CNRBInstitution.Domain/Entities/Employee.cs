namespace CNRBInstitution.Domain.Entities
{
    public record Employee (int EmployeId, string FirstName,string Lastname);
    public record Country (int CountryId, string Name);
 
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