using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000055 RID: 85
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x0600040B RID: 1035 RVA: 0x00005A9A File Offset: 0x00003C9A
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
