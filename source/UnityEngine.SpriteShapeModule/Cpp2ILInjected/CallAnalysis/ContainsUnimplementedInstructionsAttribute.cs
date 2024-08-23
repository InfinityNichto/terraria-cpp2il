using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000008 RID: 8
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x06000006 RID: 6 RVA: 0x0000205F File Offset: 0x0000025F
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
