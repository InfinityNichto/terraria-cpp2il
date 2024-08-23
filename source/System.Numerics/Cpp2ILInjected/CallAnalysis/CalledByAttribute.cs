using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000013 RID: 19
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00002128 File Offset: 0x00000328
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x0400001C RID: 28
		public object Type;

		// Token: 0x0400001D RID: 29
		public string Member;

		// Token: 0x0400001E RID: 30
		public object[] MemberTypeParameters;

		// Token: 0x0400001F RID: 31
		public object[] MemberParameters;

		// Token: 0x04000020 RID: 32
		public object ReturnType;
	}
}
