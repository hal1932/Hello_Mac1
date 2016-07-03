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

			for (var i = 0; i < 10; ++i)
			{
				ItemArray.AddObject(new TestDataItem("name" + i.ToString("D2")));
			}
			ItemArray.SelectionIndex = 0;
		}

		public override void AwakeFromNib()
		{
			base.AwakeFromNib();

			ItemArray.AddObserver(
				"selectionIndex",
				NSKeyValueObservingOptions.New,
				_ => Console.WriteLine((ItemArray.SelectedObjects.FirstOrDefault() as TestDataItem)?.Name));
		}

		partial void OnTestButtonClicked(NSObject sender)
		{
			++_clickedCount;
			TestLabel.StringValue = _clickedCount.ToString();
			ItemArray.SelectionIndex = (ulong)_clickedCount;
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
