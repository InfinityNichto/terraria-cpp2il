using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200002B RID: 43
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00002122 File Offset: 0x00000322
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x04000062 RID: 98
		public object Type;

		// Token: 0x04000063 RID: 99
		public string Member;

		// Token: 0x04000064 RID: 100
		public object[] MemberTypeParameters;

		// Token: 0x04000065 RID: 101
		public object[] MemberParameters;

		// Token: 0x04000066 RID: 102
		public object ReturnType;
	}
}
