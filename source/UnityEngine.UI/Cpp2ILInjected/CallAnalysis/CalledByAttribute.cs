using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200007E RID: 126
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06000663 RID: 1635 RVA: 0x000032C8 File Offset: 0x000014C8
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x04000244 RID: 580
		public object Type;

		// Token: 0x04000245 RID: 581
		public string Member;

		// Token: 0x04000246 RID: 582
		public object[] MemberTypeParameters;

		// Token: 0x04000247 RID: 583
		public object[] MemberParameters;

		// Token: 0x04000248 RID: 584
		public object ReturnType;
	}
}
