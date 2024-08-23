using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001B RID: 27
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContainsUnimplementedInstructionsAttribute : Attribute
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00002335 File Offset: 0x00000535
		public ContainsUnimplementedInstructionsAttribute()
		{
			throw null;
		}
	}
}
