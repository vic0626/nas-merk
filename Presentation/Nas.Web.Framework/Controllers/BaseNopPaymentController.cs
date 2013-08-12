using System.Collections.Generic;
using System.Web.Mvc;
using Nas.Services.Payments;

namespace Nas.Web.Framework.Controllers
{
    public abstract class BaseNasPaymentController : Controller
    {
        public abstract IList<string> ValidatePaymentForm(FormCollection form);
        public abstract ProcessPaymentRequest GetPaymentInfo(FormCollection form);
    }
}
