using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000025 RID: 37
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x06000045 RID: 69 RVA: 0x0000211C File Offset: 0x0000031C
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400002C RID: 44
		public int Count;
	}
}
