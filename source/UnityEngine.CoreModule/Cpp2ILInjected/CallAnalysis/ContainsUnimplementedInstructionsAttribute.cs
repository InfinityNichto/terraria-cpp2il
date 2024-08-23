using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000159 RID: 345
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x060006AD RID: 1709 RVA: 0x00002F6B File Offset: 0x0000116B
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
