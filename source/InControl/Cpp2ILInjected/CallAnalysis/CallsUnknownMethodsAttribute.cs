using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x020001E6 RID: 486
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x0600084C RID: 2124 RVA: 0x00003911 File Offset: 0x00001B11
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x040003C6 RID: 966
		public int Count;
	}
}
