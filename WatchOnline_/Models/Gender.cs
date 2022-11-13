using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WatchOnline_.Models
{
    public class Gender
    {
        public int GenderId { get; set; }


        [Required(ErrorMessage = "Please input a gender name")]
        [StringLength(100, ErrorMessage = "You cannot have a gender name longer than 50 characters")]
        public string GenderName { get; set; }

        public virtual ICollection<Watch> Watches { get; set; }
    }
}