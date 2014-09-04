using System.Web.Mvc;
using FluentValidation.Attributes;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;
using DIPSky.Web.Validators.ShoppingCart;

namespace DIPSky.Web.Models.ShoppingCart
{
    [Validator(typeof(WishlistEmailAFriendValidator))]
    public partial class WishlistEmailAFriendModel : BaseDIPSkyModel
    {
        [AllowHtml]
        [DipSkyResourceDisplayName("Wishlist.EmailAFriend.FriendEmail")]
        public string FriendEmail { get; set; }

        [AllowHtml]
        [DipSkyResourceDisplayName("Wishlist.EmailAFriend.YourEmailAddress")]
        public string YourEmailAddress { get; set; }

        [AllowHtml]
        [DipSkyResourceDisplayName("Wishlist.EmailAFriend.PersonalMessage")]
        public string PersonalMessage { get; set; }

        public bool SuccessfullySent { get; set; }
        public string Result { get; set; }

        public bool DisplayCaptcha { get; set; }
    }
}