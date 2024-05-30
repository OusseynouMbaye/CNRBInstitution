namespace CNRBInstitution.Domain.Entities
{
    public class Country(string name)
    {
        public int CountryId { get; set; }
        public string Name { get; set; } = name;
        public string? Description { get; set; }
    }
}
