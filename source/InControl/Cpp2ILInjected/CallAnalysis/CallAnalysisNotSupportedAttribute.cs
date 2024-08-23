using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x020001E4 RID: 484
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x0600084A RID: 2122 RVA: 0x0000390B File Offset: 0x00001B0B
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
