using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticeGolfMVC0510.Models
{
    public class Golfer
    {

        [Key]
        public int intPersonID { get; set; }

        [Display(Name = "First Name")]
        public string strFirstName { get; set; }

        [Display(Name = "Last Name")]
        public string strLastName { get; set; }

        [Display(Name = "Nickname")]
        public string strNickname { get; set; }

    }
}