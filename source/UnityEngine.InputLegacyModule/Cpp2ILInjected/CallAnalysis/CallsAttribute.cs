using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000014 RID: 20
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x06000040 RID: 64 RVA: 0x000020BF File Offset: 0x000002BF
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x04000036 RID: 54
		public object Type;

		// Token: 0x04000037 RID: 55
		public string Member;

		// Token: 0x04000038 RID: 56
		public object[] MemberTypeParameters;

		// Token: 0x04000039 RID: 57
		public object[] MemberParameters;

		// Token: 0x0400003A RID: 58
		public object ReturnType;
	}
}
