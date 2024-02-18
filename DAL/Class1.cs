using SignaturPADAPI.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SignaturPADAPI.DAL
{
    public class Class1 : Interface1
    {
        public SqlConnection con;
        // public DataTable dt;
        //public SqlCommand cmd,cmd1;
        public Class1()
        {
            con = new SqlConnection(@"Data Source=VIPINPV;Initial Catalog=VipinDB;Integrated Security=True");
        }
        public int Add(Models.ModelClass emp)
        {
            int i = 0;

            try
            {
                SqlCommand com = new SqlCommand("Insert into emp_reg1(Name, email, phone, Image) values('" + emp.name + "', '" + emp.Email + ",'" + emp.phone + "','" + emp.Image + "')", con);
          /*      com.CommandType = CommandType.StoredProcedure;
                //com.Parameters.Add("@custID"obj.productID,)
                // com.Parameters.AddWithValue("@productId", obj.productID);
                com.Parameters.AddWithValue("@prName", obj.prName);
                com.Parameters.AddWithValue("@unitPrice", obj.prUnit);
                com.Parameters.AddWithValue("@specialPrice", obj.prUnit);
                com.Parameters.AddWithValue("@urlKey", obj.urltKey);
                com.Parameters.AddWithValue("@maxQtyInOrders", obj.maxqtyINOrder);
                com.Parameters.AddWithValue("@stockAvailablity", obj.StockAvailablity);
                com.Parameters.AddWithValue("@imageUrl", obj.urlPath);
                com.Parameters.AddWithValue("@custId", obj.productID);
                //  com.Parameters.AddWithValue("@City", obj.City);
                // com.Parameters.AddWithValue("@Address", obj.Address);*/
                con.Open();
                 i = com.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {

            }
            return i;
        }
        public List<Models.ModelClass> getemplst()
        {
            List<Models.ModelClass> pr1 = new List<Models.ModelClass>();

            SqlCommand cmd = new SqlCommand("SELECT  FROM emp_reg1", con);
           
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            //  SqlDataAdapter adp = new SqlDataAdapter(cmd);
            // DataTable dt = new DataTable();
            con.Open();

            adp.Fill(dt);
            con.Close();



            foreach (DataRow dr in dt.Rows)
            {
                pr1.Add(

                    new Models.ModelClass
                    {
                        
                       name=Convert.ToString(dr["name"]), 
                       Email=Convert.ToString(dr["Emai"]),
                        phone = Convert.ToString(dr["Emai"]),
                        Image=Convert.ToString(dr["image"])


                    });
            }


            return pr1;
        }
    }
}