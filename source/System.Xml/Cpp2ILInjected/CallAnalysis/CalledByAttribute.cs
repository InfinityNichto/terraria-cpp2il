using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000149 RID: 329
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x06000C39 RID: 3129 RVA: 0x00005219 File Offset: 0x00003419
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x040004FA RID: 1274
		public object Type;

		// Token: 0x040004FB RID: 1275
		public string Member;

		// Token: 0x040004FC RID: 1276
		public object[] MemberTypeParameters;

		// Token: 0x040004FD RID: 1277
		public object[] MemberParameters;

		// Token: 0x040004FE RID: 1278
		public object ReturnType;
	}
}
