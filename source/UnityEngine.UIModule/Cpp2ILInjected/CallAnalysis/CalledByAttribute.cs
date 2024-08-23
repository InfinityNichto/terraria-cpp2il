using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000014 RID: 20
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06000067 RID: 103 RVA: 0x000020E0 File Offset: 0x000002E0
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x04000019 RID: 25
		public object Type;

		// Token: 0x0400001A RID: 26
		public string Member;

		// Token: 0x0400001B RID: 27
		public object[] MemberTypeParameters;

		// Token: 0x0400001C RID: 28
		public object[] MemberParameters;

		// Token: 0x0400001D RID: 29
		public object ReturnType;
	}
}
