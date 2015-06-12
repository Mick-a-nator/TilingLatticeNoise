using System;
namespace NoiseGeneration
{
	public class LinearFader : IFader
	{
		//A linear fade function, i.e. just lerp with the lerper.
		public float Fade (float t)
		{
			if (t < 0f || t > 1f)
				throw new ArgumentException ("The argument 't' should be in the interval [0, 1]");
			return t;
		}
	}
}

