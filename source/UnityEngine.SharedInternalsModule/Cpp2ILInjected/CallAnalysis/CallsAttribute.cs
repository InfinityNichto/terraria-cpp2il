using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000027 RID: 39
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00002122 File Offset: 0x00000322
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x0400002E RID: 46
		public object Type;

		// Token: 0x0400002F RID: 47
		public string Member;

		// Token: 0x04000030 RID: 48
		public object[] MemberTypeParameters;

		// Token: 0x04000031 RID: 49
		public object[] MemberParameters;

		// Token: 0x04000032 RID: 50
		public object ReturnType;
	}
}
