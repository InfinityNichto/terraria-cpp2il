using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000015 RID: 21
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06000041 RID: 65 RVA: 0x000020C2 File Offset: 0x000002C2
		public CalledByAttribute()
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
