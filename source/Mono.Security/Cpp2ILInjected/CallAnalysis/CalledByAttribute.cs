using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000056 RID: 86
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06000282 RID: 642 RVA: 0x00003699 File Offset: 0x00001899
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x04000294 RID: 660
		public object Type;

		// Token: 0x04000295 RID: 661
		public string Member;

		// Token: 0x04000296 RID: 662
		public object[] MemberTypeParameters;

		// Token: 0x04000297 RID: 663
		public object[] MemberParameters;

		// Token: 0x04000298 RID: 664
		public object ReturnType;
	}
}
