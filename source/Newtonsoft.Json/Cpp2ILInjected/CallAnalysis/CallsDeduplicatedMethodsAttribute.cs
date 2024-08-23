using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x020000ED RID: 237
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x06000A81 RID: 2689 RVA: 0x00003EFF File Offset: 0x000020FF
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000357 RID: 855
		public int Count;
	}
}
