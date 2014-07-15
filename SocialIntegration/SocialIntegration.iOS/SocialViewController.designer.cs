// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace SocialIntegration.iOS
{
	[Register ("Social")]
	partial class SocialViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton bnt_MobileServices { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btn_FacebookLogin { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btn_FacebookShare { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btn_TwitterLogin { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btn_TwitterShare { get; set; }

		[Action ("btn_FacebookLogin_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn_FacebookLogin_TouchUpInside (MonoTouch.UIKit.UIButton sender);

		[Action ("btn_FacebookShare_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn_FacebookShare_TouchUpInside (MonoTouch.UIKit.UIButton sender);

		[Action ("btn_TwitterLogin_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn_TwitterLogin_TouchUpInside (MonoTouch.UIKit.UIButton sender);

		[Action ("btn_TwitterShare_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn_TwitterShare_TouchUpInside (MonoTouch.UIKit.UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (bnt_MobileServices != null) {
				bnt_MobileServices.Dispose ();
				bnt_MobileServices = null;
			}
			if (btn_FacebookLogin != null) {
				btn_FacebookLogin.Dispose ();
				btn_FacebookLogin = null;
			}
			if (btn_FacebookShare != null) {
				btn_FacebookShare.Dispose ();
				btn_FacebookShare = null;
			}
			if (btn_TwitterLogin != null) {
				btn_TwitterLogin.Dispose ();
				btn_TwitterLogin = null;
			}
			if (btn_TwitterShare != null) {
				btn_TwitterShare.Dispose ();
				btn_TwitterShare = null;
			}
		}
	}
}
