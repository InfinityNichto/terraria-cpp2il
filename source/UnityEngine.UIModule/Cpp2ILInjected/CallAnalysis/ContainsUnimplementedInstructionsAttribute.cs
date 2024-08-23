using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000E RID: 14
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x06000061 RID: 97 RVA: 0x000020CE File Offset: 0x000002CE
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
