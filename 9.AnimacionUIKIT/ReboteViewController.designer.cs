// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace _9.AnimacionUIKIT
{
	[Register ("ReboteViewController")]
	partial class ReboteViewController
	{
		[Outlet]
		UIKit.UIImageView Imagen1 { get; set; }

		[Outlet]
		UIKit.UIImageView Imagen2 { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Imagen1 != null) {
				Imagen1.Dispose ();
				Imagen1 = null;
			}

			if (Imagen2 != null) {
				Imagen2.Dispose ();
				Imagen2 = null;
			}
		}
	}
}