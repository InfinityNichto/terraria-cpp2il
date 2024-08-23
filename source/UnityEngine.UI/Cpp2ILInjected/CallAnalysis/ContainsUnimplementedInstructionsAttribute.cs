using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000078 RID: 120
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x0600065D RID: 1629 RVA: 0x000032B6 File Offset: 0x000014B6
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
