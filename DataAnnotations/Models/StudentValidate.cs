using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotations.Models
{
    public class StudentValidate
    {
        [Required]
        [Display(Name ="Enter you Name")]
        [StringLength(maximumLength:15,MinimumLength =3,ErrorMessage ="Incorrect Lenght Enter..!!")]
        public string StudName { get; set; }

        [Required]
        [Display(Name = "Enter you Age")]
        [Range(18,50, ErrorMessage = "Incorrect Age Range..!!")]
        public int StudAge { get; set; }

        [Required]
        [Display(Name = "Enter you Email")]
        [EmailAddress(ErrorMessage = "Incorrect Your Emial..!!")]
        public string StudEmail { get; set; }

        [Required]
        [Display(Name = "Enter you Password")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$",ErrorMessage ="Atleast 8 char required..!!")]
        public string StudPassword { get; set;}

        [Required]
        [Display(Name = "ReEnte Your Password")]
        [DataType(DataType.Password)]
        [Compare("StudPassword")]
        public string StudReEnterPassword { get; set;}

        [Required(ErrorMessage ="Gender Is Requried..!!")]
        [Display(Name = "Enter Your Gender")]
        public string StudGender { get; set; }


    }
}