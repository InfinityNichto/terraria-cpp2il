using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000A RID: 10
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002065 File Offset: 0x00000265
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000006 RID: 6
		public int Count;
	}
}
