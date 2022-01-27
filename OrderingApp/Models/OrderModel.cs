using System;

namespace OrderingApp.Models
{
    public class OrderModel
    {

        /// <summary>
        /// Represents the ID of a given order.
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// Represents the name of the customer who initiated the Order.
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// represents the DateTime of a particular Order
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// OrderLine.OrderQuantity * Product.ProductPrice
        /// </summary>
        public double OrderTotalPrice { get; set; }

    }
}
