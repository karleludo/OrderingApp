using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingApp.Models
{
    public class OrderLineModel
    {
        /// <summary>
        /// Represents the foreign key of the ProductOrder
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Represents the FK of a particular product.
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// represents how many Products in this OrderLine
        /// </summary>
        ///
        public int OrderQuantity { get; set; }

    }
}
