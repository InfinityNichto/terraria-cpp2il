using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000148 RID: 328
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x06000C38 RID: 3128 RVA: 0x00005216 File Offset: 0x00003416
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x040004F5 RID: 1269
		public object Type;

		// Token: 0x040004F6 RID: 1270
		public string Member;

		// Token: 0x040004F7 RID: 1271
		public object[] MemberTypeParameters;

		// Token: 0x040004F8 RID: 1272
		public object[] MemberParameters;

		// Token: 0x040004F9 RID: 1273
		public object ReturnType;
	}
}
