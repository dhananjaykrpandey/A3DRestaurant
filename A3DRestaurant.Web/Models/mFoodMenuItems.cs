using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A3DRestaurant.Web.Models
{
    public class mFoodMenuItems
    {
        public int iID { get; set; }
        public string FoodMenuItemGroupCode { get; set; }
        public string FoodMenuItemCode { get; set; }
        public string FoodMenuItemDesc { get; set; }
        public double FoodMenuItemPrice { get; set; }
        public int FoodMenuItemQty { get; set; }
        public bool? IsFoodMenuItemAdded { get; set; } = default;

    }
}
