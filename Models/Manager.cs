using System.ComponentModel.DataAnnotations;

namespace ST10026525.PROG62112.POE.part1.Models
{
    public class Manager
    {
        [Key]
        public int ManagerId { get; set; }

        public int ManagerName { get; set; }

        public string ManagerPassword { get; set; }

        public string ManagerEmail { get; set; }    
    }
}
