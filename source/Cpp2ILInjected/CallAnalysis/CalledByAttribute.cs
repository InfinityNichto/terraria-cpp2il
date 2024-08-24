using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000769 RID: 1897
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x060047FF RID: 18431 RVA: 0x0002ED96 File Offset: 0x0002CF96
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x040077F2 RID: 30706
		public object Type;

		// Token: 0x040077F3 RID: 30707
		public string Member;

		// Token: 0x040077F4 RID: 30708
		public object[] MemberTypeParameters;

		// Token: 0x040077F5 RID: 30709
		public object[] MemberParameters;

		// Token: 0x040077F6 RID: 30710
		public object ReturnType;
	}
}
