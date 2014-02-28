using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using REFrostedMenu;

namespace ReFrostedMenuExample
{
	public class DEMOMenuViewController : UITableViewController
	{
		public DEMOMenuViewController () : base(UITableViewStyle.Plain)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			UIView header = new UIView(new System.Drawing.RectangleF(0, 0, 0, 184f));
			UIImageView imageView = new UIImageView(new System.Drawing.RectangleF(0, 40f, 100f, 100f));
			imageView.AutoresizingMask = UIViewAutoresizing.FlexibleLeftMargin | UIViewAutoresizing.FlexibleRightMargin;
			imageView.Image = UIImage.FromBundle("avatar.jpg");
			imageView.Layer.MasksToBounds = true;
			imageView.Layer.CornerRadius = 50f;
			imageView.Layer.BorderColor = UIColor.White.CGColor;
			imageView.Layer.BorderWidth = 3f;
			imageView.Layer.RasterizationScale = UIScreen.MainScreen.Scale;
			imageView.Layer.ShouldRasterize = true;
			imageView.ClipsToBounds = true;

			UILabel label = new UILabel(new System.Drawing.RectangleF(0, 150f, 0, 24f)){
				Text = "Roman Efimov",
				Font = UIFont.SystemFontOfSize(21f),
				BackgroundColor = UIColor.Clear,
				TextColor = UIColor.FromRGBA(62/255f, 68/255f, 75/255f, 1f)
			};
			label.SizeToFit();
			label.AutoresizingMask = UIViewAutoresizing.FlexibleLeftMargin | UIViewAutoresizing.FlexibleRightMargin;
			header.AddSubview(imageView);
			header.AddSubview(label);

			TableView.SeparatorColor = UIColor.FromRGBA(150/255f, 161/255f, 177/255f, 1f);
			TableView.Source = new DEMOTableSource(this);
			TableView.Opaque = false;
			TableView.BackgroundColor = UIColor.Clear;
			TableView.TableHeaderView = header;
		}

		public class DEMOTableSource : UITableViewSource
		{
			UILabel _label;
			UIView _view;

			public DEMOTableSource (DEMOMenuViewController menuController)
			{
				
			}

			public override void WillDisplay (UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
			{
				cell.BackgroundColor = UIColor.Clear;
				cell.TextLabel.TextColor = UIColor.FromRGBA(62/255f, 68/255f, 75/255f, 1f);
				cell.TextLabel.Font = UIFont.SystemFontOfSize(17f);
			}

			public override UIView GetViewForHeader (UITableView tableView, int section)
			{
				if(section == 0)
					return null;

				_view = new UIView(new System.Drawing.RectangleF(0, 0, tableView.Frame.Size.Width, 34));
				_view.BackgroundColor = UIColor.FromRGBA(167/255f, 167/255f, 167/255f, 0.6f);

				_label = new UILabel(new System.Drawing.RectangleF(10, 8, 0, 0)){
					Text = "Friends Online",
					Font = UIFont.SystemFontOfSize(15f),
					TextColor = UIColor.White,
					BackgroundColor = UIColor.Clear,
				};
				_label.SizeToFit();
				_view.AddSubview(_label);

				return _view;
			}

			public override float GetHeightForHeader (UITableView tableView, int section)
			{
				if(section == 0)
					return 0;

				return 34f;
			}

			public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
			{
				return 54f;
			}

			public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
			{
				tableView.DeselectRow(indexPath, true);

				if(indexPath.Section == 0 && indexPath.Row == 0) {
					var nav = new DEMONavigationController(new DEMOHomeViewController());

				} else {

				}
			}

			static NSString cellIdentifier = new NSString("Cell");
			public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
			{
				var cell = tableView.DequeueReusableCell(cellIdentifier);

				if(cell == null)
					cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);

				if(indexPath.Section == 0)
				{
					string[] titles = new string[] { "Home", "Profile", "Chats" };
					cell.TextLabel.Text = titles[indexPath.Row];
				} else 
				{
					string[] titles = new string[] { "John Appleseed", "John Doe", "Test User" };
					cell.TextLabel.Text = titles[indexPath.Row];
				}

				return cell;
			}

			public override int RowsInSection (UITableView tableview, int section)
			{
				return 3;
			}

			public override int NumberOfSections (UITableView tableView)
			{
				return 2;
			}
		}
	}
}

