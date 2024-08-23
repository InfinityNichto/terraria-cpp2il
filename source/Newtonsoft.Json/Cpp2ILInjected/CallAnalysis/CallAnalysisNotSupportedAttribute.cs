using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x020000EC RID: 236
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x06000A80 RID: 2688 RVA: 0x00003EFC File Offset: 0x000020FC
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
