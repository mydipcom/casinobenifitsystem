﻿using DIPSky.Core;
using DIPSky.Core.Infrastructure;
using DIPSky.Services.Localization;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Framework
{
    public class DipSkyResourceDisplayName : System.ComponentModel.DisplayNameAttribute, IModelAttribute
    {
        private string _resourceValue = string.Empty;
        //private bool _resourceValueRetrived;

        public DipSkyResourceDisplayName(string resourceKey)
            : base(resourceKey)
        {
            ResourceKey = resourceKey;
        }

        public string ResourceKey { get; set; }

        public override string DisplayName
        {
            get
            {
                //do not cache resources because it causes issues when you have multiple languages
                //if (!_resourceValueRetrived)
                //{
                var langId = EngineContext.Current.Resolve<IWorkContext>().WorkingLanguage.Id;
                    _resourceValue = EngineContext.Current
                        .Resolve<ILocalizationService>()
                        .GetResource(ResourceKey, langId, true, ResourceKey);
                //    _resourceValueRetrived = true;
                //}
                return _resourceValue;
            }
        }

        public string Name
        {
            get { return "DIPSkyResourceDisplayName"; }
        }
    }
}
