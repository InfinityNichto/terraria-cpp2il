using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x020001E8 RID: 488
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x0600084E RID: 2126 RVA: 0x00003917 File Offset: 0x00001B17
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x040003C8 RID: 968
		public object Type;

		// Token: 0x040003C9 RID: 969
		public string Member;

		// Token: 0x040003CA RID: 970
		public object[] MemberTypeParameters;

		// Token: 0x040003CB RID: 971
		public object[] MemberParameters;

		// Token: 0x040003CC RID: 972
		public object ReturnType;
	}
}
