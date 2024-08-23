using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000386 RID: 902
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x06001CE3 RID: 7395 RVA: 0x00007FC1 File Offset: 0x000061C1
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000FCB RID: 4043
		public int Count;
	}
}
