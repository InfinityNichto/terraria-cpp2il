using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x020000F0 RID: 240
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x06000A84 RID: 2692 RVA: 0x00003F08 File Offset: 0x00002108
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x0400035A RID: 858
		public object Type;

		// Token: 0x0400035B RID: 859
		public string Member;

		// Token: 0x0400035C RID: 860
		public object[] MemberTypeParameters;

		// Token: 0x0400035D RID: 861
		public object[] MemberParameters;

		// Token: 0x0400035E RID: 862
		public object ReturnType;
	}
}
