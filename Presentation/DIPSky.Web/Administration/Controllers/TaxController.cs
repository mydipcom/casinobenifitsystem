﻿using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using DIPSky.Admin.Models.Tax;
using DIPSky.Core.Domain.Tax;
using DIPSky.Services.Configuration;
using DIPSky.Services.Security;
using DIPSky.Services.Tax;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Controllers;
using Telerik.Web.Mvc;

namespace DIPSky.Admin.Controllers
{
	[AdminAuthorize]
    public partial class TaxController : BaseDIPSkyController
	{
		#region Fields

        private readonly ITaxService _taxService;
        private readonly ITaxCategoryService _taxCategoryService;
        private readonly TaxSettings _taxSettings;
        private readonly ISettingService _settingService;
        private readonly IPermissionService _permissionService;

	    #endregion

		#region Constructors

        public TaxController(ITaxService taxService,
            ITaxCategoryService taxCategoryService, TaxSettings taxSettings,
            ISettingService settingService, IPermissionService permissionService)
		{
            this._taxService = taxService;
            this._taxCategoryService = taxCategoryService;
            this._taxSettings = taxSettings;
            this._settingService = settingService;
            this._permissionService = permissionService;
		}

		#endregion 

        #region Tax Providers

        public ActionResult Providers()
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTaxSettings))
                return AccessDeniedView();
            
            return View();
        }

        [HttpPost, GridAction(EnableCustomBinding = true)]
        public ActionResult Providers(GridCommand command)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTaxSettings))
                return AccessDeniedView();

            var taxProvidersModel = _taxService.LoadAllTaxProviders()
                .Select(x => x.ToModel())
                .ForCommand(command)
                .ToList();
            foreach (var tpm in taxProvidersModel)
                tpm.IsPrimaryTaxProvider = tpm.SystemName.Equals(_taxSettings.ActiveTaxProviderSystemName, StringComparison.InvariantCultureIgnoreCase);
            var gridModel = new GridModel<TaxProviderModel>
            {
                Data = taxProvidersModel,
                Total = taxProvidersModel.Count()
            };
            return new JsonResult
            {
                Data = gridModel
            };
        }

        public ActionResult ConfigureProvider(string systemName)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTaxSettings))
                return AccessDeniedView();

            var taxProvider = _taxService.LoadTaxProviderBySystemName(systemName);
            if (taxProvider == null)
                //No tax provider found with the specified id
                return RedirectToAction("Providers");

            var model = taxProvider.ToModel();
            string actionName, controllerName;
            RouteValueDictionary routeValues;
            taxProvider.GetConfigurationRoute(out actionName, out controllerName, out routeValues);
            model.ConfigurationActionName = actionName;
            model.ConfigurationControllerName = controllerName;
            model.ConfigurationRouteValues = routeValues;
            return View(model);
        }

        public ActionResult MarkAsPrimaryProvider(string systemName)
        {
            if (String.IsNullOrEmpty(systemName))
            {
                return RedirectToAction("Providers");
            }

            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTaxSettings))
                return AccessDeniedView();

            var taxProvider = _taxService.LoadTaxProviderBySystemName(systemName);
            if (taxProvider != null)
            {
                _taxSettings.ActiveTaxProviderSystemName = systemName;
                _settingService.SaveSetting(_taxSettings);
            }

            return RedirectToAction("Providers");
        }

        #endregion

        #region Tax Categories

        public ActionResult Categories()
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTaxSettings))
                return AccessDeniedView();

            return View();
        }

        [HttpPost, GridAction(EnableCustomBinding = true)]
        public ActionResult Categories(GridCommand command)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTaxSettings))
                return AccessDeniedView();

            var categoriesModel = _taxCategoryService.GetAllTaxCategories()
                .Select(x => x.ToModel())
                .ForCommand(command)
                .ToList();
            var model = new GridModel<TaxCategoryModel>
            {
                Data = categoriesModel,
                Total = categoriesModel.Count
            };

            return new JsonResult
            {
                Data = model
            };
        }

        [GridAction(EnableCustomBinding = true)]
        public ActionResult CategoryUpdate(TaxCategoryModel model, GridCommand command)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTaxSettings))
                return AccessDeniedView();

            if (!ModelState.IsValid)
            {
                //display the first model error
                var modelStateErrors = this.ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage);
                return Content(modelStateErrors.FirstOrDefault());
            }

            var taxCategory = _taxCategoryService.GetTaxCategoryById(model.Id);
            taxCategory = model.ToEntity(taxCategory);
            _taxCategoryService.UpdateTaxCategory(taxCategory);

            return Categories(command);
        }

        [GridAction(EnableCustomBinding = true)]
        public ActionResult CategoryAdd([Bind(Exclude = "Id")] TaxCategoryModel model, GridCommand command)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTaxSettings))
                return AccessDeniedView();

            if (!ModelState.IsValid)
            {
                //display the first model error
                var modelStateErrors = this.ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage);
                return Content(modelStateErrors.FirstOrDefault());
            }

            var taxCategory = new TaxCategory();
            taxCategory = model.ToEntity(taxCategory);
            _taxCategoryService.InsertTaxCategory(taxCategory);

            return Categories(command);
        }

        [GridAction(EnableCustomBinding = true)]
        public ActionResult CategoryDelete(int id, GridCommand command)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTaxSettings))
                return AccessDeniedView();

            var taxCategory = _taxCategoryService.GetTaxCategoryById(id);
            if (taxCategory == null)
                throw new ArgumentException("No tax category found with the specified id");
            _taxCategoryService.DeleteTaxCategory(taxCategory);

            return Categories(command);
        }

        #endregion
    }
}
