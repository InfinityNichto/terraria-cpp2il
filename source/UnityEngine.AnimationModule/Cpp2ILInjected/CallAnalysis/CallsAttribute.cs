using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200002A RID: 42
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x0600004D RID: 77 RVA: 0x0000211F File Offset: 0x0000031F
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x0400005D RID: 93
		public object Type;

		// Token: 0x0400005E RID: 94
		public string Member;

		// Token: 0x0400005F RID: 95
		public object[] MemberTypeParameters;

		// Token: 0x04000060 RID: 96
		public object[] MemberParameters;

		// Token: 0x04000061 RID: 97
		public object ReturnType;
	}
}
