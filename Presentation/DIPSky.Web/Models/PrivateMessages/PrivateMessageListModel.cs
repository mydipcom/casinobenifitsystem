using System.Collections.Generic;
using DIPSky.Web.Models.Common;

namespace DIPSky.Web.Models.PrivateMessages
{
    public partial class PrivateMessageListModel
    {
        public IList<PrivateMessageModel> Messages { get; set; }
        public PagerModel PagerModel { get; set; }
    }
}