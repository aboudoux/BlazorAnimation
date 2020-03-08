using System;

namespace BlazorAnimation
{
	public class AnimationOptions
	{
		public AnimationEffect Effect { get; set; }
		public TimeSpan? Delay { get; set; }
		public TimeSpan? Speed { get; set; }
		public  int? IterationCount { get; set; }
		public bool? Enabled { get; set; }
	}
}