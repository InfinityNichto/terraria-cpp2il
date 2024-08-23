using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000016 RID: 22
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002095 File Offset: 0x00000295
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000011 RID: 17
		public int Count;
	}
}
