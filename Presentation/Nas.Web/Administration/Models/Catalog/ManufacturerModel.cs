﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FluentValidation.Attributes;
using Nas.Admin.Models.Customers;
using Nas.Admin.Models.Stores;
using Nas.Admin.Validators.Catalog;
using Nas.Web.Framework;
using Nas.Web.Framework.Localization;
using Nas.Web.Framework.Mvc;
using Telerik.Web.Mvc;

namespace Nas.Admin.Models.Catalog
{
    [Validator(typeof(ManufacturerValidator))]
    public partial class ManufacturerModel : BaseNasEntityModel, ILocalizedModel<ManufacturerLocalizedModel>
    {
        public ManufacturerModel()
        {
            if (PageSize < 1)
            {
                PageSize = 5;
            }
            Locales = new List<ManufacturerLocalizedModel>();
            AvailableManufacturerTemplates = new List<SelectListItem>();
        }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.Description")]
        [AllowHtml]
        public string Description { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.ManufacturerTemplate")]
        [AllowHtml]
        public int ManufacturerTemplateId { get; set; }
        public IList<SelectListItem> AvailableManufacturerTemplates { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.MetaKeywords")]
        [AllowHtml]
        public string MetaKeywords { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.MetaDescription")]
        [AllowHtml]
        public string MetaDescription { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.MetaTitle")]
        [AllowHtml]
        public string MetaTitle { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.SeName")]
        [AllowHtml]
        public string SeName { get; set; }

        [UIHint("Picture")]
        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.Picture")]
        public int PictureId { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.PageSize")]
        public int PageSize { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.AllowCustomersToSelectPageSize")]
        public bool AllowCustomersToSelectPageSize { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.PageSizeOptions")]
        public string PageSizeOptions { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.PriceRanges")]
        [AllowHtml]
        public string PriceRanges { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.Published")]
        public bool Published { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.Deleted")]
        public bool Deleted { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }
        
        public IList<ManufacturerLocalizedModel> Locales { get; set; }
        
        //ACL
        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.SubjectToAcl")]
        public bool SubjectToAcl { get; set; }
        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.AclCustomerRoles")]
        public List<CustomerRoleModel> AvailableCustomerRoles { get; set; }
        public int[] SelectedCustomerRoleIds { get; set; }

        //Store mapping
        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public int[] SelectedStoreIds { get; set; }


        #region Nested classes

        public partial class ManufacturerProductModel : BaseNasEntityModel
        {
            public int ManufacturerId { get; set; }

            public int ProductId { get; set; }

            [NasResourceDisplayName("Admin.Catalog.Manufacturers.Products.Fields.Product")]
            public string ProductName { get; set; }

            [NasResourceDisplayName("Admin.Catalog.Manufacturers.Products.Fields.IsFeaturedProduct")]
            public bool IsFeaturedProduct { get; set; }

            [NasResourceDisplayName("Admin.Catalog.Manufacturers.Products.Fields.DisplayOrder")]
            //we don't name it DisplayOrder because Telerik has a small bug 
            //"if we have one more editor with the same name on a page, it doesn't allow editing"
            //in our case it's category.DisplayOrder
            public int DisplayOrder1 { get; set; }
        }

        public partial class AddManufacturerProductModel : BaseNasModel
        {
            public AddManufacturerProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
            }
            public GridModel<ProductModel> Products { get; set; }

            [NasResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]
            [AllowHtml]
            public string SearchProductName { get; set; }
            [NasResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
            public int SearchCategoryId { get; set; }
            [NasResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
            public int SearchManufacturerId { get; set; }
            [NasResourceDisplayName("Admin.Catalog.Products.List.SearchStore")]
            public int SearchStoreId { get; set; }
            [NasResourceDisplayName("Admin.Catalog.Products.List.SearchVendor")]
            public int SearchVendorId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }

            public int ManufacturerId { get; set; }

            public int[] SelectedProductIds { get; set; }
        }

        #endregion
    }

    public partial class ManufacturerLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.Description")]
        [AllowHtml]
        public string Description {get;set;}

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.MetaKeywords")]
        [AllowHtml]
        public string MetaKeywords { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.MetaDescription")]
        [AllowHtml]
        public string MetaDescription { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.MetaTitle")]
        [AllowHtml]
        public string MetaTitle { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Manufacturers.Fields.SeName")]
        [AllowHtml]
        public string SeName { get; set; }
    }
}