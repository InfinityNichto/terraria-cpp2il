using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000057 RID: 87
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x00005AA0 File Offset: 0x00003CA0
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x040002D2 RID: 722
		public int Count;
	}
}
