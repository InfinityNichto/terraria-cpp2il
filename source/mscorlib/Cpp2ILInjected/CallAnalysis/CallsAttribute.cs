using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000557 RID: 1367
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : global::System.Attribute
	{
		// Token: 0x06002D5F RID: 11615 RVA: 0x0001C361 File Offset: 0x0001A561
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x040016CB RID: 5835
		public object Type;

		// Token: 0x040016CC RID: 5836
		public string Member;

		// Token: 0x040016CD RID: 5837
		public object[] MemberTypeParameters;

		// Token: 0x040016CE RID: 5838
		public object[] MemberParameters;

		// Token: 0x040016CF RID: 5839
		public object ReturnType;
	}
}
