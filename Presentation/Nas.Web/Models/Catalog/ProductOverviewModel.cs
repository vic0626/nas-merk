using System.Collections.Generic;
using Nas.Web.Framework.Mvc;
using Nas.Web.Models.Media;

namespace Nas.Web.Models.Catalog
{
    public partial class ProductOverviewModel : BaseNasEntityModel
    {
        public ProductOverviewModel()
        {
            ProductPrice = new ProductPriceModel();
            DefaultPictureModel = new PictureModel();
            SpecificationAttributeModels = new List<ProductSpecificationModel>();
        }

        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string SeName { get; set; }

        //price
        public ProductPriceModel ProductPrice { get; set; }
        //picture
        public PictureModel DefaultPictureModel { get; set; }
        //specification attributes
        public IList<ProductSpecificationModel> SpecificationAttributeModels { get; set; }

		#region Nested Classes

        public partial class ProductPriceModel : BaseNasModel
        {
            public string OldPrice { get; set; }
            public string Price {get;set;}

            public bool DisableBuyButton { get; set; }
            public bool DisableWishlistButton { get; set; }

            public bool AvailableForPreOrder { get; set; }

            public bool ForceRedirectionAfterAddingToCart { get; set; }
        }

		#endregion
    }
}