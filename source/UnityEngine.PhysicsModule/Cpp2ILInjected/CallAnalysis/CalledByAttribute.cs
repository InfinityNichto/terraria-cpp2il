using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000010 RID: 16
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06000010 RID: 16 RVA: 0x0000207D File Offset: 0x0000027D
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x04000014 RID: 20
		public object Type;

		// Token: 0x04000015 RID: 21
		public string Member;

		// Token: 0x04000016 RID: 22
		public object[] MemberTypeParameters;

		// Token: 0x04000017 RID: 23
		public object[] MemberParameters;

		// Token: 0x04000018 RID: 24
		public object ReturnType;
	}
}
