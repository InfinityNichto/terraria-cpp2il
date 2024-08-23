using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x020001E9 RID: 489
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x0600084F RID: 2127 RVA: 0x0000391A File Offset: 0x00001B1A
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x040003CD RID: 973
		public object Type;

		// Token: 0x040003CE RID: 974
		public string Member;

		// Token: 0x040003CF RID: 975
		public object[] MemberTypeParameters;

		// Token: 0x040003D0 RID: 976
		public object[] MemberParameters;

		// Token: 0x040003D1 RID: 977
		public object ReturnType;
	}
}
