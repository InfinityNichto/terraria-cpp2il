using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000019 RID: 25
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x0600002B RID: 43 RVA: 0x0000209E File Offset: 0x0000029E
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x04000018 RID: 24
		public object Type;

		// Token: 0x04000019 RID: 25
		public string Member;

		// Token: 0x0400001A RID: 26
		public object[] MemberTypeParameters;

		// Token: 0x0400001B RID: 27
		public object[] MemberParameters;

		// Token: 0x0400001C RID: 28
		public object ReturnType;
	}
}
