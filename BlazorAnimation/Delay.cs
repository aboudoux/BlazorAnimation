using System;

namespace BlazorAnimation
{
	public static class Delay
	{
		public static TimeSpan None => TimeSpan.Zero;
		public static TimeSpan OneSecond => TimeSpan.FromSeconds(1);
		public static TimeSpan TwoSecond => TimeSpan.FromSeconds(2);
		public static TimeSpan ThreeSecond => TimeSpan.FromSeconds(3);
		public static TimeSpan FourSecond => TimeSpan.FromSeconds(4);
		public static TimeSpan FiveSecond => TimeSpan.FromSeconds(5);
	}
}