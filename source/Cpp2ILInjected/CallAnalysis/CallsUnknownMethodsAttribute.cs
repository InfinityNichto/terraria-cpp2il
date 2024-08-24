using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000766 RID: 1894
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x060047FC RID: 18428 RVA: 0x0002ED8D File Offset: 0x0002CF8D
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x040077EB RID: 30699
		public int Count;
	}
}
