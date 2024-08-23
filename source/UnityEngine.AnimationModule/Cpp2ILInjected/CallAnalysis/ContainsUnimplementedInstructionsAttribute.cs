using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000025 RID: 37
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00002110 File Offset: 0x00000310
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
