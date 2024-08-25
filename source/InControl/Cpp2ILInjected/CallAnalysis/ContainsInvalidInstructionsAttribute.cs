using System;

namespace Cpp2ILInjected.CallAnalysis
{
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsInvalidInstructionsAttribute : Attribute
	{
		public ContainsInvalidInstructionsAttribute()
		{
			throw null;
		}
	}
}
