using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000B RID: 11
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002068 File Offset: 0x00000268
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000007 RID: 7
		public int Count;
	}
}
