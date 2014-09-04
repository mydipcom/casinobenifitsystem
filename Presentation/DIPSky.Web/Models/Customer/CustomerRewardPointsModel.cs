using System;
using System.Collections.Generic;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Customer
{
    public partial class CustomerRewardPointsModel : BaseDIPSkyModel
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
        public partial class RewardPointsHistoryModel : BaseDIPSkyEntityModel
        {
            [DipSkyResourceDisplayName("RewardPoints.Fields.Points")]
            public int Points { get; set; }

            [DipSkyResourceDisplayName("RewardPoints.Fields.PointsBalance")]
            public int PointsBalance { get; set; }

            [DipSkyResourceDisplayName("RewardPoints.Fields.Message")]
            public string Message { get; set; }

            [DipSkyResourceDisplayName("RewardPoints.Fields.Date")]
            public DateTime CreatedOn { get; set; }
        }

        #endregion
    }
}