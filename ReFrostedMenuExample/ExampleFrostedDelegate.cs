using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using REFrostedMenu;
using System.Reflection;

namespace ReFrostedMenuExample
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	public class ExampleFrostedDelegate : REFrostedViewControllerDelegate
	{
		public override void DidRecognizePanGesture (REFrostedViewController frostedViewController, UIPanGestureRecognizer recognizer)
		{
			Console.WriteLine(MethodBase.GetCurrentMethod().Name);
		}

		public override void WillShowMenuViewController (REFrostedViewController frostedViewController, UIViewController menuViewController)
		{
			Console.WriteLine(MethodBase.GetCurrentMethod().Name);
		}

		public override void DidShowMenuViewController (REFrostedViewController frostedViewController, UIViewController menuViewController)
		{
			Console.WriteLine(MethodBase.GetCurrentMethod().Name);
		}

		public override void WillHideMenuViewController (REFrostedViewController frostedViewController, UIViewController menuViewController)
		{
			Console.WriteLine(MethodBase.GetCurrentMethod().Name);
		}

		public override void DidHideMenuViewController (REFrostedViewController frostedViewController, UIViewController menuViewController)
		{
			Console.WriteLine(MethodBase.GetCurrentMethod().Name);
		}
	}
}

