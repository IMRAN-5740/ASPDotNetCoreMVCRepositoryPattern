using System.ComponentModel.DataAnnotations;

namespace ASPDotNetCoreMVCApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Provide your Name")]
        
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Provide your RegNo")]
        [Display(Name="Registration No")]
        public string RegNo { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Please Provide your Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Provide your City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please Provide your Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Provide your Department")]
        [Display(Name="Department Name")]
        public string Department { get; set; }
    }
}
