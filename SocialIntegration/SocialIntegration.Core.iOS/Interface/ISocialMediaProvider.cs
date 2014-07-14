
using System;
using System.Threading.Tasks;
using MonoTouch.UIKit;
using Xamarin.Social;


namespace SocialIntegration.Core.iOS.Interface
{
    public interface ISocialMediaProvider
    {
        String AccessToken { get; set; }

        String AccessTokenSecret { get; set; }
        void Login(UIViewController destinationActivity);

        Task<bool> Post(UIViewController destinationActivity, Item item);
    }
}