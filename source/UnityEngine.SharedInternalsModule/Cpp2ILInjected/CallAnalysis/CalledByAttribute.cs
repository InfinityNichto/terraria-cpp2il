using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000028 RID: 40
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00002125 File Offset: 0x00000325
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x04000033 RID: 51
		public object Type;

		// Token: 0x04000034 RID: 52
		public string Member;

		// Token: 0x04000035 RID: 53
		public object[] MemberTypeParameters;

		// Token: 0x04000036 RID: 54
		public object[] MemberParameters;

		// Token: 0x04000037 RID: 55
		public object ReturnType;
	}
}
