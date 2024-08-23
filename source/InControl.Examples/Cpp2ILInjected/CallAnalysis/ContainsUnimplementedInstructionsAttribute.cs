using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000015 RID: 21
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00002149 File Offset: 0x00000349
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
