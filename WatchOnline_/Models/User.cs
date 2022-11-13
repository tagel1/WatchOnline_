using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WatchOnline_.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please input a first name")]
        [StringLength(50, ErrorMessage = "You cannot have a first name longer than 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please input a last name")]
        [StringLength(50, ErrorMessage = "You cannot have a last name longer than 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please input a mail address")]
        [StringLength(50, ErrorMessage = "You cannot have a mail address longer than 50 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please input a password")]
        [StringLength(50, ErrorMessage = "You cannot have a password longer than 50 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please input a street name")]
        [StringLength(50, ErrorMessage = "You cannot have a street name longer than 50 characters")]
        public string Street { get; set; }

        [Range(0, 50)]
        public int NumHouse { get; set; }

        [Required(ErrorMessage = "Please input a city name")]
        [StringLength(50, ErrorMessage = "You cannot have a city name longer than 50 characters")]
        public string City { get; set; }

        [Range(0, 100000000000)]
        public double PhoneNum { get; set; }

        public virtual ICollection<Recommendation> Recommendations { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}