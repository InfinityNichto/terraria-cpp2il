using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000D RID: 13
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000206B File Offset: 0x0000026B
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000007 RID: 7
		public int Count;
	}
}
