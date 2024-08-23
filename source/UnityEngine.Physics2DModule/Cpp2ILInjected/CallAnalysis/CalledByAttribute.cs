using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000011 RID: 17
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002080 File Offset: 0x00000280
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x04000015 RID: 21
		public object Type;

		// Token: 0x04000016 RID: 22
		public string Member;

		// Token: 0x04000017 RID: 23
		public object[] MemberTypeParameters;

		// Token: 0x04000018 RID: 24
		public object[] MemberParameters;

		// Token: 0x04000019 RID: 25
		public object ReturnType;
	}
}
