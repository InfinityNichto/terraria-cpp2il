using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000013 RID: 19
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x06000066 RID: 102 RVA: 0x000020DD File Offset: 0x000002DD
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x04000014 RID: 20
		public object Type;

		// Token: 0x04000015 RID: 21
		public string Member;

		// Token: 0x04000016 RID: 22
		public object[] MemberTypeParameters;

		// Token: 0x04000017 RID: 23
		public object[] MemberParameters;

		// Token: 0x04000018 RID: 24
		public object ReturnType;
	}
}
