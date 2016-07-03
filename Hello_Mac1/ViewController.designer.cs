// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Hello_Mac1
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSCollectionView CollectionView { get; set; }

		[Outlet]
		AppKit.NSButton TestButton { get; set; }

		[Outlet]
		AppKit.NSTextField TestLabel { get; set; }

		[Action ("OnTestButtonClicked:")]
		partial void OnTestButtonClicked (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (CollectionView != null) {
				CollectionView.Dispose ();
				CollectionView = null;
			}

			if (TestButton != null) {
				TestButton.Dispose ();
				TestButton = null;
			}

			if (TestLabel != null) {
				TestLabel.Dispose ();
				TestLabel = null;
			}
		}
	}
}
