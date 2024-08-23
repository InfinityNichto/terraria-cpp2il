using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001B RID: 27
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x06000045 RID: 69 RVA: 0x0000210A File Offset: 0x0000030A
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400003F RID: 63
		public int Count;
	}
}
