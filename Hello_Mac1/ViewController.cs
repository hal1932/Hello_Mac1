using System;
using System.Linq;

using AppKit;
using Foundation;

namespace Hello_Mac1
{
	public partial class ViewController : NSViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Do any additional setup after loading the view.
			TestLabel.StringValue = _clickedCount.ToString();

			var item = Storyboard.InstantiateControllerWithIdentifier("TestDataItemContainer") as NSCollectionViewItem;
			CollectionView.ItemPrototype = item;
			CollectionView.Content = Enumerable.Range(0, 10)
				.Select(i => new TestDataItem(i.ToString()))
				.ToArray();
		}

		partial void OnTestButtonClicked(NSObject sender)
		{
			++_clickedCount;
			TestLabel.StringValue = _clickedCount.ToString();
		}

		public override NSObject RepresentedObject
		{
			get
			{
				return base.RepresentedObject;
			}
			set
			{
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

		private int _clickedCount;
	}
}
