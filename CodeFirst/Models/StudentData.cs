using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class StudentData
    {
        [Key]
        [Required(ErrorMessage ="Student ID is requried.")]
        [DisplayName("Student ID")]
        public int StudID { get; set; }

        [Required(ErrorMessage ="Student name is requried.")]
        [DisplayName("Student Name")]
        public string StudName { get; set; }

        [Required(ErrorMessage ="Student age is requried.")]
        [DisplayName("Student Age")]
        public int StudAge { get; set; }

        [Required(ErrorMessage = "Student city is requried.")]
        [DisplayName("Student city")]
        public string City { get; set; }


    }

    public class EFCodeFirstStudent : DbContext
    {
        public DbSet<StudentData> studentDatas { get; set; }
    }
}