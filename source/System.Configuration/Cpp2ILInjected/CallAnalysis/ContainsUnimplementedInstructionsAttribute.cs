using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000015 RID: 21
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x06000029 RID: 41 RVA: 0x000020BC File Offset: 0x000002BC
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
