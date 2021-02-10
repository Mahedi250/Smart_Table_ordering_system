using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Data.Linq;

namespace Repository
{
    public class Food_Repository
    {
        DataAccess dbc;

        public Food_Repository()
        {

            dbc = new DataAccess();

        }

        public int Insert_order(Order o) {
            dbc = new DataAccess();

            string sql = "Insert into item_order(Food_id,order_date,food_quantity,tottal_price) values(" + o.Food_id + ",'" + o.Order_date.Date + "'," + o.Order_quantity + "," + o.Tottal_price + ")";

            int res = dbc.ExecuteQuery(sql);

            return res;








        }

        public List<Order> Get_order()
        {

            dbc = new DataAccess();
            string sql = "select food_item.food_name,item_order.tottal_price,item_order.food_quantity,item_order.food_id from Food_item,item_order where item_order.food_id=food_item.food_id";
            SqlDataReader reader = dbc.GetData(sql);
            List<Order> order_Items = new List<Order>();
            while (reader.Read())
            {
                Order order = new Order();

                order.Food_id = Convert.ToInt32(reader["food_id"]);
                order.food_name = reader["food_name"].ToString();
                order.Order_quantity = Convert.ToInt32(reader["food_quantity"]);

                order.Tottal_price = Convert.ToInt32(reader["tottal_price"]);

                order_Items.Add(order);

            }

            return order_Items;

        }
        public int Update_menu(Food_item fi,int food_id) {
            dbc = new DataAccess();
            string sql = "UPDATE Food_item  SET food_name='" + fi.Food_name + "' ,food_price =" + fi.Food_price + " ,food_des ='" + fi.Food_des + "' ,food_cooktime =" + fi.Food_cT + " ,food_pic ='" + fi.Food_photo + "',food_avl=" + fi.Food_avl + " ,food_cat =" + fi.Food_cat + " where Food_id="+food_id+" ";
          int res= dbc.ExecuteQuery(sql);

            return res;






        }

        public Menu Getdata_byId(int id) {

            dbc = new DataAccess();
            string sql = "select * from Food_item where Food_id=" + id + "";

            SqlDataReader reader = dbc.GetData(sql);
            if (reader.Read())
            {

                Menu menu = new Menu();
                menu.Food_Id = Convert.ToInt32(reader["food_id"]);
                menu.Food_Name = reader["food_name"].ToString();
                menu.Food_Price = float.Parse(reader["food_price"].ToString());
                menu.Food_Details = reader["food_des"].ToString();
                menu.Food_COOking_time = Convert.ToInt32(reader["food_cooktime"]);
                menu.Food_path = reader["food_pic"].ToString();
                menu.Food_cata = Convert.ToInt16(reader["Food_cat"]);
                menu.Food_photo= Image.FromFile(reader["food_pic"].ToString());


                menu.Food_avl = Convert.ToInt16(reader["food_avl"]);
                dbc.Dispose();
                return menu;

            }
            else return null;







        }


        public List<Menu> Get_menu_by_cat(int cat_id)
        {

            dbc = new DataAccess();
            string sql = "select * from Food_item where food_cat=" + cat_id + "";
            SqlDataReader reader = dbc.GetData(sql);
            List<Menu> food_Items = new List<Menu>();
            while (reader.Read())
            {
                Menu menu = new Menu();
                menu.Food_Id = Convert.ToInt32(reader["food_id"]);
                menu.Food_Name = reader["food_name"].ToString();
                menu.Food_Price = float.Parse(reader["food_price"].ToString());
                menu.Food_Details = reader["food_des"].ToString();
                menu.Food_COOking_time = Convert.ToInt32(reader["food_cooktime"]);
               

                menu.Food_avl = Convert.ToInt16(reader["food_avl"]);

                try
                {

                    menu.Food_photo = Image.FromFile(reader["food_pic"].ToString());

                }

                catch { }




                food_Items.Add(menu);


            }
            dbc.Dispose();

            return food_Items;
        }

        public List<Menu> GetFood_Items() {
            dbc = new DataAccess();
            string sql = "select * from Food_item,Food_cat where Food_item.food_cat=food_cat.cat_id";
            SqlDataReader reader= dbc.GetData(sql);
            List<Menu> food_Items = new List<Menu>();
            while (reader.Read())
            {
                Menu menu = new Menu();
                menu.Food_Id = Convert.ToInt32(reader["food_id"]);
                menu.Food_Name = reader["food_name"].ToString();
                menu.Food_Price = float.Parse(reader["food_price"].ToString());
                menu.Food_Details = reader["food_des"].ToString();
                menu.Food_COOking_time = Convert.ToInt32(reader["food_cooktime"]);
                menu.Food_Catagory = reader["cat_name"].ToString();
               
                menu.Food_avl = Convert.ToInt16(reader["food_avl"]);

                try
                {

                    menu.Food_photo = Image.FromFile(reader["food_pic"].ToString());

                }

                catch { }

              


                food_Items.Add(menu);

            }

            dbc.Dispose();

            return food_Items;

        }

