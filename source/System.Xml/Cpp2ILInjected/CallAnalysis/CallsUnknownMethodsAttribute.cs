using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000146 RID: 326
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x06000C36 RID: 3126 RVA: 0x00005210 File Offset: 0x00003410
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x040004F3 RID: 1267
		public int Count;
	}
}
