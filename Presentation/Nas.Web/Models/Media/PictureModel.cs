using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Media
{
    public partial class PictureModel : BaseNasModel
    {
        public string ImageUrl { get; set; }

        public string FullSizeImageUrl { get; set; }

        public string Title { get; set; }

        public string AlternateText { get; set; }
    }
}