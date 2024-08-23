using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000389 RID: 905
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06001CE6 RID: 7398 RVA: 0x00007FCA File Offset: 0x000061CA
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x04000FD2 RID: 4050
		public object Type;

		// Token: 0x04000FD3 RID: 4051
		public string Member;

		// Token: 0x04000FD4 RID: 4052
		public object[] MemberTypeParameters;

		// Token: 0x04000FD5 RID: 4053
		public object[] MemberParameters;

		// Token: 0x04000FD6 RID: 4054
		public object ReturnType;
	}
}
