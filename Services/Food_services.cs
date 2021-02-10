using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Entities;
using System.Data.Linq;

namespace Services
{
  public class Food_services
    {
        Food_Repository fr;

        public Food_services() {
            fr = new Food_Repository();


        }

        public Menu Get_data_for_update(int id) {


            Menu menu = new Menu();
            menu=fr.Getdata_byId(id);
            return menu;


        }
        public int Replace_menu(string fn, float fp, string fd, int fct, string img, int fa, int fc,int food_id) {


           int res =fr.Update_menu(new Food_item() { Food_name = fn, Food_price = fp, Food_des = fd, Food_cT = fct, Food_photo = img, Food_avl = fa, Food_cat = fc },food_id );

            if (res > 0) return res;
            else return 0;

        }

        public List<Menu> Get_menu() {



            return fr.GetFood_Items();

        }

        public int Adding_ingradians(string name, float price, int cat) {


         int res=fr.Add_ing(new Ing() { Ing_name = name, ing_price = price, Ing_cat = cat });
            return res;
        }



        public int Add_new_menu(string fn, float fp,string fd,int fct, string img, int fa, int fc) {

            int result = fr.AddItem(new Food_item() { Food_name = fn, Food_price = fp, Food_des = fd, Food_cT = fct, Food_photo = img, Food_avl = fa, Food_cat = fc });

            return result;


        }


        public List<Ing> Get_ingrdiant(int cat) {

            return fr.Get_ing(cat);

        }

        public List<Ing> Get_ingid(int id) {


            return fr.Get_ingId_by_fid(id);


        }

        public int adding_extra_ing(int fid, int inid) {

            int res = fr.Add_Extra_ing(fid, inid);
            return res;

        }

        public int Get_food_id() {

            int id=fr.Get_latest_fid();

            return id;

        }



        public int Remove_pre_ing(int food_id)
        {


          return  fr.Remove_pre_ing(food_id);
    
        }


        public int Is_food_extra(int food_id) {


            return fr.Is_ing_avl(food_id);

        }

        public int Rremove_Item(int food_id) {

            return fr.Remove_foodItem(food_id);


        }

        public int Set_ava(int food_id, int value) {

           return fr.Set_avl(food_id, value);


        }

        public List<Menu> Get_menu_by_id(int cat_id) {


           return fr.Get_menu_by_cat(cat_id);



        }

        public List<Ing> Get_food_extra_ing(int food_id) {



            return fr.Get_food_added_ing(food_id);




        }

        public int Insert_order(int food_id, DateTime date, int quan, int tottalp) 
{


         int res=   fr.Insert_order(new Order { Food_id = food_id, Order_date = date.Date, Order_quantity = quan, Tottal_price = tottalp });
            if (res > 1) return 1;
            else return 0;




        }


        public List<Order> Get_order() {

            return fr.Get_order();


        }

    }

}
