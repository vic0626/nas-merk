using System.Collections.Generic;
using FluentValidation.Attributes;
using Nas.Admin.Validators.Vendors;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Vendors
{
    [Validator(typeof(VendorValidator))]
    public partial class VendorModel : BaseNasEntityModel
    {
        public VendorModel()
        {
            AssociatedCustomerEmails = new List<string>();
        }

        [NasResourceDisplayName("Admin.Vendors.Fields.Name")]
        public string Name { get; set; }

        [NasResourceDisplayName("Admin.Vendors.Fields.Email")]
        public string Email { get; set; }

        [NasResourceDisplayName("Admin.Vendors.Fields.Description")]
        public string Description { get; set; }

        [NasResourceDisplayName("Admin.Vendors.Fields.AdminComment")]
        public string AdminComment { get; set; }

        [NasResourceDisplayName("Admin.Vendors.Fields.Active")]
        public bool Active { get; set; }

        [NasResourceDisplayName("Admin.Vendors.Fields.AssociatedCustomerEmails")]
        public IList<string> AssociatedCustomerEmails { get; set; }
    }
}