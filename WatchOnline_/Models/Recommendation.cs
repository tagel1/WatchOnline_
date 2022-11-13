using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WatchOnline_.Models
{
    public class Recommendation
    {
        public int RecommendationId { get; set; }

        public int UserId { get; set; }

        public int WatchId { get; set; }

        [Required(ErrorMessage = "Please input a recommendation")]
        [StringLength(100, ErrorMessage = "You cannot have a recommendation longer than 50 characters")]
        public string Recommendations { get; set; }

        public virtual Watch Watch { get; set; }

        public virtual User User { get; set; }
    }
}