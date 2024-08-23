using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001E RID: 30
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x06000196 RID: 406 RVA: 0x0000233E File Offset: 0x0000053E
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400004A RID: 74
		public int Count;
	}
}
