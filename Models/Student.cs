namespace ado_cp_7.Models
{
    public class Student
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string Group { get; set; } = ""; 
    }
}
