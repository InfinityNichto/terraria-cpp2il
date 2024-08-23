using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000A RID: 10
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002077 File Offset: 0x00000277
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
