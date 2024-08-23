using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000385 RID: 901
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x06001CE2 RID: 7394 RVA: 0x00007FBE File Offset: 0x000061BE
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000FCA RID: 4042
		public int Count;
	}
}
