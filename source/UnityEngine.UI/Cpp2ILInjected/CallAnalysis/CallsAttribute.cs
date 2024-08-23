using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200007D RID: 125
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x06000662 RID: 1634 RVA: 0x000032C5 File Offset: 0x000014C5
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x0400023F RID: 575
		public object Type;

		// Token: 0x04000240 RID: 576
		public string Member;

		// Token: 0x04000241 RID: 577
		public object[] MemberTypeParameters;

		// Token: 0x04000242 RID: 578
		public object[] MemberParameters;

		// Token: 0x04000243 RID: 579
		public object ReturnType;
	}
}
