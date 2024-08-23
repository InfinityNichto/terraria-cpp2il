using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000020 RID: 32
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x06000198 RID: 408 RVA: 0x00002344 File Offset: 0x00000544
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x0400004C RID: 76
		public object Type;

		// Token: 0x0400004D RID: 77
		public string Member;

		// Token: 0x0400004E RID: 78
		public object[] MemberTypeParameters;

		// Token: 0x0400004F RID: 79
		public object[] MemberParameters;

		// Token: 0x04000050 RID: 80
		public object ReturnType;
	}
}
