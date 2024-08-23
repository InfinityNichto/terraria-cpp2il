using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000010 RID: 16
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x06000046 RID: 70 RVA: 0x0000211F File Offset: 0x0000031F
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000015 RID: 21
		public int Count;
	}
}
