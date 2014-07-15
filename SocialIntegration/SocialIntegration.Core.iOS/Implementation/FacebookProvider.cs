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
    public class FacebookProvider : ISocialMediaProvider
    {
        private FacebookService _FacebookService = new FacebookService();
        private static Account _Account;

        public String AccessToken { get; set; }
        public String AccessTokenSecret { get; set; }

        public FacebookProvider(string facebookAppId, string clientSecret, UIViewController destinationActivity)
        {
            _FacebookService.ClientId = facebookAppId;
            _FacebookService.ClientSecret = clientSecret;
        }

        public void Login(UIViewController viewController)
        {
            try
            {
                UIViewController controler = _FacebookService.GetAuthenticateUI(account =>
                {
                    if (account != null)
                    {
                        AccessToken = account.Properties["access_token"];
                        _Account = account;
                        viewController.DismissViewController(true, null);
                    }
                });
                viewController.PresentViewController(controler, true, null);
            }
            catch (Exception ex)
            {
                var s = ex.StackTrace;
                ex.ToString();
            }
        }

        public async Task<bool> Post(UIViewController destinationActivity, Item item)
        {
            bool result = false;
            try
            {
                #region ShareUI
                //Intent intent = _FacebookService.GetShareUI(destinationActivity, item, shareResult =>
                //{
                //    int x = 0;
                //    x++;
                //    result = true;
                //    //update UI
                //    //shareButton.Text = service.Title + " shared: " + shareResult;
                //});
                #endregion

                IDictionary<String, String> items = new Dictionary<string, string>();
                items.Add("message", "I'm sharing great things using #Xamarin #FTW!");
                items.Add("link", "http://xamarin.com");

                Request request = _FacebookService.CreateRequest("POST", new Uri("https://graph.facebook.com/v2.0/me/feed"), items, _Account);
                var response = await request.GetResponseAsync();
                var content = response.GetResponseText();
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