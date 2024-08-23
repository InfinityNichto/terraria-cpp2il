using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200007B RID: 123
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x06000660 RID: 1632 RVA: 0x000032BF File Offset: 0x000014BF
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400023D RID: 573
		public int Count;
	}
}
