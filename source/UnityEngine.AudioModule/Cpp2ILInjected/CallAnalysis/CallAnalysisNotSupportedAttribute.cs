using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000014 RID: 20
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x06000026 RID: 38 RVA: 0x0000208F File Offset: 0x0000028F
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
