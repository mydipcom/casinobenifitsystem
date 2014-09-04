﻿using System;
using FluentValidation.Attributes;
using DIPSky.Web.Framework.Mvc;
using DIPSky.Web.Validators.PrivateMessages;

namespace DIPSky.Web.Models.PrivateMessages
{
    [Validator(typeof(SendPrivateMessageValidator))]
    public partial class PrivateMessageModel : BaseDIPSkyEntityModel
    {
        public int FromCustomerId { get; set; }
        public string CustomerFromName { get; set; }
        public bool AllowViewingFromProfile { get; set; }

        public int ToCustomerId { get; set; }
        public string CustomerToName { get; set; }
        public bool AllowViewingToProfile { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
        
        public DateTime CreatedOn { get; set; }

        public bool IsRead { get; set; }
    }
}