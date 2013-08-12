using System;
using System.Collections.Generic;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Customer
{
    public partial class CustomerRewardPointsModel : BaseNasModel
    {
        public CustomerRewardPointsModel()
        {
            RewardPoints = new List<RewardPointsHistoryModel>();
        }

        public IList<RewardPointsHistoryModel> RewardPoints { get; set; }
        public int RewardPointsBalance { get; set; }
        public string RewardPointsAmount { get; set; }
        public int MinimumRewardPointsBalance { get; set; }
        public string MinimumRewardPointsAmount { get; set; }
        public CustomerNavigationModel NavigationModel { get; set; }

        #region Nested classes
        public partial class RewardPointsHistoryModel : BaseNasEntityModel
        {
            [NasResourceDisplayName("RewardPoints.Fields.Points")]
            public int Points { get; set; }

            [NasResourceDisplayName("RewardPoints.Fields.PointsBalance")]
            public int PointsBalance { get; set; }

            [NasResourceDisplayName("RewardPoints.Fields.Message")]
            public string Message { get; set; }

            [NasResourceDisplayName("RewardPoints.Fields.Date")]
            public DateTime CreatedOn { get; set; }
        }

        #endregion
    }
}