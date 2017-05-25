using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using MySql.Data;
using MySql.Data.MySqlClient;
using Dapper;


namespace WebApplication1.App.Data
{
    public class OrderRepository
    {
        private Order order = new Order();

        private string constr;

        public OrderRepository()
        {
            constr = "server=4d28bcf8-5ca3-47f1-bc54-a771012fcc51.mysql.sequelizer.com;user=gpsobmslthufejao;database=db4d28bcf85ca347f1bc54a771012fcc51;port=3306;password=UYL6M4ZWmEicc3WduMSWyW24KtjfTxmcbHktphdtT4wDvPx2CTYFMki77RttSTdW;";
        }

        public Order GetBySerial(string Serial)
        {
            Order order = new Order();
            using (var _cn = new MySqlConnection(constr))
            {
                order = _cn.Query<Order>("Select o.SerialNumber_ID, o.CustomerID, o.OrderDate, o.OrderNumber, s.SiteName, p.Description, p.TypeURL from OrderData o Inner Join ProductData p ON o.Type_ID = p.ID Inner Join OrderSite s ON o.OrderSite = s.ID where o.SerialNumber_ID = @SerialNum", new { SerialNum = Serial }).FirstOrDefault();
            }
            return order;
        }

    }
}