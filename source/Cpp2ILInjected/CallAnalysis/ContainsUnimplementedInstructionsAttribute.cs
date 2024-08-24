using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000763 RID: 1891
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x060047F9 RID: 18425 RVA: 0x0002ED84 File Offset: 0x0002CF84
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
