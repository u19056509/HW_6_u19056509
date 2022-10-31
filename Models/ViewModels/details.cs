using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW_6_u19056509.Models.ViewModels
{
    public class details
    {
        public string product_name { get; set; }
        public short model_year { get; set; }
        public decimal list_price { get; set; }
        public string brand_name { get; set; }
        public string category_name { get; set; }
        public List<Quantity> storeQuantities { get; set; }
    }
}