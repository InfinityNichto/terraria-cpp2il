using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200005A RID: 90
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06000410 RID: 1040 RVA: 0x00005AA9 File Offset: 0x00003CA9
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x040002D9 RID: 729
		public object Type;

		// Token: 0x040002DA RID: 730
		public string Member;

		// Token: 0x040002DB RID: 731
		public object[] MemberTypeParameters;

		// Token: 0x040002DC RID: 732
		public object[] MemberParameters;

		// Token: 0x040002DD RID: 733
		public object ReturnType;
	}
}
