using System;

namespace Cpp2ILInjected.CallAnalysis
{
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
