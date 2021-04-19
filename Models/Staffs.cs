using System.ComponentModel.DataAnnotations;

namespace ems.Models
{
    public class Staffs
    {
        public int Id{get; set;}
        [Required]

         [Display(Name="Fullname :")]
         [MaxLength(50, ErrorMessage="Name cannot exceed 50 characters")]
        public string Name{get; set;}
        [Required]
       
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", 
        ErrorMessage = "Please enter a valid e-mail adress")]
        [Display(Name = "Office Email: ")]
        public string Email{get; set;}
        [Required]
        public Dept Department{get; set;}



    }


}