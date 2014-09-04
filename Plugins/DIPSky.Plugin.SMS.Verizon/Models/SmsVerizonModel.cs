using DIPSky.Web.Framework;

namespace DIPSky.Plugin.Sms.Verizon.Models
{
    public class SmsVerizonModel
    {
        [DipSkyResourceDisplayName("Plugins.Sms.Verizon.Fields.Enabled")]
        public bool Enabled { get; set; }
        
        [DipSkyResourceDisplayName("Plugins.Sms.Verizon.Fields.Email")]
        public string Email { get; set; }

        [DipSkyResourceDisplayName("Plugins.Sms.Verizon.Fields.TestMessage")]
        public string TestMessage { get; set; }
        public string TestSmsResult { get; set; }
    }
}