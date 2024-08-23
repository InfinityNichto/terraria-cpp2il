using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000E RID: 14
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002077 File Offset: 0x00000277
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400000E RID: 14
		public int Count;
	}
}
