using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001C RID: 28
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00002338 File Offset: 0x00000538
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
