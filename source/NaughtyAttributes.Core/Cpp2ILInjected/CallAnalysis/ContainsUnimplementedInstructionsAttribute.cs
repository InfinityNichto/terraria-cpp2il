using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200002A RID: 42
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x06000071 RID: 113 RVA: 0x000021A0 File Offset: 0x000003A0
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
