using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000388 RID: 904
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x06001CE5 RID: 7397 RVA: 0x00007FC7 File Offset: 0x000061C7
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x04000FCD RID: 4045
		public object Type;

		// Token: 0x04000FCE RID: 4046
		public string Member;

		// Token: 0x04000FCF RID: 4047
		public object[] MemberTypeParameters;

		// Token: 0x04000FD0 RID: 4048
		public object[] MemberParameters;

		// Token: 0x04000FD1 RID: 4049
		public object ReturnType;
	}
}
