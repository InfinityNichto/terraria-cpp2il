using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000D RID: 13
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002074 File Offset: 0x00000274
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400000D RID: 13
		public int Count;
	}
}
