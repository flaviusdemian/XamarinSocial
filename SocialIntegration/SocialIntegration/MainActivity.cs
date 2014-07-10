using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Android.Widget;
using SocialIntegrationCore.Implementation;
using Xamarin.Social;

namespace SocialIntegration
{
    [Activity(Label = "SocialIntegration", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //private ISocialMediaProvider SocialMediaProvider = null;
        //private SocialMediaProviderType SocialMediaProviderType = SocialMediaProviderType.Facebook;


        private const string FacebookAppId = "185496498241687";
        private const string ClientSecret = "5a8688b78f9c039209d0ce4f59345936";

        private const string TwitterConsumerKey = "24OlU6wOSTV6KqMQgXpmg";
        private const string TwitterConsumerSecret = "VmEbCKRgm8cLx9f8j9FbOGwNUfwd6uBksDJ47q0ysTs";

        private Button btn_LoginWithFacebook, btn_LoginWithtwitter, btn_ShareWithFacebook, btn_ShareWithtwitter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            btn_LoginWithFacebook = FindViewById<Button>(Resource.Id.LoginFacebookButton);
            btn_LoginWithFacebook.Click += (sender, args) => LoginWithFacebook();

            btn_LoginWithtwitter = FindViewById<Button>(Resource.Id.LoginTwitterButton);
            btn_LoginWithtwitter.Click += (sender, args) => LoginWithTwitter();

            btn_ShareWithFacebook = FindViewById<Button>(Resource.Id.ShareFacebookButton);
            btn_ShareWithFacebook.Click += async (sender, args) => await ShareWithFacebook();

            btn_ShareWithtwitter = FindViewById<Button>(Resource.Id.ShareTwitterButton);
            btn_ShareWithtwitter.Click += async (sender, args) => await ShareWithTwitter();
        }

        private void LoginWithFacebook()
        {
            try
            {
                var socialMediaProvider = new FacebookProvider(FacebookAppId, ClientSecret, this);
                socialMediaProvider.Login(this);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void LoginWithTwitter()
        {
            try
            {
                var socialMediaProvider = new TwitterProvider(TwitterConsumerKey, TwitterConsumerSecret, "https://demoflavius.azure-mobile.net");
                socialMediaProvider.Login(this);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private async Task ShareWithTwitter()
        {
            try
            {
                var socialMediaProvider = new TwitterProvider(TwitterConsumerKey, TwitterConsumerSecret, "https://demoflavius.azure-mobile.net");
                var item = new Item
                {
                    Text = "I'm sharing great things using #Xamarin #FTW!",
                    Links = new List<Uri>
                    {
                        new Uri("http://xamarin.com"),
                    },
                };
                await socialMediaProvider.Post(this, item);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private async Task ShareWithFacebook()
        {
            try
            {
                var socialMediaProvider = new FacebookProvider(FacebookAppId, ClientSecret, this);
                var item = new Item
                {
                    Text = "I'm sharing great things using #Xamarin #FTW!",
                    Links = new List<Uri>
                    {
                        new Uri("http://xamarin.com"),
                    },
                };
                await socialMediaProvider.Post(this, item);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}