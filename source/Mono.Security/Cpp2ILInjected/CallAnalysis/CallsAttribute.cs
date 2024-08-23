using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000055 RID: 85
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x06000281 RID: 641 RVA: 0x00003696 File Offset: 0x00001896
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x0400028F RID: 655
		public object Type;

		// Token: 0x04000290 RID: 656
		public string Member;

		// Token: 0x04000291 RID: 657
		public object[] MemberTypeParameters;

		// Token: 0x04000292 RID: 658
		public object[] MemberParameters;

		// Token: 0x04000293 RID: 659
		public object ReturnType;
	}
}
