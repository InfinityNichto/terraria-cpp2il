using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000A RID: 10
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002062 File Offset: 0x00000262
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
