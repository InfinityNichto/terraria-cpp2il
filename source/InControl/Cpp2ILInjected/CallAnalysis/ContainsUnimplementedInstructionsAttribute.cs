using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x020001E3 RID: 483
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x06000849 RID: 2121 RVA: 0x00003908 File Offset: 0x00001B08
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
