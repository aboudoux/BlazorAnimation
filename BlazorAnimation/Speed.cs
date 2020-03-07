using System;

namespace BlazorAnimation
{
	public static class Speed
	{
		public static TimeSpan Slow => TimeSpan.FromSeconds(2);
		public static TimeSpan Slower => TimeSpan.FromSeconds(3);
		public static TimeSpan Fast => TimeSpan.FromMilliseconds(800);
		public static TimeSpan Faster => TimeSpan.FromMilliseconds(500);
	}
}