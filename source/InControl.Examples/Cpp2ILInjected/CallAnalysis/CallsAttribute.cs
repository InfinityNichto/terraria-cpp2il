using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001A RID: 26
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00002158 File Offset: 0x00000358
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
