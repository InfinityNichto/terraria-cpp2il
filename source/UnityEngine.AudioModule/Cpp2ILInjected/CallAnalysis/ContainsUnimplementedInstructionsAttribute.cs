using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000013 RID: 19
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x06000025 RID: 37 RVA: 0x0000208C File Offset: 0x0000028C
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
