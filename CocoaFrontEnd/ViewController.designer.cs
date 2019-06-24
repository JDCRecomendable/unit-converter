// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace UnitConverter
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField DpEntryField { get; set; }

		[Outlet]
		AppKit.NSTextField InputBox { get; set; }

		[Outlet]
		AppKit.NSPopUpButton InputUnitPicker { get; set; }

		[Outlet]
		AppKit.NSTextField OutputBox { get; set; }

		[Outlet]
		AppKit.NSPopUpButton OutputUnitPicker { get; set; }

		[Action ("Clear:")]
		partial void Clear (AppKit.NSButton sender);

		[Action ("Swap:")]
		partial void Swap (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (OutputBox != null) {
				OutputBox.Dispose ();
				OutputBox = null;
			}

			if (InputBox != null) {
				InputBox.Dispose ();
				InputBox = null;
			}

			if (OutputUnitPicker != null) {
				OutputUnitPicker.Dispose ();
				OutputUnitPicker = null;
			}

			if (InputUnitPicker != null) {
				InputUnitPicker.Dispose ();
				InputUnitPicker = null;
			}

			if (DpEntryField != null) {
				DpEntryField.Dispose ();
				DpEntryField = null;
			}
		}
	}
}
