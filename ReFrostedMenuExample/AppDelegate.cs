using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using REFrostedMenu;

namespace ReFrostedMenuExample
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		DEMONavigationController _nav;
		DEMOMenuViewController _menu;
		DEMOHomeViewController _home;

		REFrostedViewController _frostedController;

		//
		// This method is invoked when the application has loaded and is ready to run. In this
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			_home = new DEMOHomeViewController();
			_nav = new DEMONavigationController(_home);
			_menu = new DEMOMenuViewController();

			_frostedController = new REFrostedViewController(_nav, _menu);
			_frostedController.Direction = REFrostedViewControllerDirection.Left;
			_frostedController.LiveBlurBackgroundStyle = REFrostedViewControllerLiveBackgroundStyle.Light;
			_frostedController.Delegate = new ExampleFrostedDelegate();

			// If you have defined a root view controller, set it here:
			window.RootViewController = _frostedController;
			window.BackgroundColor = UIColor.White;
			
			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

