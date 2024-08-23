using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000053 RID: 83
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x0600027F RID: 639 RVA: 0x00003690 File Offset: 0x00001890
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400028D RID: 653
		public int Count;
	}
}
