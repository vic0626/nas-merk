using System;
using System.Collections.Generic;
using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Customer
{
    public partial class CustomerDownloadableProductsModel : BaseNasModel
    {
        public CustomerDownloadableProductsModel()
        {
            Items = new List<DownloadableProductsModel>();
        }

        public IList<DownloadableProductsModel> Items { get; set; }
        public CustomerNavigationModel NavigationModel { get; set; }

        #region Nested classes
        public partial class DownloadableProductsModel : BaseNasModel
        {
            public Guid OrderProductVariantGuid { get; set; }

            public int OrderId { get; set; }

            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string ProductSeName { get; set; }
            public string ProductAttributes { get; set; }

            public int DownloadId { get; set; }
            public int LicenseId { get; set; }

            public DateTime CreatedOn { get; set; }
        }
        #endregion
    }

    public partial class UserAgreementModel : BaseNasModel
    {
        public Guid OrderProductVariantGuid { get; set; }
        public string UserAgreementText { get; set; }
    }
}