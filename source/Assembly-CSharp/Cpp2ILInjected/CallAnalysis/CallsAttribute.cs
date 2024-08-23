using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000768 RID: 1896
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x060047FE RID: 18430 RVA: 0x0002ED93 File Offset: 0x0002CF93
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x040077ED RID: 30701
		public object Type;

		// Token: 0x040077EE RID: 30702
		public string Member;

		// Token: 0x040077EF RID: 30703
		public object[] MemberTypeParameters;

		// Token: 0x040077F0 RID: 30704
		public object[] MemberParameters;

		// Token: 0x040077F1 RID: 30705
		public object ReturnType;
	}
}
