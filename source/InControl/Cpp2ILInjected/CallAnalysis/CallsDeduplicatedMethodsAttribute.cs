using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x020001E5 RID: 485
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x0600084B RID: 2123 RVA: 0x0000390E File Offset: 0x00001B0E
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x040003C5 RID: 965
		public int Count;
	}
}
