using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.ViewModels
{
    public class ResetPaswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(25,ErrorMessage ="Password mora biti izmedju 5 i 25 karaktera!"),MinLength(5,ErrorMessage ="Password mora sadrzavati minimalno 5 karaktera!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

       // [Required]
      //  [StringLength(25, ErrorMessage = "Password mora biti izmedju 5 i 25 karaktera!"), MinLength(5, ErrorMessage = "Password mora sadrzavati minimalno 5 karaktera!")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm password")]
        [Compare("Password",ErrorMessage ="Passwordi se moraju podudarati! ")] //Property kojeg zelimo porediti
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}
