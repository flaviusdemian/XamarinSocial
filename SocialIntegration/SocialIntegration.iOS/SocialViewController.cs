
using System;
using System.Collections.Generic;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using SocialIntegration.Core.iOS.Implementation;
using Xamarin.Social;
using System.Threading.Tasks;

namespace SocialIntegration.iOS
{
    public partial class SocialViewController : UIViewController
    {
        private const string FacebookAppId = "185496498241687";
        private const string ClientSecret = "5a8688b78f9c039209d0ce4f59345936";

        private const string TwitterConsumerKey = "24OlU6wOSTV6KqMQgXpmg";
        private const string TwitterConsumerSecret = "VmEbCKRgm8cLx9f8j9FbOGwNUfwd6uBksDJ47q0ysTs";

        static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public SocialViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion

        async partial void btn_FacebookLogin_TouchUpInside(UIButton sender)
        {
            var socialMediaProvider = new FacebookProvider(FacebookAppId, ClientSecret, this);
            socialMediaProvider.Login(this);
        }

        async partial void btn_TwitterLogin_TouchUpInside(UIButton sender)
        {
            var socialMediaProvider = new TwitterProvider(TwitterConsumerKey, TwitterConsumerSecret, "http://www.google.ro");
            socialMediaProvider.Login(this);
        }

        async partial void btn_FacebookShare_TouchUpInside(UIButton sender)
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
                Task.Factory.StartNew(() => { socialMediaProvider.Post(this, item); });
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        async partial void btn_TwitterShare_TouchUpInside(UIButton sender)
        {
            try
            {
                var socialMediaProvider = new TwitterProvider(TwitterConsumerKey, TwitterConsumerSecret, "http://www.google.ro");
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