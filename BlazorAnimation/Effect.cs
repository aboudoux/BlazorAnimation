namespace BlazorAnimation {
	public static class Effect
	{
		public static AnimationEffect Bounce => new AnimationEffect("bounce");
		public static AnimationEffect Flash => new AnimationEffect("flash");
		public static AnimationEffect Pulse => new AnimationEffect("pulse");
		public static AnimationEffect RubberBand => new AnimationEffect("rubberBand");
		public static AnimationEffect Shake => new AnimationEffect("shake");
		public static AnimationEffect HeadShake => new AnimationEffect("headShake");
		public static AnimationEffect Swing => new AnimationEffect("swing");
		public static AnimationEffect Tada => new AnimationEffect("tada");
		public static AnimationEffect Wobble => new AnimationEffect("wobble");
		public static AnimationEffect Jello => new AnimationEffect("jello");
		public static AnimationEffect BounceIn => new AnimationEffect("bounceIn");
		public static AnimationEffect BounceInDown => new AnimationEffect("bounceInDown");
		public static AnimationEffect BounceInLeft => new AnimationEffect("bounceInLeft");
		public static AnimationEffect BounceInRight => new AnimationEffect("bounceInRight");
		public static AnimationEffect BounceInUp => new AnimationEffect("bounceInUp");
		public static AnimationEffect BounceOut => new AnimationEffect("bounceOut");
		public static AnimationEffect BounceOutDown => new AnimationEffect("bounceOutDown");
		public static AnimationEffect BounceOutLeft => new AnimationEffect("bounceOutLeft");
		public static AnimationEffect BounceOutRight => new AnimationEffect("bounceOutRight");
		public static AnimationEffect BounceOutUp => new AnimationEffect("bounceOutUp");
		public static AnimationEffect FadeIn => new AnimationEffect("fadeIn");
		public static AnimationEffect FadeInDown => new AnimationEffect("fadeInDown");
		public static AnimationEffect FadeInDownBig => new AnimationEffect("fadeInDownBig");
		public static AnimationEffect FadeInLeft => new AnimationEffect("fadeInLeft");
		public static AnimationEffect FadeInLeftBig => new AnimationEffect("fadeInLeftBig");
		public static AnimationEffect FadeInRight => new AnimationEffect("fadeInRight");
		public static AnimationEffect FadeInRightBig => new AnimationEffect("fadeInRightBig");
		public static AnimationEffect FadeInUp => new AnimationEffect("fadeInUp");
		public static AnimationEffect FadeInUpBig => new AnimationEffect("fadeInUpBig");
		public static AnimationEffect FadeOut => new AnimationEffect("fadeOut");
		public static AnimationEffect FadeOutDown => new AnimationEffect("fadeOutDown");
		public static AnimationEffect FadeOutDownBig => new AnimationEffect("fadeOutDownBig");
		public static AnimationEffect FadeOutLeft => new AnimationEffect("fadeOutLeft");
		public static AnimationEffect FadeOutLeftBig => new AnimationEffect("fadeOutLeftBig");
		public static AnimationEffect FadeOutRight => new AnimationEffect("fadeOutRight");
		public static AnimationEffect FadeOutRightBig => new AnimationEffect("fadeOutRightBig");
		public static AnimationEffect FadeOutUp => new AnimationEffect("fadeOutUp");
		public static AnimationEffect FadeOutUpBig => new AnimationEffect("fadeOutUpBig");
		public static AnimationEffect FlipInX => new AnimationEffect("flipInX");
		public static AnimationEffect FlipInY => new AnimationEffect("flipInY");
		public static AnimationEffect FlipOutX => new AnimationEffect("flipOutX");
		public static AnimationEffect FlipOutY => new AnimationEffect("flipOutY");
		public static AnimationEffect LightSpeedIn => new AnimationEffect("lightSpeedIn");
		public static AnimationEffect LightSpeedOut => new AnimationEffect("lightSpeedOut");
		public static AnimationEffect RotateIn => new AnimationEffect("rotateIn");
		public static AnimationEffect RotateInDownLeft => new AnimationEffect("rotateInDownLeft");
		public static AnimationEffect RotateInDownRight => new AnimationEffect("rotateInDownRight");
		public static AnimationEffect RotateInUpLeft => new AnimationEffect("rotateInUpLeft");
		public static AnimationEffect RotateInUpRight => new AnimationEffect("rotateInUpRight");
		public static AnimationEffect RotateOut => new AnimationEffect("rotateOut");
		public static AnimationEffect RotateOutDownLeft => new AnimationEffect("rotateOutDownLeft");
		public static AnimationEffect RotateOutDownRight => new AnimationEffect("rotateOutDownRight");
		public static AnimationEffect RotateOutUpLeft => new AnimationEffect("rotateOutUpLeft");
		public static AnimationEffect RotateOutUpRight => new AnimationEffect("rotateOutUpRight");
		public static AnimationEffect Hinge => new AnimationEffect("hinge");
		public static AnimationEffect JackInTheBox => new AnimationEffect("jackInTheBox");
		private static AnimationEffect RollIn => new AnimationEffect("rollIn");
		public static AnimationEffect RollOut => new AnimationEffect("rollOut");
		public static AnimationEffect ZoomIn => new AnimationEffect("zoomIn");
		public static AnimationEffect ZoomInDown => new AnimationEffect("zoomInDown");
		public static AnimationEffect ZoomInLeft => new AnimationEffect("zoomInLeft");
		public static AnimationEffect ZoomInRight => new AnimationEffect("zoomInRight");
		public static AnimationEffect ZoomInUp => new AnimationEffect("zoomInUp");
		public static AnimationEffect ZoomOut => new AnimationEffect("zoomOut");
		public static AnimationEffect ZoomOutDown => new AnimationEffect("zoomOutDown");
		public static AnimationEffect ZoomOutLeft => new AnimationEffect("zoomOutLeft");
		public static AnimationEffect ZoomOutRight => new AnimationEffect("zoomOutRight");
		public static AnimationEffect ZoomOutUp => new AnimationEffect("zoomOutUp");
		public static AnimationEffect SlideInDown => new AnimationEffect("slideInDown");
		public static AnimationEffect SlideInLeft => new AnimationEffect("slideInLeft");
		public static AnimationEffect SlideInRight => new AnimationEffect("slideInRight");
		public static AnimationEffect SlideInUp => new AnimationEffect("slideInUp");
		public static AnimationEffect SlideOutDown => new AnimationEffect("slideOutDown");
		public static AnimationEffect SlideOutLeft => new AnimationEffect("slideOutLeft");
		public static AnimationEffect SlideOutRight => new AnimationEffect("slideOutRight");
		public static AnimationEffect SlideOutUp => new AnimationEffect("slideOutUp");
		public static AnimationEffect HeartBeat => new AnimationEffect("heartBeat");
	}

	public class AnimationEffect : CssClass
	{
		public AnimationEffect(string name) : base(name)
		{
		}
	}
}
