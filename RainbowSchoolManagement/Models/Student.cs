using System.ComponentModel.DataAnnotations;

namespace RainbowSchoolManagement.Models
{
    public class Student
    {
        [Key]
        public int  Student_id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set;}

        public int Age { get; set; }

        public DateTime Birthday { get; set;}
    }
}
