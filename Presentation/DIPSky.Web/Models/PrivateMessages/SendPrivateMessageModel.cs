using System.Web.Mvc;
using FluentValidation.Attributes;
using DIPSky.Web.Framework.Mvc;
using DIPSky.Web.Validators.PrivateMessages;

namespace DIPSky.Web.Models.PrivateMessages
{
    [Validator(typeof(SendPrivateMessageValidator))]
    public partial class SendPrivateMessageModel : BaseDIPSkyEntityModel
    {
        public int ToCustomerId { get; set; }
        public string CustomerToName { get; set; }
        public bool AllowViewingToProfile { get; set; }

        public int ReplyToMessageId { get; set; }

        [AllowHtml]
        public string Subject { get; set; }

        [AllowHtml]
        public string Message { get; set; }
    }
}