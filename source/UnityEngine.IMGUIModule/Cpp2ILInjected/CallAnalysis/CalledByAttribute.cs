using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000027 RID: 39
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x0600012F RID: 303 RVA: 0x0000232F File Offset: 0x0000052F
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x040000E7 RID: 231
		public object Type;

		// Token: 0x040000E8 RID: 232
		public string Member;

		// Token: 0x040000E9 RID: 233
		public object[] MemberTypeParameters;

		// Token: 0x040000EA RID: 234
		public object[] MemberParameters;

		// Token: 0x040000EB RID: 235
		public object ReturnType;
	}
}
