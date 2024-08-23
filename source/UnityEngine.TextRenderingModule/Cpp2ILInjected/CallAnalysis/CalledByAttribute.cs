using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000018 RID: 24
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06000037 RID: 55 RVA: 0x000020CB File Offset: 0x000002CB
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x04000058 RID: 88
		public object Type;

		// Token: 0x04000059 RID: 89
		public string Member;

		// Token: 0x0400005A RID: 90
		public object[] MemberTypeParameters;

		// Token: 0x0400005B RID: 91
		public object[] MemberParameters;

		// Token: 0x0400005C RID: 92
		public object ReturnType;
	}
}
