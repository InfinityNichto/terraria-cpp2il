using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000024 RID: 36
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00002326 File Offset: 0x00000526
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x040000E0 RID: 224
		public int Count;
	}
}
