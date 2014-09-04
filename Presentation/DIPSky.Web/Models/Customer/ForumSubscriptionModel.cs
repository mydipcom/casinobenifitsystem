using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Customer
{
    public partial class ForumSubscriptionModel : BaseDIPSkyEntityModel
    {
        public int ForumId { get; set; }
        public int ForumTopicId { get; set; }
        public bool TopicSubscription { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
    }
}
