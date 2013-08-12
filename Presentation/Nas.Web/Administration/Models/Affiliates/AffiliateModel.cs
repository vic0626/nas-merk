using System;
using FluentValidation.Attributes;
using Nas.Admin.Models.Common;
using Nas.Admin.Validators.Affiliates;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Affiliates
{
    [Validator(typeof(AffiliateValidator))]
    public partial class AffiliateModel : BaseNasEntityModel
    {
        public AffiliateModel()
        {
            Address = new AddressModel();
        }

        [NasResourceDisplayName("Admin.Affiliates.Fields.ID")]
        public override int Id { get; set; }

        [NasResourceDisplayName("Admin.Affiliates.Fields.URL")]
        public string Url { get; set; }
        
        [NasResourceDisplayName("Admin.Affiliates.Fields.Active")]
        public bool Active { get; set; }

        public AddressModel Address { get; set; }

        #region Nested classes
        
        public partial class AffiliatedOrderModel : BaseNasEntityModel
        {
            [NasResourceDisplayName("Admin.Affiliates.Orders.Order")]
            public override int Id { get; set; }

            [NasResourceDisplayName("Admin.Affiliates.Orders.OrderStatus")]
            public string OrderStatus { get; set; }

            [NasResourceDisplayName("Admin.Affiliates.Orders.PaymentStatus")]
            public string PaymentStatus { get; set; }

            [NasResourceDisplayName("Admin.Affiliates.Orders.ShippingStatus")]
            public string ShippingStatus { get; set; }

            [NasResourceDisplayName("Admin.Affiliates.Orders.OrderTotal")]
            public string OrderTotal { get; set; }

            [NasResourceDisplayName("Admin.Affiliates.Orders.CreatedOn")]
            public DateTime CreatedOn { get; set; }
        }

        public partial class AffiliatedCustomerModel : BaseNasEntityModel
        {
            [NasResourceDisplayName("Admin.Affiliates.Customers.Name")]
            public string Name { get; set; }
        }

        #endregion
    }
}