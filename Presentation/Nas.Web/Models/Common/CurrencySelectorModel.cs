using System.Collections.Generic;
using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Common
{
    public partial class CurrencySelectorModel : BaseNasModel
    {
        public CurrencySelectorModel()
        {
            AvailableCurrencies = new List<CurrencyModel>();
        }

        public IList<CurrencyModel> AvailableCurrencies { get; set; }

        public int CurrentCurrencyId { get; set; }
    }
}