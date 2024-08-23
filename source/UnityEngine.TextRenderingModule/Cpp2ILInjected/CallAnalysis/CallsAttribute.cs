using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000017 RID: 23
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x06000036 RID: 54 RVA: 0x000020C8 File Offset: 0x000002C8
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x04000053 RID: 83
		public object Type;

		// Token: 0x04000054 RID: 84
		public string Member;

		// Token: 0x04000055 RID: 85
		public object[] MemberTypeParameters;

		// Token: 0x04000056 RID: 86
		public object[] MemberParameters;

		// Token: 0x04000057 RID: 87
		public object ReturnType;
	}
}
