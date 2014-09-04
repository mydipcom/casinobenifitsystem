using System.Collections.Generic;
using System.Web.Mvc;
using DIPSky.Services.Payments;

namespace DIPSky.Web.Framework.Controllers
{
    public abstract class BaseDIPSkyPaymentController : Controller
    {
        public abstract IList<string> ValidatePaymentForm(FormCollection form);
        public abstract ProcessPaymentRequest GetPaymentInfo(FormCollection form);
    }
}
