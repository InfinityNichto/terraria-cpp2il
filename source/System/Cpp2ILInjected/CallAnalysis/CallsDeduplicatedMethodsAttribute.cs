using System;

namespace Cpp2ILInjected.CallAnalysis
{
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		public int Count;
	}
}
