using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000020 RID: 32
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00002281 File Offset: 0x00000481
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
