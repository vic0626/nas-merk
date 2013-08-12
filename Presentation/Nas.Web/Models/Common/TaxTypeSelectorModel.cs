using Nas.Core.Domain.Tax;
using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Common
{
    public partial class TaxTypeSelectorModel : BaseNasModel
    {
        public bool Enabled { get; set; }

        public TaxDisplayType CurrentTaxType { get; set; }
    }
}