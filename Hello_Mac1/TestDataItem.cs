using System;
using Foundation;

namespace Hello_Mac1
{
	[Register("TestDataItem")]
	public class TestDataItem : NSObject
	{
		[Export("Name")]
		public string Name
		{
			get { return _name; }
			set
			{
				WillChangeValue("Name");
				_name = value;
				DidChangeValue("Name");
			}
		}
		private string _name;

		public TestDataItem(string name = "defaultName")
			: base()
		{
			Name = name;
		}
	}
}

