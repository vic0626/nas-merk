﻿using FluentValidation.Attributes;
using Nas.Admin.Validators.Settings;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Settings
{
    [Validator(typeof(RewardPointsSettingsValidator))]
    public partial class RewardPointsSettingsModel : BaseNasModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }


        [NasResourceDisplayName("Admin.Configuration.Settings.RewardPoints.Enabled")]
        public bool Enabled { get; set; }
        public bool Enabled_OverrideForStore { get; set; }

        [NasResourceDisplayName("Admin.Configuration.Settings.RewardPoints.ExchangeRate")]
        public decimal ExchangeRate { get; set; }
        public bool ExchangeRate_OverrideForStore { get; set; }

        [NasResourceDisplayName("Admin.Configuration.Settings.RewardPoints.MinimumRewardPointsToUse")]
        public int MinimumRewardPointsToUse { get; set; }
        public bool MinimumRewardPointsToUse_OverrideForStore { get; set; }

        [NasResourceDisplayName("Admin.Configuration.Settings.RewardPoints.PointsForRegistration")]
        public int PointsForRegistration { get; set; }
        public bool PointsForRegistration_OverrideForStore { get; set; }

        [NasResourceDisplayName("Admin.Configuration.Settings.RewardPoints.PointsForPurchases_Amount")]
        public decimal PointsForPurchases_Amount { get; set; }
        public int PointsForPurchases_Points { get; set; }
        public bool PointsForPurchases_OverrideForStore { get; set; }

        [NasResourceDisplayName("Admin.Configuration.Settings.RewardPoints.PointsForPurchases_Awarded")]
        public int PointsForPurchases_Awarded { get; set; }
        public bool PointsForPurchases_Awarded_OverrideForStore { get; set; }

        [NasResourceDisplayName("Admin.Configuration.Settings.RewardPoints.PointsForPurchases_Canceled")]
        public int PointsForPurchases_Canceled { get; set; }
        public bool PointsForPurchases_Canceled_OverrideForStore { get; set; }

        public string PrimaryStoreCurrencyCode { get; set; }
    }
}