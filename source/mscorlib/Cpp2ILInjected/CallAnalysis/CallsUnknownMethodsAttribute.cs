using System;

namespace Cpp2ILInjected.CallAnalysis
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : global::System.Attribute
	{
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		public int Count;
	}
}
