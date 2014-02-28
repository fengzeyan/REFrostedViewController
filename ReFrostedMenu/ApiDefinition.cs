using System.Drawing;
using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;

namespace REFrostedMenu 
{
	public delegate void HideWithCallback ();

	[BaseType (typeof (UIViewController))]
	public partial interface REFrostedContainerViewController 
	{	
		[Export ("screenshotImage", ArgumentSemantic.Retain)]
		UIImage ScreenshotImage { get; set; }

		[Export ("frostedViewController", ArgumentSemantic.Assign)]
		REFrostedViewController FrostedViewController { get; set; }

		[Export ("animateApperance")]
		bool AnimateApperance { get; set; }

		[Export ("containerView", ArgumentSemantic.Retain)]
		UIView ContainerView { get; }

		[Export ("panGestureRecognized:")]
		void PanGestureRecognized (UIPanGestureRecognizer recognizer);

		[Export ("hide")]
		void Hide ();

		[Export ("resizeToSize:")]
		void REsizeToSize (SizeF size);

		[Export ("hideWithCompletionHandler:")]
		void HideWithCompletionHandler (HideWithCallback completionHandler);

		[Export ("refreshBackgroundImage")]
		void REfreshBackgroundImage ();
	}

	[BaseType (typeof (UIViewController))]
	public partial interface REFrostedViewController {

		[Export ("panGestureRecognizer", ArgumentSemantic.Retain)]
		UIPanGestureRecognizer PanGestureRecognizer { get; }

		[Export ("panGestureEnabled")]
		bool PanGestureEnabled { get; set; }

		[Export ("direction")]
		REFrostedViewControllerDirection Direction { get; set; }

		[Export ("backgroundFadeAmount")]
		float BackgroundFadeAmount { get; set; }

		[Export ("blurTintColor", ArgumentSemantic.Retain)]
		UIColor BlurTintColor { get; set; }

		[Export ("blurRadius")]
		float BlurRadius { get; set; }

		[Export ("blurSaturationDeltaFactor")]
		float BlurSaturationDeltaFactor { get; set; }

		[Export ("animationDuration")]
		double AnimationDuration { get; set; }

		[Export ("limitMenuViewSize")]
		bool LimitMenuViewSize { get; set; }

		[Export ("menuViewSize", ArgumentSemantic.Assign)]
		SizeF MenuViewSize { get; set; }

		[Export ("liveBlur")]
		bool LiveBlur { get; set; }

		[Export ("liveBlurBackgroundStyle")]
		REFrostedViewControllerLiveBackgroundStyle LiveBlurBackgroundStyle { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		REFrostedViewControllerDelegate Delegate { get; set; }

		[Export ("contentViewController", ArgumentSemantic.Retain)]
		UIViewController ContentViewController { get; set; }

		[Export ("menuViewController", ArgumentSemantic.Retain)]
		UIViewController MenuViewController { get; set; }

		[Export ("initWithContentViewController:menuViewController:")]
		IntPtr Constructor (UIViewController contentViewController, UIViewController menuViewController);

		[Export ("presentMenuViewController")]
		void PresentMenuViewController ();

		[Export ("hideMenuViewController")]
		void HideMenuViewController ();

		[Export ("resizeMenuViewControllerToSize:")]
		void REsizeMenuViewControllerToSize (SizeF size);

		[Export ("hideMenuViewControllerWithCompletionHandler:")]
		void HideMenuViewControllerWithCompletionHandler (HideWithCallback completionHandler);

		[Export ("panGestureRecognized:")]
		void PanGestureRecognized (UIPanGestureRecognizer recognizer);
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface REFrostedViewControllerDelegate {

		[Export ("frostedViewController:willAnimateRotationToInterfaceOrientation:duration:")]
		void WillAnimateRotationToInterfaceOrientation (REFrostedViewController frostedViewController, UIInterfaceOrientation toInterfaceOrientation, double duration);

		[Export ("frostedViewController:didREcognizePanGesture:")]
		void DidRecognizePanGesture (REFrostedViewController frostedViewController, UIPanGestureRecognizer recognizer);

		[Export ("frostedViewController:willShowMenuViewController:")]
		void WillShowMenuViewController (REFrostedViewController frostedViewController, UIViewController menuViewController);

		[Export ("frostedViewController:didShowMenuViewController:")]
		void DidShowMenuViewController (REFrostedViewController frostedViewController, UIViewController menuViewController);

		[Export ("frostedViewController:willHideMenuViewController:")]
		void WillHideMenuViewController (REFrostedViewController frostedViewController, UIViewController menuViewController);

		[Export ("frostedViewController:didHideMenuViewController:")]
		void DidHideMenuViewController (REFrostedViewController frostedViewController, UIViewController menuViewController);
	}

	[Category, BaseType (typeof (UIImage))]
	public partial interface REFrostedViewController_UIImage {

		[Export ("re_applyBlurWithRadius:tintColor:saturationDeltaFactor:maskImage:")]
		UIImage REApplyBlurWithRadius (float blurRadius, UIColor tintColor, float saturationDeltaFactor, UIImage maskImage);
	}

	[Category, BaseType (typeof (UIView))]
	public partial interface REFrostedViewController_UIView {

		[Export ("re_screenshot")]
		UIImage GetScreenshot();
	}

	[Category, BaseType (typeof (UIViewController))]
	public partial interface REFrostedViewController_UIViewController {

		[Export ("frostedViewController", ArgumentSemantic.Retain)]
		REFrostedViewController GetFrostedViewController();

		[Export ("re_displayController:frame:")]
		void REDisplayController (UIViewController controller, RectangleF frame);

		[Export ("re_hideController:")]
		void REHideController (UIViewController controller);
	}
}
