using System;

namespace Cpp2ILInjected.CallAnalysis
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : global::System.Attribute
	{
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
