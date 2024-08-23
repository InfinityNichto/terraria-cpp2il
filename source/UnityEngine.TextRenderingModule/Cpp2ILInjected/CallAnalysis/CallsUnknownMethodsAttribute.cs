using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000015 RID: 21
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x06000034 RID: 52 RVA: 0x000020C2 File Offset: 0x000002C2
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000051 RID: 81
		public int Count;
	}
}
