using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Hi_TechDistribution.Business;
using System.Data;

namespace Hi_TechDistribution.DataAccess
{
    public class OrderItemDB
    {
        public static void SaveRecord(OrderItem odr1)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand("INSERT INTO OrderItems(OrderId,ISBN,Quantity,Payment) VALUES(@OrderId,@ISBN,@Quantity,@Payment)", connDB);

            cmd.Parameters.AddWithValue("@OrderId", odr1.OrderId);
            cmd.Parameters.AddWithValue("@ISBN", odr1.Isbn);
            cmd.Parameters.AddWithValue("@Quantity", odr1.Quantity);
            cmd.Parameters.AddWithValue("@Payment", odr1.Payment);

            cmd.ExecuteNonQuery();
            connDB.Close();
        }

        public static List<OrderItem> GetRecordList()
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            List<OrderItem> listOrder = new List<OrderItem>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM OrderItems", connDB);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    OrderItem odrItem = new OrderItem();// create the object here, not outside
                    odrItem.OrderId = Convert.ToInt32(reader["OrderId"]);
                    odrItem.Isbn = Convert.ToInt32(reader["ISBN"]);
                    odrItem.Quantity = Convert.ToInt32(reader["Quantity"]);
                    odrItem.Payment = Convert.ToDouble(reader["Payment"]);

                    listOrder.Add(odrItem);
                }
            }
            else
            {
                listOrder = null;
            }

            return listOrder;
        }
        public static void DeleteRecord(int orderId)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand("DELETE FROM OrderItems WHERE OrderId = @OrderId ", connDB);
            cmd.Parameters.AddWithValue("@OrderId", orderId);
            cmd.ExecuteNonQuery();

            connDB.Close();
        }
        public static void UpdateRecord(OrderItem odr1)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;

            cmd.CommandText = "UPDATE OrderItems SET ISBN = @ISBN,Quantity=@Quantity,Payment=@Payment WHERE OrderId =@OrderId";
            cmd.Parameters.AddWithValue("@ISBN", odr1.Isbn);
            cmd.Parameters.AddWithValue("@Quantity", odr1.Quantity);


            cmd.ExecuteNonQuery();

            //close connection
            connDB.Close();

        }
        public static List<OrderItem> SearchRecord(int orderId)
        {
            List<OrderItem> listOdrItem = new List<OrderItem>();
            SqlConnection connDB = UtilityDB.ConnectDB();

            SqlCommand cmd = new SqlCommand("SELECT * FROM OrderItems where OrderId = @OrderId");
            cmd.Connection = connDB;
            cmd.Parameters.AddWithValue("@OrderId", orderId);

            SqlDataReader reader = cmd.ExecuteReader();
            OrderItem odr1;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    odr1 = new OrderItem();// create the object here, not outside
                    odr1.OrderId = Convert.ToInt32(reader["OrderId"]);
                    odr1.Isbn = Convert.ToInt32(reader["ISBN"]);
                    odr1.Quantity = Convert.ToInt32(reader["Quantity"]);
                    odr1.Payment = Convert.ToInt32(reader["Payment"]);
                    listOdrItem.Add(odr1);
                }
            }
            else
            {
                listOdrItem = null;
            }
            return listOdrItem;
        }
        public static List<OrderItem> SearchRecordByCust(int custId)
        {
            List<OrderItem> listOdrItem = new List<OrderItem>();
            SqlConnection connDB = UtilityDB.ConnectDB();

            SqlCommand cmd = new SqlCommand("SELECT O.OrderId,Odr.ISBN,B.Title,Odr.Quantity,Odr.Payment FROM OrderItems as Odr,Orders as O, Customers as C , Books as B where C.CustomerId = @CustomerId and O.OrderId =Odr.OrderId and B.ISBN=Odr.ISBN");
            cmd.Connection = connDB;
            cmd.Parameters.AddWithValue("@CustomerId", custId);

            SqlDataReader reader = cmd.ExecuteReader();
            OrderItem odr1;
            if (reader.HasRows)
            {
                
                while (reader.Read())
                {
                    odr1 = new OrderItem();// create the object here, not outside
                    odr1.OrderId = Convert.ToInt32(reader["OrderId"]);
                    odr1.Isbn = Convert.ToInt32(reader["ISBN"]);
                    odr1.Quantity = Convert.ToInt32(reader["Quantity"]);
                    odr1.Payment = Convert.ToInt32(reader["Payment"]);
                    listOdrItem.Add(odr1);
                }
            }
            else
            {
                listOdrItem = null;
            }
            return listOdrItem;
        }

    }
}

