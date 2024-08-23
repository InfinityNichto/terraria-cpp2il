using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000010 RID: 16
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002089 File Offset: 0x00000289
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
