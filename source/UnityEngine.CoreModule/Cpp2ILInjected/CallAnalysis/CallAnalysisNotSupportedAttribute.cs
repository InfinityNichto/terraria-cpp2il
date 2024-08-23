using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200015A RID: 346
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x060006AE RID: 1710 RVA: 0x00002F6E File Offset: 0x0000116E
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
