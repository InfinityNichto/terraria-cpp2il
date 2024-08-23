using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x020000EB RID: 235
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x06000A7F RID: 2687 RVA: 0x00003EF9 File Offset: 0x000020F9
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
