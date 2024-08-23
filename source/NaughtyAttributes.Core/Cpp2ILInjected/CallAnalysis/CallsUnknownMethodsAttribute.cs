using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200002D RID: 45
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x06000074 RID: 116 RVA: 0x000021A9 File Offset: 0x000003A9
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000039 RID: 57
		public int Count;
	}
}
