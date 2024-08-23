using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000012 RID: 18
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x0600003E RID: 62 RVA: 0x000020B9 File Offset: 0x000002B9
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000034 RID: 52
		public int Count;
	}
}
