using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000054 RID: 84
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x0600040A RID: 1034 RVA: 0x00005A97 File Offset: 0x00003C97
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
