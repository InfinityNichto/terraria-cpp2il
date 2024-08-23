using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000016 RID: 22
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x06000055 RID: 85 RVA: 0x0000214C File Offset: 0x0000034C
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
