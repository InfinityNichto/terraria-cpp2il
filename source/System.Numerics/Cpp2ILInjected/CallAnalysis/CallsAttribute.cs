using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000012 RID: 18
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00002125 File Offset: 0x00000325
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x04000017 RID: 23
		public object Type;

		// Token: 0x04000018 RID: 24
		public string Member;

		// Token: 0x04000019 RID: 25
		public object[] MemberTypeParameters;

		// Token: 0x0400001A RID: 26
		public object[] MemberParameters;

		// Token: 0x0400001B RID: 27
		public object ReturnType;
	}
}
