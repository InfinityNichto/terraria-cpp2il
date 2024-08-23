using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000D RID: 13
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002071 File Offset: 0x00000271
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
