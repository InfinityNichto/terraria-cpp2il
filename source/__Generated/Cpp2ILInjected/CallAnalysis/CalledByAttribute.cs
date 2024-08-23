using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000010 RID: 16
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002074 File Offset: 0x00000274
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x0400000E RID: 14
		public object Type;

		// Token: 0x0400000F RID: 15
		public string Member;

		// Token: 0x04000010 RID: 16
		public object[] MemberTypeParameters;

		// Token: 0x04000011 RID: 17
		public object[] MemberParameters;

		// Token: 0x04000012 RID: 18
		public object ReturnType;
	}
}
