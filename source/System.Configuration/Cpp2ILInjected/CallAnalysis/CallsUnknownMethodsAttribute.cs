using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000018 RID: 24
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x0600002C RID: 44 RVA: 0x000020C5 File Offset: 0x000002C5
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000010 RID: 16
		public int Count;
	}
}