        public int Remove_pre_ing(int food_id) {

            dbc = new DataAccess();

            string sql = "delete from extra_ing where food_id=" + food_id + "";
            try
            {
                int res = dbc.ExecuteQuery(sql);
                if (res > 0) return 1;
                else return 0;

            }
            catch {  return 0; }
         





        }


        public int AddItem(Food_item fI)
        {

            dbc = new DataAccess();
            
            string sql = "insert into Food_item(food_name, food_price, food_des, food_cooktime, food_pic, food_avl, food_cat) values('" + fI.Food_name + "'," + fI.Food_price + ", '" + fI.Food_des + "'," + fI.Food_cT + ",'" + fI.Food_photo + "'," + fI.Food_avl + ", " + fI.Food_cat + ")";

            int result = dbc.ExecuteQuery(sql);
            dbc.Dispose();
            if (result > 0) return 1;
            else return 0;

        }

        public List<Ing> Get_ing(int cat)
        {

            dbc = new DataAccess();

            string sql = "select Ads_on_ing.ing_id,Ads_on_ing.ing_name,Ads_on_ing.ing_price from Ads_on_ing where cat_id = " + cat + "";
            SqlDataReader reader = dbc.GetData(sql);
            List<Ing> ingr_list = new List<Ing>();

            while (reader.Read())
            {
                Ing ingr = new Ing();
                ingr.Ing_id = Convert.ToInt32(reader["ing_id"]);
                ingr.Ing_name = Convert.ToString(reader["ing_name"]);
                ingr.ing_price = Convert.ToInt32(reader["ing_price"]);

                ingr_list.Add(ingr);


            }

            dbc.Dispose();

            return ingr_list;


        }

        public int Add_ing(Ing ing) {

            dbc = new DataAccess();
               string sql = "Insert into Ads_on_ing(ing_name,ing_price,cat_id) values('" + ing.Ing_name + "'," + ing.ing_price + "," + ing.Ing_cat + ")";
            int res = dbc.ExecuteQuery(sql);

            dbc.Dispose();
            return res;



        }

        public int Add_Extra_ing(int food_id, int ing_id) {

            dbc = new DataAccess();
            string sql = "insert into extra_ing(food_id,ing_id) values(" + food_id + "," + ing_id + ")";

            int res = dbc.ExecuteQuery(sql);

            dbc.Dispose();
            return res;



        }

        public List<Ing> Get_ingId_by_fid(int id)
        {

            dbc = new DataAccess();
            string sql = " select ing_id from extra_ing where food_id="+id+" group by ing_id";
            SqlDataReader reader = dbc.GetData(sql);
            List<Ing> ing_id_list = new List<Ing>();

            while (reader.Read())
            {
                Ing ingr = new Ing();
                ingr.Ing_id = Convert.ToInt32(reader["ing_id"]);
                ing_id_list.Add(ingr);


               
            }
            return ing_id_list;
        }
        public int Get_latest_fid() {

            dbc = new DataAccess();
            string sql = "select Food_item.food_id from Food_item where Food_item.food_id=(select Max(Food_item.food_id) from Food_item)";

           SqlDataReader reader =dbc.GetData(sql);
            if (reader.Read())
            {
                int id = Convert.ToInt32(reader["food_id"]);
                dbc.Dispose();
                return id;




            }
           
            else return 0;


        }

        public List<Ing> Get_food_added_ing(int food_id) {

            dbc = new DataAccess();
            string sql = "select Ads_on_ing.ing_id,Ads_on_ing.ing_name,Ads_on_ing.ing_price from Ads_on_ing,extra_ing where Ads_on_ing.ing_id=extra_ing.ing_id and extra_ing.food_id=" + food_id + "";
            SqlDataReader reader = dbc.GetData(sql);
            List<Ing> ingList = new List<Ing>();
            while (reader.Read()) {

                Ing ingr = new Ing();
                ingr.Ing_id = Convert.ToInt32(reader["ing_id"]);
                ingr.Ing_name = Convert.ToString(reader["ing_name"]);
                ingr.ing_price = Convert.ToInt32(reader["ing_price"]);

                ingList.Add(ingr);
                
            }
            return ingList;



        }

        public int Is_ing_avl(int food_id) {



            dbc = new DataAccess();
            string sql = "select * from extra_ing";
            SqlDataReader reader = dbc.GetData(sql);
            if (reader.HasRows) return 1;
            else return 0;



        }

        public int Remove_foodItem(int food_id) {

            dbc =new DataAccess();
            string sql = "Delete from Food_item where food_id=" + food_id + "";
            int res = dbc.ExecuteQuery(sql);
            if (res > 0)
            {

                Remove_pre_ing(food_id);

                dbc.Dispose();

                return res;


            }

            else return 0;


        }


        public int Set_avl(int food_id, int value) {

            dbc = new DataAccess();
            string sql= "UPDATE Food_item set food_avl="+value+" where food_id="+food_id+"";
            int res =dbc.ExecuteQuery(sql);
            return res;




        }

    }


    
}
