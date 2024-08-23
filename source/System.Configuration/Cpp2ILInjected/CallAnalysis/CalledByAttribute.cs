using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001B RID: 27
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x0600002F RID: 47 RVA: 0x000020CE File Offset: 0x000002CE
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x04000017 RID: 23
		public object Type;

		// Token: 0x04000018 RID: 24
		public string Member;

		// Token: 0x04000019 RID: 25
		public object[] MemberTypeParameters;

		// Token: 0x0400001A RID: 26
		public object[] MemberParameters;

		// Token: 0x0400001B RID: 27
		public object ReturnType;
	}
}
