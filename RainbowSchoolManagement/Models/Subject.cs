using System.ComponentModel.DataAnnotations;

namespace RainbowSchoolManagement.Models
{
    public class Subject
    {
        [Key]
        public int Subject_id { get; set; }

        public string? Subject_Name { get; set; }

        public string? Teacher { get; set; }

        public int Pending_classes { get; set; }

    }
}
