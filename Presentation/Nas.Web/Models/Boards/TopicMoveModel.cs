using System.Collections.Generic;
using System.Web.Mvc;
using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Boards
{
    public partial class TopicMoveModel : BaseNasEntityModel
    {
        public TopicMoveModel()
        {
            ForumList = new List<SelectListItem>();
        }

        public int ForumSelected { get; set; }
        public string TopicSeName { get; set; }

        public IEnumerable<SelectListItem> ForumList { get; set; }
    }
}