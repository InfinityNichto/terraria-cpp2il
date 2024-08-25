using System;

namespace Cpp2ILInjected.CallAnalysis
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : global::System.Attribute
	{
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
