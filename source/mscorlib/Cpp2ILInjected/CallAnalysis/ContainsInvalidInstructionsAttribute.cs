using System;

namespace Cpp2ILInjected.CallAnalysis
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsInvalidInstructionsAttribute : global::System.Attribute
	{
		public ContainsInvalidInstructionsAttribute()
		{
			throw null;
		}
	}
}
