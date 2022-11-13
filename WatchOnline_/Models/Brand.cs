using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WatchOnline_.Models
{
    public class Brand
    {
        public int BrandId { get; set; }

        [Required(ErrorMessage = "Please input a brand name")]
        [StringLength(100, ErrorMessage = "You cannot have a brand name longer than 50 characters")]
        public string BrandName { get; set; }


        public virtual ICollection<Watch> Watches { get; set; }
    }
}