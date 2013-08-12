using System;
using System.Collections.Generic;
using Nas.Core.Domain.Common;
using Nas.Core.Domain.Customers;
using Nas.Core.Domain.Directory;
using Nas.Core.Domain.Orders;

namespace Nas.Services.Shipping
{
    /// <summary>
    /// Represents a request for getting shipping rate options
    /// </summary>
    public partial class GetShippingOptionRequest
    {
        public GetShippingOptionRequest()
        {
            this.Items = new List<ShoppingCartItem>();
        }

        /// <summary>
        /// Gets or sets a customer
        /// </summary>
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets a shopping cart items
        /// </summary>
        public virtual IList<ShoppingCartItem> Items { get; set; }

        /// <summary>
        /// Gets or sets a shipping address
        /// </summary>
        public virtual Address ShippingAddress { get; set; }

        /// <summary>
        /// Shipped from country
        /// </summary>
        public virtual Country CountryFrom { get; set; }

        /// <summary>
        /// Shipped from state/province
        /// </summary>
        public virtual StateProvince StateProvinceFrom { get; set; }

        /// <summary>
        /// Shipped from zip/postal code
        /// </summary>
        public virtual string ZipPostalCodeFrom { get; set; }
    }
}
