using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000143 RID: 323
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x06000C33 RID: 3123 RVA: 0x00005207 File Offset: 0x00003407
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
