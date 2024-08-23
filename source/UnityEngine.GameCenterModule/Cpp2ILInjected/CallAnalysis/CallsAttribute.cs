using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001D RID: 29
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00002110 File Offset: 0x00000310
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x04000041 RID: 65
		public object Type;

		// Token: 0x04000042 RID: 66
		public string Member;

		// Token: 0x04000043 RID: 67
		public object[] MemberTypeParameters;

		// Token: 0x04000044 RID: 68
		public object[] MemberParameters;

		// Token: 0x04000045 RID: 69
		public object ReturnType;
	}
}
