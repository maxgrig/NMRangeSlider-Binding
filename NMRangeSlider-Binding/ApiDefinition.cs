using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace NMRangeSliderBinding
{
	// @interface NMRangeSlider : UIControl
	[BaseType (typeof(UIControl))]
	interface NMRangeSlider
	{
		// @property (assign, nonatomic) float minimumValue;
		[Export ("minimumValue")]
		float MinimumValue { get; set; }

		// @property (assign, nonatomic) float maximumValue;
		[Export ("maximumValue")]
		float MaximumValue { get; set; }

		// @property (assign, nonatomic) float minimumRange;
		[Export ("minimumRange")]
		float MinimumRange { get; set; }

		// @property (assign, nonatomic) float stepValue;
		[Export ("stepValue")]
		float StepValue { get; set; }

		// @property (assign, nonatomic) BOOL stepValueContinuously;
		[Export ("stepValueContinuously")]
		bool StepValueContinuously { get; set; }

		// @property (assign, nonatomic) BOOL continuous;
		[Export ("continuous")]
		bool Continuous { get; set; }

		// @property (assign, nonatomic) float lowerValue;
		[Export ("lowerValue")]
		float LowerValue { get; set; }

		// @property (assign, nonatomic) float upperValue;
		[Export ("upperValue")]
		float UpperValue { get; set; }

		// @property (readonly, nonatomic) CGPoint lowerCenter;
		[Export ("lowerCenter")]
		CGPoint LowerCenter { get; }

		// @property (readonly, nonatomic) CGPoint upperCenter;
		[Export ("upperCenter")]
		CGPoint UpperCenter { get; }

		// @property (assign, nonatomic) float lowerMaximumValue;
		[Export ("lowerMaximumValue")]
		float LowerMaximumValue { get; set; }

		// @property (assign, nonatomic) float upperMinimumValue;
		[Export ("upperMinimumValue")]
		float UpperMinimumValue { get; set; }

		// @property (assign, nonatomic) UIEdgeInsets lowerTouchEdgeInsets;
		[Export ("lowerTouchEdgeInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets LowerTouchEdgeInsets { get; set; }

		// @property (assign, nonatomic) UIEdgeInsets upperTouchEdgeInsets;
		[Export ("upperTouchEdgeInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets UpperTouchEdgeInsets { get; set; }

		// @property (assign, nonatomic) BOOL lowerHandleHidden;
		[Export ("lowerHandleHidden")]
		bool LowerHandleHidden { get; set; }

		// @property (assign, nonatomic) BOOL upperHandleHidden;
		[Export ("upperHandleHidden")]
		bool UpperHandleHidden { get; set; }

		// @property (assign, nonatomic) float lowerHandleHiddenWidth;
		[Export ("lowerHandleHiddenWidth")]
		float LowerHandleHiddenWidth { get; set; }

		// @property (assign, nonatomic) float upperHandleHiddenWidth;
		[Export ("upperHandleHiddenWidth")]
		float UpperHandleHiddenWidth { get; set; }

		// @property (retain, nonatomic) UIImage * lowerHandleImageNormal;
		[Export ("lowerHandleImageNormal", ArgumentSemantic.Retain)]
		UIImage LowerHandleImageNormal { get; set; }

		// @property (retain, nonatomic) UIImage * lowerHandleImageHighlighted;
		[Export ("lowerHandleImageHighlighted", ArgumentSemantic.Retain)]
		UIImage LowerHandleImageHighlighted { get; set; }

		// @property (retain, nonatomic) UIImage * upperHandleImageNormal;
		[Export ("upperHandleImageNormal", ArgumentSemantic.Retain)]
		UIImage UpperHandleImageNormal { get; set; }

		// @property (retain, nonatomic) UIImage * upperHandleImageHighlighted;
		[Export ("upperHandleImageHighlighted", ArgumentSemantic.Retain)]
		UIImage UpperHandleImageHighlighted { get; set; }

		// @property (retain, nonatomic) UIImage * trackImage;
		[Export ("trackImage", ArgumentSemantic.Retain)]
		UIImage TrackImage { get; set; }

		// @property (retain, nonatomic) UIImage * trackCrossedOverImage;
		[Export ("trackCrossedOverImage", ArgumentSemantic.Retain)]
		UIImage TrackCrossedOverImage { get; set; }

		// @property (retain, nonatomic) UIImage * trackBackgroundImage;
		[Export ("trackBackgroundImage", ArgumentSemantic.Retain)]
		UIImage TrackBackgroundImage { get; set; }

		// @property (retain, nonatomic) UIImageView * lowerHandle;
		[Export ("lowerHandle", ArgumentSemantic.Retain)]
		UIImageView LowerHandle { get; set; }

		// @property (retain, nonatomic) UIImageView * upperHandle;
		[Export ("upperHandle", ArgumentSemantic.Retain)]
		UIImageView UpperHandle { get; set; }

		// -(void)addSubviews;
		[Export ("addSubviews")]
		void AddSubviews ();

		// -(void)setLowerValue:(float)lowerValue animated:(BOOL)animated;
		[Export ("setLowerValue:animated:")]
		void SetLowerValue (float lowerValue, bool animated);

		// -(void)setUpperValue:(float)upperValue animated:(BOOL)animated;
		[Export ("setUpperValue:animated:")]
		void SetUpperValue (float upperValue, bool animated);

		// -(void)setLowerValue:(float)lowerValue upperValue:(float)upperValue animated:(BOOL)animated;
		[Export ("setLowerValue:upperValue:animated:")]
		void SetLowerValue (float lowerValue, float upperValue, bool animated);
	}

}
