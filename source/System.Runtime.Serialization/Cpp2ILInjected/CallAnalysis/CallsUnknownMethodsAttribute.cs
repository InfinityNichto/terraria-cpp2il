using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000D RID: 13
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002080 File Offset: 0x00000280
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400000D RID: 13
		public int Count;
	}
}
