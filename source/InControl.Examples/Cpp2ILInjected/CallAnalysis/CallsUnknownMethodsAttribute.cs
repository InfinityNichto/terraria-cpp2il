using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000018 RID: 24
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00002152 File Offset: 0x00000352
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000039 RID: 57
		public int Count;
	}
}
