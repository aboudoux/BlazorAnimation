using System;

namespace BlazorAnimation
{
	public static class Delay
	{
		public static TimeSpan None => TimeSpan.Zero;
		public static TimeSpan OneSecond => TimeSpan.FromSeconds(1);
		public static TimeSpan TwoSeconds => TimeSpan.FromSeconds(2);
		public static TimeSpan ThreeSeconds => TimeSpan.FromSeconds(3);
		public static TimeSpan FourSeconds => TimeSpan.FromSeconds(4);
		public static TimeSpan FiveSeconds => TimeSpan.FromSeconds(5);
	}
}