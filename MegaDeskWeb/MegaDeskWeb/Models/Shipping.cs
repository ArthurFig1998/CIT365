using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public class Shipping
    {
        public int ShippingId { get; set; }

        [Display(Name = "Shipping Type")]
        public string ShippingType { get; set; }

        public decimal Under1000 { get; set; }

        public decimal Between1000And2000 { get; set; }

        public decimal Over2000 { get; set; }

        //public decimal StandardShipping { get; set; }

        //public decimal shippingPrice()
        //{
        //    return ;
        //}
    }
}
