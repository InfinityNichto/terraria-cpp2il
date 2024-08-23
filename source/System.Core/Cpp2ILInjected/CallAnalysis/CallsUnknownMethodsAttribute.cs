using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000020 RID: 32
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x000044D5 File Offset: 0x000026D5
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400004A RID: 74
		public int Count;
	}
}
