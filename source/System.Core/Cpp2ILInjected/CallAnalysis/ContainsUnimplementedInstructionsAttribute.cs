using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001D RID: 29
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x000044CC File Offset: 0x000026CC
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
