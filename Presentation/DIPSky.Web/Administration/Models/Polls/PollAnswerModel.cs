using System.Web.Mvc;
using FluentValidation.Attributes;
using DIPSky.Admin.Validators.Polls;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Polls
{
    [Validator(typeof(PollAnswerValidator))]
    public partial class PollAnswerModel : BaseDIPSkyEntityModel
    {
        public int PollId { get; set; }

        [DipSkyResourceDisplayName("Admin.ContentManagement.Polls.Answers.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [DipSkyResourceDisplayName("Admin.ContentManagement.Polls.Answers.Fields.NumberOfVotes")]
        public int NumberOfVotes { get; set; }

        [DipSkyResourceDisplayName("Admin.ContentManagement.Polls.Answers.Fields.DisplayOrder")]
        //we don't name it "DisplayOrder" because Telerik has a small bug 
        //"if we have one more editor with the same name on a page, it doesn't allow editing"
        //in our case it's pollAnswer.DisplayOrder
        public int DisplayOrder1 { get; set; }

    }
}