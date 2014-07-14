using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonoTouch.UIKit;
using SocialIntegration.Core.iOS.Interface;
using Xamarin.Auth;
using Xamarin.Social;
using Xamarin.Social.Services;


namespace SocialIntegration.Core.iOS.Implementation
{
    public class TwitterProvider : ISocialMediaProvider
    {
        private TwitterService _TwitterService = new TwitterService();
        private static Account _Account;

        public String AccessToken { get; set; }
        public String AccessTokenSecret { get; set; }

        public TwitterProvider(string twitterConsumerKey, string twitterConsumerSecret, string callbackUrl)
        {
            _TwitterService.ConsumerKey = twitterConsumerKey;
            _TwitterService.ConsumerSecret = twitterConsumerSecret;
            _TwitterService.CallbackUrl = new Uri(callbackUrl);
        }

        public void Login(UIViewController destinationActivity)
        {
            try
            {
                UIViewController controler = _TwitterService.GetAuthenticateUI(account =>
                {
                    if (account != null)
                    {
                        _Account = account;
                        AccessToken = account.Properties["oauth_token"];
                        AccessTokenSecret = account.Properties["oauth_token_secret"];
                        //DismissViewController (true, null);
                    }
                });
                //PresentViewController(shareController, true, null);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public async Task<bool> Post(UIViewController destinationActivity, Item item)
        {
            bool result = false;
            try
            {
                IDictionary<String, String> items = new Dictionary<string, string>();
                items.Add("status", "I'm sharing great things using #Xamarin #FTW!");

                Request request = _TwitterService.CreateRequest("POST", new Uri("https://api.twitter.com/1.1/statuses/update.json"), items, _Account);
                var response = await request.GetResponseAsync();
                var content = response.GetResponseText();
                //if (String.IsNullOrWhiteSpace(content) == false)
                //{

                //}
            }
            catch (Exception ex)
            {
                var s = ex.StackTrace;
                ex.ToString();
            }
            return result;
        }
    }
}