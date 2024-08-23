using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000030 RID: 48
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06000077 RID: 119 RVA: 0x000021B2 File Offset: 0x000003B2
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x04000040 RID: 64
		public object Type;

		// Token: 0x04000041 RID: 65
		public string Member;

		// Token: 0x04000042 RID: 66
		public object[] MemberTypeParameters;

		// Token: 0x04000043 RID: 67
		public object[] MemberParameters;

		// Token: 0x04000044 RID: 68
		public object ReturnType;
	}
}
