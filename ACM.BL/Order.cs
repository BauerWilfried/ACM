using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order(): this(0)
        {

        }
        public Order(int orderID)
        {
            OrderID = orderID;
            OrderItems= new List<OrderItem>();
        } 
        public override string ToString() => $"{OrderDate.Value.Date} ({OrderID})";

        public int CustomerID { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressID { get; set; }
        public override bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }

        public string Log() =>
            $"{OrderID}: Date: {this.OrderDate.Value.Date} Status: {this.EntityState.ToString()}";
    }
}
