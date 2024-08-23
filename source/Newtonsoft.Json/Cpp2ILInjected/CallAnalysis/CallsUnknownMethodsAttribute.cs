using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x020000EE RID: 238
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x06000A82 RID: 2690 RVA: 0x00003F02 File Offset: 0x00002102
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000358 RID: 856
		public int Count;
	}
}
