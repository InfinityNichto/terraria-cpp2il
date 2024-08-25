using System;

namespace Cpp2ILInjected.CallAnalysis
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : global::System.Attribute
	{
		public CallerCountAttribute()
		{
			throw null;
		}

		public int Count;
	}
}
