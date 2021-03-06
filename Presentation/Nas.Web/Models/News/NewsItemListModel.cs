﻿using System.Collections.Generic;
using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.News
{
    public partial class NewsItemListModel : BaseNasModel
    {
        public NewsItemListModel()
        {
            PagingFilteringContext = new NewsPagingFilteringModel();
            NewsItems = new List<NewsItemModel>();
        }

        public int WorkingLanguageId { get; set; }
        public NewsPagingFilteringModel PagingFilteringContext { get; set; }
        public IList<NewsItemModel> NewsItems { get; set; }
    }
}