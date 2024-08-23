using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000019 RID: 25
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00002104 File Offset: 0x00000304
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
