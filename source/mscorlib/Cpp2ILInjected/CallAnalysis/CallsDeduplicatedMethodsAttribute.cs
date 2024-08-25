using System;

namespace Cpp2ILInjected.CallAnalysis
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : global::System.Attribute
	{
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		public int Count;
	}
}
