using System.Collections.Generic;
using DIPSky.Core.Domain.Blogs;
using DIPSky.Core.Domain.Catalog;
using DIPSky.Core.Domain.Customers;
using DIPSky.Core.Domain.Forums;
using DIPSky.Core.Domain.Messages;
using DIPSky.Core.Domain.News;
using DIPSky.Core.Domain.Orders;
using DIPSky.Core.Domain.Shipping;
using DIPSky.Core.Domain.Stores;

namespace DIPSky.Services.Messages
{
    public partial interface IMessageTokenProvider
    {
        void AddStoreTokens(IList<Token> tokens, Store store);

        void AddOrderTokens(IList<Token> tokens, Order order, int languageId);

        void AddShipmentTokens(IList<Token> tokens, Shipment shipment, int languageId);

        void AddOrderNoteTokens(IList<Token> tokens, OrderNote orderNote);

        void AddRecurringPaymentTokens(IList<Token> tokens, RecurringPayment recurringPayment);

        void AddReturnRequestTokens(IList<Token> tokens, ReturnRequest returnRequest, OrderItem orderItem);

        void AddGiftCardTokens(IList<Token> tokens, GiftCard giftCard);

        void AddCustomerTokens(IList<Token> tokens, Customer customer);

        void AddNewsLetterSubscriptionTokens(IList<Token> tokens, NewsLetterSubscription subscription);

        void AddProductReviewTokens(IList<Token> tokens, ProductReview productReview);

        void AddBlogCommentTokens(IList<Token> tokens, BlogComment blogComment);

        void AddNewsCommentTokens(IList<Token> tokens, NewsComment newsComment);

        void AddProductTokens(IList<Token> tokens, Product product, int languageId);

        void AddForumTokens(IList<Token> tokens, Forum forum);

        void AddForumTopicTokens(IList<Token> tokens, ForumTopic forumTopic,
            int? friendlyForumTopicPageIndex = null, int? appendedPostIdentifierAnchor = null);

        void AddForumPostTokens(IList<Token> tokens, ForumPost forumPost);

        void AddPrivateMessageTokens(IList<Token> tokens, PrivateMessage privateMessage);

        void AddBackInStockTokens(IList<Token> tokens, BackInStockSubscription subscription);

        string[] GetListOfCampaignAllowedTokens();

        string[] GetListOfAllowedTokens();
    }
}
