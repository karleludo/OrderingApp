using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingApp.Models
{
    public class ProductModel
    {
        /// <summary>
        /// The unique identifier for the Product.
        /// </summary> 
        public int ProductId { get; set; }

        /// <summary>
        /// Represents the name of the product.
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Represents the description of the particular product.
        /// </summary>
        public string ProductDescription { get; set; }

        /// <summary>
        /// Represents the amount of a particular product's in stock level.
        /// </summary>
        public int ProductStockQuantity { get; set; }

        /// <summary>
        /// File image converted to byte() with max value
        /// </summary>
        public byte[] ProductImageByte { get; set; }

        /// <summary>
        /// Represents what list of categories a particular product belongs to.
        /// </summary>
        
        public int ProductCategoryId { get; set; }
        /// <summary>
        /// Represent the sizes of a particular product and their prices.
        /// </summary>
        public double ProductPrice { get; set; }
        
        /// <summary>
        /// Represents if the Item is currently available in Stock.
        /// </summary>
        public int ProductinStock { get; set; }


    }
}
