using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Order
    {
        public string SerialNumber_ID { get; set; }
        public string CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
        public string TypeURL { get; set; } 
    }
}