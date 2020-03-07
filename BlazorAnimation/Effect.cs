namespace BlazorAnimation {
	public static class Effect
	{
		public static CssEffect Bounce => new CssEffect("bounce");
		public static CssEffect Flash => new CssEffect("flash");
		public static CssEffect Pulse => new CssEffect("pulse");
		public static CssEffect RubberBand => new CssEffect("rubberBand");
		public static CssEffect Shake => new CssEffect("shake");
		public static CssEffect HeadShake => new CssEffect("headShake");
		public static CssEffect Swing => new CssEffect("swing");
		public static CssEffect Tada => new CssEffect("tada");
		public static CssEffect Wobble => new CssEffect("wobble");
		public static CssEffect Jello => new CssEffect("jello");
		public static CssEffect BounceIn => new CssEffect("bounceIn");
		public static CssEffect BounceInDown => new CssEffect("bounceInDown");
		public static CssEffect BounceInLeft => new CssEffect("bounceInLeft");
		public static CssEffect BounceInRight => new CssEffect("bounceInRight");
		public static CssEffect BounceInUp => new CssEffect("bounceInUp");
		public static CssEffect BounceOut => new CssEffect("bounceOut");
		public static CssEffect BounceOutDown => new CssEffect("bounceOutDown");
		public static CssEffect BounceOutLeft => new CssEffect("bounceOutLeft");
		public static CssEffect BounceOutRight => new CssEffect("bounceOutRight");
		public static CssEffect BounceOutUp => new CssEffect("bounceOutUp");
		public static CssEffect FadeIn => new CssEffect("fadeIn");
		public static CssEffect FadeInDown => new CssEffect("fadeInDown");
		public static CssEffect FadeInDownBig => new CssEffect("fadeInDownBig");
		public static CssEffect FadeInLeft => new CssEffect("fadeInLeft");
		public static CssEffect FadeInLeftBig => new CssEffect("fadeInLeftBig");
		public static CssEffect FadeInRight => new CssEffect("fadeInRight");
		public static CssEffect FadeInRightBig => new CssEffect("fadeInRightBig");
		public static CssEffect FadeInUp => new CssEffect("fadeInUp");
		public static CssEffect FadeInUpBig => new CssEffect("fadeInUpBig");
		public static CssEffect FadeOut => new CssEffect("fadeOut");
		public static CssEffect FadeOutDown => new CssEffect("fadeOutDown");
		public static CssEffect FadeOutDownBig => new CssEffect("fadeOutDownBig");
		public static CssEffect FadeOutLeft => new CssEffect("fadeOutLeft");
		public static CssEffect FadeOutLeftBig => new CssEffect("fadeOutLeftBig");
		public static CssEffect FadeOutRight => new CssEffect("fadeOutRight");
		public static CssEffect FadeOutRightBig => new CssEffect("fadeOutRightBig");
		public static CssEffect FadeOutUp => new CssEffect("fadeOutUp");
		public static CssEffect FadeOutUpBig => new CssEffect("fadeOutUpBig");
		public static CssEffect FlipInX => new CssEffect("flipInX");
		public static CssEffect FlipInY => new CssEffect("flipInY");
		public static CssEffect FlipOutX => new CssEffect("flipOutX");
		public static CssEffect FlipOutY => new CssEffect("flipOutY");
		public static CssEffect LightSpeedIn => new CssEffect("lightSpeedIn");
		public static CssEffect LightSpeedOut => new CssEffect("lightSpeedOut");
		public static CssEffect RotateIn => new CssEffect("rotateIn");
		public static CssEffect RotateInDownLeft => new CssEffect("rotateInDownLeft");
		public static CssEffect RotateInDownRight => new CssEffect("rotateInDownRight");
		public static CssEffect RotateInUpLeft => new CssEffect("rotateInUpLeft");
		public static CssEffect RotateInUpRight => new CssEffect("rotateInUpRight");
		public static CssEffect RotateOut => new CssEffect("rotateOut");
		public static CssEffect RotateOutDownLeft => new CssEffect("rotateOutDownLeft");
		public static CssEffect RotateOutDownRight => new CssEffect("rotateOutDownRight");
		public static CssEffect RotateOutUpLeft => new CssEffect("rotateOutUpLeft");
		public static CssEffect RotateOutUpRight => new CssEffect("rotateOutUpRight");
		public static CssEffect Hinge => new CssEffect("hinge");
		public static CssEffect JackInTheBox => new CssEffect("jackInTheBox");
		private static CssEffect RollIn => new CssEffect("rollIn");
		public static CssEffect RollOut => new CssEffect("rollOut");
		public static CssEffect ZoomIn => new CssEffect("zoomIn");
		public static CssEffect ZoomInDown => new CssEffect("zoomInDown");
		public static CssEffect ZoomInLeft => new CssEffect("zoomInLeft");
		public static CssEffect ZoomInRight => new CssEffect("zoomInRight");
		public static CssEffect ZoomInUp => new CssEffect("zoomInUp");
		public static CssEffect ZoomOut => new CssEffect("zoomOut");
		public static CssEffect ZoomOutDown => new CssEffect("zoomOutDown");
		public static CssEffect ZoomOutLeft => new CssEffect("zoomOutLeft");
		public static CssEffect ZoomOutRight => new CssEffect("zoomOutRight");
		public static CssEffect ZoomOutUp => new CssEffect("zoomOutUp");
		public static CssEffect SlideInDown => new CssEffect("slideInDown");
		public static CssEffect SlideInLeft => new CssEffect("slideInLeft");
		public static CssEffect SlideInRight => new CssEffect("slideInRight");
		public static CssEffect SlideInUp => new CssEffect("slideInUp");
		public static CssEffect SlideOutDown => new CssEffect("slideOutDown");
		public static CssEffect SlideOutLeft => new CssEffect("slideOutLeft");
		public static CssEffect SlideOutRight => new CssEffect("slideOutRight");
		public static CssEffect SlideOutUp => new CssEffect("slideOutUp");
		public static CssEffect HeartBeat => new CssEffect("heartBeat");
	}

	public class CssEffect : CssClass
	{
		public CssEffect(string name) : base(name)
		{
		}
	}
}
