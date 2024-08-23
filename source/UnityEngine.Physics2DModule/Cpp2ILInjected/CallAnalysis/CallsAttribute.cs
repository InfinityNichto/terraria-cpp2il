using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000010 RID: 16
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x06000010 RID: 16 RVA: 0x0000207D File Offset: 0x0000027D
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x04000010 RID: 16
		public object Type;

		// Token: 0x04000011 RID: 17
		public string Member;

		// Token: 0x04000012 RID: 18
		public object[] MemberTypeParameters;

		// Token: 0x04000013 RID: 19
		public object[] MemberParameters;

		// Token: 0x04000014 RID: 20
		public object ReturnType;
	}
}
