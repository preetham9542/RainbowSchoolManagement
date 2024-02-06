using System.ComponentModel.DataAnnotations;

namespace RainbowSchoolManagement.Models
{
    public class Classe
    {
        [Key]
        public int class_id { get; set; }

        public string? ClassSection { get; set; }

        public int ClassStrength { get; set; }

        public string? ClassLeader { get; set; }
    }
}
