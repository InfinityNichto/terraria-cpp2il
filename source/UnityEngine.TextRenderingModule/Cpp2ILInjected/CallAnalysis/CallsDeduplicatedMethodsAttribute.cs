using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000014 RID: 20
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x06000033 RID: 51 RVA: 0x000020BF File Offset: 0x000002BF
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000050 RID: 80
		public int Count;
	}
}
