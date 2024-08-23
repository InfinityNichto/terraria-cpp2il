using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000026 RID: 38
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x0600012E RID: 302 RVA: 0x0000232C File Offset: 0x0000052C
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x040000E2 RID: 226
		public object Type;

		// Token: 0x040000E3 RID: 227
		public string Member;

		// Token: 0x040000E4 RID: 228
		public object[] MemberTypeParameters;

		// Token: 0x040000E5 RID: 229
		public object[] MemberParameters;

		// Token: 0x040000E6 RID: 230
		public object ReturnType;
	}
}
