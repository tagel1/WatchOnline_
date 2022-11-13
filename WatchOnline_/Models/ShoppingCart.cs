using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WatchOnline_.Models
{
    public class ShoppingCart
    {

        public ShoppingCart()
        {
            this.Watches = new HashSet<Watch>();
        }

        public int ShoppingCartId { get; set; }

        public int WatchId { get; set; }

        [Range(0, 10000)]
        public int Quantity { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Watch> Watches { get; set; }

    }
}