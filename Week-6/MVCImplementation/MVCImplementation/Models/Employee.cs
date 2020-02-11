using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCImplementation.Models
{
    public class Employee
    {
        //static int number;

        [Required]
        public string Name { get; set; }
        public int ID { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public String Address { get; set; }
    }
}