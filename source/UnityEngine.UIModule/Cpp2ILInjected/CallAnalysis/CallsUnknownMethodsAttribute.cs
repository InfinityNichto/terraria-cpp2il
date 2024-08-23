using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000011 RID: 17
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x06000064 RID: 100 RVA: 0x000020D7 File Offset: 0x000002D7
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000012 RID: 18
		public int Count;
	}
}
