using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000050 RID: 80
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x0600027C RID: 636 RVA: 0x00003687 File Offset: 0x00001887
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
