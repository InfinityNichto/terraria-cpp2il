using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000F RID: 15
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x0600003B RID: 59 RVA: 0x000020B0 File Offset: 0x000002B0
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
