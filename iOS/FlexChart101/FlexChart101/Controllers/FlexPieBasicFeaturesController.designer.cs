// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace FlexChart101
{
	[Register ("FlexPieBasicFeaturesController")]
	partial class FlexPieBasicFeaturesController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UILabel innerRadiusLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UISlider offsetSlider { get; set; }

		[Outlet]
		C1.iOS.Chart.FlexPie pieChart { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UISwitch reversedSwitch { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UISlider startAngleSlider { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIStepper stepper { get; set; }

		[Action ("offsetChanged:")]
		partial void offsetChanged (UIKit.UISlider sender);

		[Action ("startAngleChanged:")]
		partial void startAngleChanged (UIKit.UISlider sender);

		[Action ("switchValueChanged:")]
		partial void switchValueChanged (UIKit.UISwitch sender);

		[Action ("valueChanged:")]
		partial void valueChanged (UIKit.UIStepper sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (pieChart != null) {
				pieChart.Dispose ();
				pieChart = null;
			}

			if (innerRadiusLabel != null) {
				innerRadiusLabel.Dispose ();
				innerRadiusLabel = null;
			}

			if (offsetSlider != null) {
				offsetSlider.Dispose ();
				offsetSlider = null;
			}

			if (reversedSwitch != null) {
				reversedSwitch.Dispose ();
				reversedSwitch = null;
			}

			if (startAngleSlider != null) {
				startAngleSlider.Dispose ();
				startAngleSlider = null;
			}

			if (stepper != null) {
				stepper.Dispose ();
				stepper = null;
			}
		}
	}
}
