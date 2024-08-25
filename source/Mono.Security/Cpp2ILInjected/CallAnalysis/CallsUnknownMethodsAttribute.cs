using System;

namespace Cpp2ILInjected.CallAnalysis
{
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		public int Count;
	}
}
