using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000018 RID: 24
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x0600002A RID: 42 RVA: 0x0000209B File Offset: 0x0000029B
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x04000013 RID: 19
		public object Type;

		// Token: 0x04000014 RID: 20
		public string Member;

		// Token: 0x04000015 RID: 21
		public object[] MemberTypeParameters;

		// Token: 0x04000016 RID: 22
		public object[] MemberParameters;

		// Token: 0x04000017 RID: 23
		public object ReturnType;
	}
}
