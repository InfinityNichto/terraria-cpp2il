using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200015F RID: 351
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x060006B3 RID: 1715 RVA: 0x00002F7D File Offset: 0x0000117D
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x0400062B RID: 1579
		public object Type;

		// Token: 0x0400062C RID: 1580
		public string Member;

		// Token: 0x0400062D RID: 1581
		public object[] MemberTypeParameters;

		// Token: 0x0400062E RID: 1582
		public object[] MemberParameters;

		// Token: 0x0400062F RID: 1583
		public object ReturnType;
	}
}
