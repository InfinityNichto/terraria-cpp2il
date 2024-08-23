using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000021 RID: 33
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00002284 File Offset: 0x00000484
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
