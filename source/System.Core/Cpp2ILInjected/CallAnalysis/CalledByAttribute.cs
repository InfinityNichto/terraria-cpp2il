using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000023 RID: 35
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x000044DE File Offset: 0x000026DE
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x04000051 RID: 81
		public object Type;

		// Token: 0x04000052 RID: 82
		public string Member;

		// Token: 0x04000053 RID: 83
		public object[] MemberTypeParameters;

		// Token: 0x04000054 RID: 84
		public object[] MemberParameters;

		// Token: 0x04000055 RID: 85
		public object ReturnType;
	}
}
