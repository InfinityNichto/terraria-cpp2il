using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000021 RID: 33
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x06000129 RID: 297 RVA: 0x0000231D File Offset: 0x0000051D
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
