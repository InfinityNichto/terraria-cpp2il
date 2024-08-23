using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000022 RID: 34
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00002113 File Offset: 0x00000313
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
