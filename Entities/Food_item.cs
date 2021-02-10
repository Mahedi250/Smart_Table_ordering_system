using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.Linq;

namespace Entities
{
    public class Order{

        public int Order_id { set; get; }
        public int Food_id { set; get; }
        public string food_name  { set; get; }
        public DateTime Order_date { set; get; }
        public int Order_quantity { set; get; }
        public int Tottal_price { set; get; }





    }
   public class Food_item
    {
        public String Food_name { get; set; }
        public float Food_price { get; set; }
        public string Food_des { get; set; }
        public int Food_cT { get; set;}
        public string Food_photo { get; set; }

        public int Food_cat { get; set; }
        public int Food_avl { get; set; }
        public string Food_cata { get; set; }

    }

    public class Menu {
        public int Food_Id { get; set; }
        public String Food_Name { get; set; }
        public float Food_Price { get; set; }
        public string Food_Details { get; set; }
        public int Food_COOking_time { get; set; }
        public Image Food_photo { get; set; }
        public string Food_path { get; set; }
        public string Food_Catagory { get; set; }
        public int Food_cata { get; set; }
        public int Food_avl { get; set; }







    }
    public class Ing {
        public int Ing_id { set; get; }
        public string Ing_name { set; get; }
        public float ing_price { set; get; }
        public int Ing_cat { set; get; }



    }


}
