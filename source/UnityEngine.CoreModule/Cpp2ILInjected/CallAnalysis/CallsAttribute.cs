using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200015E RID: 350
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x060006B2 RID: 1714 RVA: 0x00002F7A File Offset: 0x0000117A
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x04000626 RID: 1574
		public object Type;

		// Token: 0x04000627 RID: 1575
		public string Member;

		// Token: 0x04000628 RID: 1576
		public object[] MemberTypeParameters;

		// Token: 0x04000629 RID: 1577
		public object[] MemberParameters;

		// Token: 0x0400062A RID: 1578
		public object ReturnType;
	}
}
