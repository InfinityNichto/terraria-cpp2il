using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001B RID: 27
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : Attribute
	{
		// Token: 0x0600005A RID: 90 RVA: 0x0000215B File Offset: 0x0000035B
		public CalledByAttribute()
		{
			throw null;
		}

		// Token: 0x04000040 RID: 64
		public object Type;

		// Token: 0x04000041 RID: 65
		public string Member;

		// Token: 0x04000042 RID: 66
		public object[] MemberTypeParameters;

		// Token: 0x04000043 RID: 67
		public object[] MemberParameters;

		// Token: 0x04000044 RID: 68
		public object ReturnType;
	}
}
