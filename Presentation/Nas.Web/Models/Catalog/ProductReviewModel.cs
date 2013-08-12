﻿using System.Collections.Generic;
using System.Web.Mvc;
using FluentValidation.Attributes;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;
using Nas.Web.Validators.Catalog;

namespace Nas.Web.Models.Catalog
{
    public partial class ProductReviewOverviewModel : BaseNasModel
    {
        public int ProductId { get; set; }

        public int RatingSum { get; set; }

        public int TotalReviews { get; set; }

        public bool AllowCustomerReviews { get; set; }
    }

    [Validator(typeof(ProductReviewsValidator))]
    public partial class ProductReviewsModel : BaseNasModel
    {
        public ProductReviewsModel()
        {
            Items = new List<ProductReviewModel>();
            AddProductReview = new AddProductReviewModel();
        }
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductSeName { get; set; }

        public IList<ProductReviewModel> Items { get; set; }
        public AddProductReviewModel AddProductReview { get; set; }
    }

    public partial class ProductReviewModel : BaseNasEntityModel
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public bool AllowViewingProfiles { get; set; }
        
        public string Title { get; set; }

        public string ReviewText { get; set; }

        public int Rating { get; set; }

        public ProductReviewHelpfulnessModel Helpfulness { get; set; }

        public string WrittenOnStr { get; set; }
    }


    public partial class ProductReviewHelpfulnessModel : BaseNasModel
    {
        public int ProductReviewId { get; set; }

        public int HelpfulYesTotal { get; set; }

        public int HelpfulNoTotal { get; set; }
    }

    public partial class AddProductReviewModel : BaseNasModel
    {
        [AllowHtml]
        [NasResourceDisplayName("Reviews.Fields.Title")]
        public string Title { get; set; }

        [AllowHtml]
        [NasResourceDisplayName("Reviews.Fields.ReviewText")]
        public string ReviewText { get; set; }

        [NasResourceDisplayName("Reviews.Fields.Rating")]
        public int Rating { get; set; }

        public bool DisplayCaptcha { get; set; }

        public bool CanCurrentCustomerLeaveReview { get; set; }
        public bool SuccessfullyAdded { get; set; }
        public string Result { get; set; }
    }
}