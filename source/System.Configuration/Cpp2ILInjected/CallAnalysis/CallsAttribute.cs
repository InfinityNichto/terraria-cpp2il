using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001A RID: 26
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x0600002E RID: 46 RVA: 0x000020CB File Offset: 0x000002CB
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x04000012 RID: 18
		public object Type;

		// Token: 0x04000013 RID: 19
		public string Member;

		// Token: 0x04000014 RID: 20
		public object[] MemberTypeParameters;

		// Token: 0x04000015 RID: 21
		public object[] MemberParameters;

		// Token: 0x04000016 RID: 22
		public object ReturnType;
	}
}
