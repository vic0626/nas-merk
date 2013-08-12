using Nas.Web.Framework;

namespace Nas.Plugin.Sms.Verizon.Models
{
    public class SmsVerizonModel
    {
        [NasResourceDisplayName("Plugins.Sms.Verizon.Fields.Enabled")]
        public bool Enabled { get; set; }
        
        [NasResourceDisplayName("Plugins.Sms.Verizon.Fields.Email")]
        public string Email { get; set; }

        [NasResourceDisplayName("Plugins.Sms.Verizon.Fields.TestMessage")]
        public string TestMessage { get; set; }
        public string TestSmsResult { get; set; }
    }
}