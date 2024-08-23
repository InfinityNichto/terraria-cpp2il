using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000022 RID: 34
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x000044DB File Offset: 0x000026DB
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
