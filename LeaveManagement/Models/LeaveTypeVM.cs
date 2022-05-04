using LeaveManagement.Data;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Models
{
    public class LeaveTypeVM 
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type")]
        [Required]
        public string Name { get; set; }
        [Display(Name ="Default Number Of Days")]
        [Range(1,25, ErrorMessage ="Please Enter A Valid Number")]
        [Required]
        public int DefaultDays { get; set; }
    }
}
