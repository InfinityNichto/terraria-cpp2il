using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000383 RID: 899
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x06001CE0 RID: 7392 RVA: 0x00007FB8 File Offset: 0x000061B8
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
