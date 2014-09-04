﻿using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Plugin.Payments.AuthorizeNet.Models
{
    public class ConfigurationModel : BaseDIPSkyModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        [DipSkyResourceDisplayName("Plugins.Payments.AuthorizeNet.Fields.UseSandbox")]
        public bool UseSandbox { get; set; }
        public bool UseSandbox_OverrideForStore { get; set; }

        public int TransactModeId { get; set; }
        public bool TransactModeId_OverrideForStore { get; set; }
        [DipSkyResourceDisplayName("Plugins.Payments.AuthorizeNet.Fields.TransactModeValues")]
        public SelectList TransactModeValues { get; set; }

        [DipSkyResourceDisplayName("Plugins.Payments.AuthorizeNet.Fields.TransactionKey")]
        public string TransactionKey { get; set; }
        public bool TransactionKey_OverrideForStore { get; set; }

        [DipSkyResourceDisplayName("Plugins.Payments.AuthorizeNet.Fields.LoginId")]
        public string LoginId { get; set; }
        public bool LoginId_OverrideForStore { get; set; }

        [DipSkyResourceDisplayName("Plugins.Payments.AuthorizeNet.Fields.AdditionalFee")]
        public decimal AdditionalFee { get; set; }
        public bool AdditionalFee_OverrideForStore { get; set; }

        [DipSkyResourceDisplayName("Plugins.Payments.AuthorizeNet.Fields.AdditionalFeePercentage")]
        public bool AdditionalFeePercentage { get; set; }
        public bool AdditionalFeePercentage_OverrideForStore { get; set; }
    }
}