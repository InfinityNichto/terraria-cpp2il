using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000023 RID: 35
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x0000228A File Offset: 0x0000048A
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400003F RID: 63
		public int Count;
	}
}
