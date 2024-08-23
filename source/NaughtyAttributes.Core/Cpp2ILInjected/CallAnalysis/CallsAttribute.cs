using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200002F RID: 47
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x06000076 RID: 118 RVA: 0x000021AF File Offset: 0x000003AF
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x0400003B RID: 59
		public object Type;

		// Token: 0x0400003C RID: 60
		public string Member;

		// Token: 0x0400003D RID: 61
		public object[] MemberTypeParameters;

		// Token: 0x0400003E RID: 62
		public object[] MemberParameters;

		// Token: 0x0400003F RID: 63
		public object ReturnType;
	}
}
