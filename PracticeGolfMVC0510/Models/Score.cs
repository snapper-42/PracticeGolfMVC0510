using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticeGolfMVC0510.Models
{
    public class Score
    {
        [Display(Name = "Hole 1")]
        public int intHoleOne { get; set; }

        [Display(Name = "Hole 2")]
        public int intHoleTwo { get; set; }

        [Display(Name = "Hole 3")]
        public int intHoleThree { get; set; }

        [Display(Name = "Hole 4")]
        public int intHoleFour { get; set; }

        [Display(Name = "Hole 5")]
        public int intHoleFive { get; set; }

        [Display(Name = "Hole 6")]
        public int intHoleSix { get; set; }

        [Display(Name = "Hole 7")]
        public int intHoleSeven { get; set; }

        [Display(Name = "Hole 8")]
        public int intHoleEight { get; set; }

        [Display(Name = "Hole 9")]
        public int intHoleNine { get; set; }

        [Display(Name = "Hole 10")]
        public int intHoleTen { get; set; }

        [Display(Name = "Hole 11")]
        public int intHoleEleven { get; set; }

        [Display(Name = "Hole 12")]
        public int intHoleTwelve { get; set; }

        [Display(Name = "Hole 13")]
        public int intHoleThirteen { get; set; }

        [Display(Name = "Hole 14")]
        public int intHoleFourteen { get; set; }

        [Display(Name = "Hole 15")]
        public int intHoleFifteen { get; set; }

        [Display(Name = "Hole 16")]
        public int intHoleSixteen { get; set; }

        [Display(Name = "Hole 17")]
        public int intHoleSeventeen { get; set; }

        [Display(Name = "Hole 18")]
        public int intHoleEighteen { get; set; }
    }
}