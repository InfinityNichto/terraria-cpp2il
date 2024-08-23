using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000558 RID: 1368
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : global::System.Attribute
	{
		// Token: 0x06002D60 RID: 11616 RVA: 0x0001C364 File Offset: 0x0001A564
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x040016D0 RID: 5840
		public object Type;

		// Token: 0x040016D1 RID: 5841
		public string Member;

		// Token: 0x040016D2 RID: 5842
		public object[] MemberTypeParameters;

		// Token: 0x040016D3 RID: 5843
		public object[] MemberParameters;

		// Token: 0x040016D4 RID: 5844
		public object ReturnType;
	}
}
