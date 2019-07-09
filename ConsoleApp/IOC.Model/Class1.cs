using System;

namespace IOC.Model
{
    /// <summary>
    /// 产品实体
    /// </summary>
    public class Product
    {
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// product name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// address
        /// </summary>
        public string Address { get; set; }
    }
}
