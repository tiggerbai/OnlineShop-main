using Microsoft.Data.SqlClient;
using OnlineShopCMS.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using OnlineShopCMS.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace OnlineShopCMS.Models
{
    public class OrderFactory
    {
        OnlineShopContext db = new OnlineShopContext();

        public LinkedList<Order> getOrders()
        {
            LinkedList<Order> orders = new LinkedList<Order>();
            foreach (Order order in db.Order)
            {
                orders.AddLast(order);
            }
            return orders;
        }

        public List<Order> getUnpaidOrders(IConfiguration config)
        {

            OnlineShopContext db = new OnlineShopContext();

            var orders = db.Order.OrderBy(x => x.OrderDate).ToList();
            var ordersFail = new List<Order>().Where(x => x.IsPaid == false).ToList();
            return ordersFail;



        }


        public List<OnlineShopCMS.Models.Order> queryBySql(string sql, List<SqlParameter> paras)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=OnlineShop;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            if (paras != null)
                cmd.Parameters.AddRange(paras.ToArray());
            SqlDataReader reader = cmd.ExecuteReader();
            List<OnlineShopCMS.Models.Order> list = new List<OnlineShopCMS.Models.Order>();
            while (reader.Read())
            {
                OnlineShopCMS.Models.Order x = new Models.Order()
                {
                    Id = reader.GetInt32(0),
                    OrderDate = reader.GetDateTime(1),
                    UserId = reader.GetString(2),
                    UserName = reader.GetString(3),
                    ReceiverName = reader.GetString(4),
                    ReceiverAddress = reader.GetString(5),
                    ReceiverPhone = reader.GetString(6),
                    Total = reader.GetInt32(7),
                    IsPaid = reader.GetBoolean(8),
                    IsShipped = reader.GetBoolean(9),
                    ShippingDate = reader.GetDateTime(10)
                };


                list.Add(x);
            }
            con.Close();
            return list;
        }
        public void update(OnlineShopCMS.Models.Order p)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            string sql = "UPDATE  Order  SET";
            if (!string.IsNullOrEmpty(p.UserName))
            {
                sql += " UserName=@K_USERNAME,";
                paras.Add(new SqlParameter("@K_USERNAME", p.UserName));
            }
            if (!string.IsNullOrEmpty(p.ReceiverName))
            {
                sql += " ReceiverName=@K_RECEIVERNAME,";
                paras.Add(new SqlParameter("@K_RECEIVERNAME", p.ReceiverName));
            }
            if (!string.IsNullOrEmpty(p.ReceiverAddress))
            {
                sql += " ReceiverAddress=@K_RECEIVERADRESS,";
                paras.Add(new SqlParameter("@K_RECEIVERADRESS", p.ReceiverAddress));
            }
            if (!string.IsNullOrEmpty(p.ReceiverPhone))
            {
                sql += " ReceiverPhone=@K_RECEIVERPHONE,";
                paras.Add(new SqlParameter("@K_RECEIVERPHONE", p.ReceiverPhone));
            }
            if (p.Total != 0)
            {
                sql += " Total=@K_TOTAL,";
                paras.Add(new SqlParameter("@K_TOTAL", p.Total));
            }
            if (p.IsPaid != false)
            {
                sql += " IsPaid=@K_ISPAID,";
                paras.Add(new SqlParameter("@K_ISPAID", p.IsPaid));
            }
            if (p.IsShipped != false)
            {
                sql += " IsShipped=@K_ISSHIPPED,";
                paras.Add(new SqlParameter("@K_ISSHIPPED", p.IsShipped));
            }
            if (p.ShippingDate != null)
            {
                sql += " ShippingDate=@K_SHIPPINGDATE,";
                paras.Add(new SqlParameter("@K_SHIPPINGDATE", p.ShippingDate));
            }

            if (sql.Trim().Substring(sql.Trim().Length - 1, 1) == ",")
                sql = sql.Trim().Substring(0, sql.Trim().Length - 1);
            sql += " WHERE fId=@K_FID";
            paras.Add(new SqlParameter("@K_FID", p.Id));

            executeSql(sql, paras);
        }

        public void create(OnlineShopCMS.Models.Order p)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            string sql = "INSERT INTO Order (";
            if (!string.IsNullOrEmpty(p.UserName))
            {
                sql += "UserName,";
                paras.Add(new SqlParameter("@K_USERNAME", p.UserName));
            }
            if (!string.IsNullOrEmpty(p.ReceiverName))
            {
                sql += "ReceiverName,";
                paras.Add(new SqlParameter("@K_RECEIVERNAME", p.ReceiverName));
            }
            if (!string.IsNullOrEmpty(p.ReceiverAddress))
            {
                sql += "ReceiverAddress,";
                paras.Add(new SqlParameter("@K_RECEIVERADRESS", p.ReceiverAddress));
            }
            if (!string.IsNullOrEmpty(p.ReceiverPhone))
            {
                sql += "ReceiverPhone,";
                paras.Add(new SqlParameter("@K_RECEIVERPHONE", p.ReceiverPhone));
            }
            if (p.Total != 0)
            {
                sql += "Total,";
                paras.Add(new SqlParameter("@K_TOTAL", p.Total));
            }
            if (p.IsPaid != false)
            {
                sql += "IsPaid,";
                paras.Add(new SqlParameter("@K_ISPAID", p.IsPaid));
            }
            if (p.IsShipped != false)
            {
                sql += "IsShipped,";
                paras.Add(new SqlParameter("@K_ISSHIPPED", p.IsShipped));
            }
            if (p.ShippingDate != null)
            {
                sql += "ShippingDate,";
                paras.Add(new SqlParameter("@K_SHIPPINGDATE", p.ShippingDate));
            }

            if (sql.Trim().Substring(sql.Trim().Length - 1, 1) == ",")
                sql = sql.Trim().Substring(0, sql.Trim().Length - 1);
            sql += ")VALUES(";
            if (!string.IsNullOrEmpty(p.UserName))
                sql += "@K_USERNAME,";
            if (!string.IsNullOrEmpty(p.ReceiverName))
                sql += "@K_RECEIVERNAME,";
            if (!string.IsNullOrEmpty(p.ReceiverAddress))
                sql += "@K_RECEIVERADRESS,";
            if (!string.IsNullOrEmpty(p.ReceiverPhone))
                sql += "@K_RECEIVERPHONE,";
            if (p.Total != 0)
                sql += "@K_TOTAL,";
            if (p.IsPaid != false)
                sql += "@K_ISPAID,";
            if (p.IsShipped != false)
                sql += "@K_ISSHIPPED,";
            if (p.ShippingDate != null)
                sql += "@K_SHIPPINGDATE,";

            if (sql.Trim().Substring(sql.Trim().Length - 1, 1) == ",")
                sql = sql.Trim().Substring(0, sql.Trim().Length - 1);
            sql += ")";
            executeSql(sql, paras);
        }


        private void executeSql(string sql, List<SqlParameter> paras)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=OnlineShop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            if (paras != null)
                cmd.Parameters.AddRange(paras.ToArray());
            cmd.ExecuteNonQuery();
        }
    }
}
