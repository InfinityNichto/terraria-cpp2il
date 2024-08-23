using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001E RID: 30
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00002113 File Offset: 0x00000313
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x04000046 RID: 70
		public object Type;

		// Token: 0x04000047 RID: 71
		public string Member;

		// Token: 0x04000048 RID: 72
		public object[] MemberTypeParameters;

		// Token: 0x04000049 RID: 73
		public object[] MemberParameters;

		// Token: 0x0400004A RID: 74
		public object ReturnType;
	}
}
