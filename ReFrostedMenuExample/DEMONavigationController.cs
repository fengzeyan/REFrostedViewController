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
	class DEMONavigationController : UINavigationController
	{
		UIPanGestureRecognizer _panGesture;

		public DEMONavigationController (DEMOHomeViewController homeController) : base(homeController)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			_panGesture = new UIPanGestureRecognizer(PanGestureRecognized);
			View.AddGestureRecognizer(_panGesture);
		}

		public void ShowMenu()
		{
			this.GetFrostedViewController().PresentMenuViewController();
		}

		void PanGestureRecognized(UIPanGestureRecognizer recognizer)
		{
			this.GetFrostedViewController().PanGestureRecognized(recognizer);
		}
	}
}

