using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000059 RID: 89
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x0600040F RID: 1039 RVA: 0x00005AA6 File Offset: 0x00003CA6
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x040002D4 RID: 724
		public object Type;

		// Token: 0x040002D5 RID: 725
		public string Member;

		// Token: 0x040002D6 RID: 726
		public object[] MemberTypeParameters;

		// Token: 0x040002D7 RID: 727
		public object[] MemberParameters;

		// Token: 0x040002D8 RID: 728
		public object ReturnType;
	}
}
