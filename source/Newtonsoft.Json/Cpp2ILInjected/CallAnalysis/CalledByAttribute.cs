using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x020000F1 RID: 241
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06000A85 RID: 2693 RVA: 0x00003F0B File Offset: 0x0000210B
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x0400035F RID: 863
		public object Type;

		// Token: 0x04000360 RID: 864
		public string Member;

		// Token: 0x04000361 RID: 865
		public object[] MemberTypeParameters;

		// Token: 0x04000362 RID: 866
		public object[] MemberParameters;

		// Token: 0x04000363 RID: 867
		public object ReturnType;
	}
}
