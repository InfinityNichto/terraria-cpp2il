using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000021 RID: 33
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06000199 RID: 409 RVA: 0x00002347 File Offset: 0x00000547
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x04000051 RID: 81
		public object Type;

		// Token: 0x04000052 RID: 82
		public string Member;

		// Token: 0x04000053 RID: 83
		public object[] MemberTypeParameters;

		// Token: 0x04000054 RID: 84
		public object[] MemberParameters;

		// Token: 0x04000055 RID: 85
		public object ReturnType;
	}
}
