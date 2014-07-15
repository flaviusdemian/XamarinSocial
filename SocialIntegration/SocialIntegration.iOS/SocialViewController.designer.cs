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
		UIButton btn_FacebookLogin { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_FacebookShare { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_TwitterLogin { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_TwitterShare { get; set; }

		[Action ("btn_FacebookLogin_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn_FacebookLogin_TouchUpInside (UIButton sender);

		[Action ("btn_FacebookShare_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn_FacebookShare_TouchUpInside (UIButton sender);

		[Action ("btn_TwitterLogin_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn_TwitterLogin_TouchUpInside (UIButton sender);

		[Action ("btn_TwitterShare_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn_TwitterShare_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
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
