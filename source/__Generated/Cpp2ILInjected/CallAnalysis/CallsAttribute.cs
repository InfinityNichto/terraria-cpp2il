using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000F RID: 15
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002071 File Offset: 0x00000271
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x04000009 RID: 9
		public object Type;

		// Token: 0x0400000A RID: 10
		public string Member;

		// Token: 0x0400000B RID: 11
		public object[] MemberTypeParameters;

		// Token: 0x0400000C RID: 12
		public object[] MemberParameters;

		// Token: 0x0400000D RID: 13
		public object ReturnType;
	}
}
