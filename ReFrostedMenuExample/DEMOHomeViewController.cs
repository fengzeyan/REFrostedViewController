using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ReFrostedMenuExample
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	class DEMOHomeViewController : UIViewController
	{
		UIImageView _imageView;

		public DEMOHomeViewController ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			Title = "Home Controller";

			var menuButton = new UIBarButtonItem("Menu", UIBarButtonItemStyle.Plain, null);
			menuButton.Clicked += (sender, e) => {
				((DEMONavigationController)NavigationController).ShowMenu();
			};
			NavigationItem.LeftBarButtonItem = menuButton;

			_imageView = new UIImageView(View.Bounds);
			_imageView.Image = UIImage.FromBundle("Balloon.png");
			_imageView.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;
			_imageView.ContentMode = UIViewContentMode.ScaleAspectFill;
			View.AddSubview(_imageView);
		}
	}
}

