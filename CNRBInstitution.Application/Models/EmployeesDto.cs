namespace CNRBInstitution.Application.Models
{
    public class EmployeesDto
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

       /* public DateTime? JoinedDate { get; set; }
        public int NumberOfYearsEmployed
        {
            get
            {
                return DateTime.Now.Year - JoinedDate.Value.Year;
            }
        }*/
    }
}
