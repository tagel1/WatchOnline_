using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WatchOnline_.Models
{
    public class Watch
    {

        public Watch()
        {
            this.ShoppingCarts = new HashSet<ShoppingCart>();
        }


        public int WatchId { get; set; }

        public int GenderId { get; set; }

        public int BrandId { get; set; }

        public int RecommendationId { get; set; }

        public int ShoppingCartId { get; set; }


        public string Picture { get; set; }

        [Range(0, 100000)]
        public float Price { get; set; }

        [Range(0, 100000)]
        public int WatchStock { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual Gender Gender { get; set; }
        
        public virtual ICollection<Recommendation> Recommendations { get; set; }

        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }

    }
}