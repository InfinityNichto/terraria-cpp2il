using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000012 RID: 18
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x06000031 RID: 49 RVA: 0x000020B9 File Offset: 0x000002B9
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
