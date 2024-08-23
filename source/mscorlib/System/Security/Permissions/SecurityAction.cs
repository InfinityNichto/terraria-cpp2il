using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Security.Permissions
{
	// Token: 0x02000216 RID: 534
	[global::System.Obsolete("CAS support is not available with Silverlight applications.")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002AE")]
	[global::System.Serializable]
	public enum SecurityAction
	{
		// Token: 0x0400094A RID: 2378
		[global::Cpp2ILInjected.Token(Token = "0x4000BF2")]
		Demand = 2,
		// Token: 0x0400094B RID: 2379
		[global::Cpp2ILInjected.Token(Token = "0x4000BF3")]
		Assert,
		// Token: 0x0400094C RID: 2380
		[global::System.Obsolete("This requests should not be used")]
		[global::Cpp2ILInjected.Token(Token = "0x4000BF4")]
		Deny,
		// Token: 0x0400094D RID: 2381
		[global::Cpp2ILInjected.Token(Token = "0x4000BF5")]
		PermitOnly,
		// Token: 0x0400094E RID: 2382
		[global::Cpp2ILInjected.Token(Token = "0x4000BF6")]
		LinkDemand,
		// Token: 0x0400094F RID: 2383
		[global::Cpp2ILInjected.Token(Token = "0x4000BF7")]
		InheritanceDemand,
		// Token: 0x04000950 RID: 2384
		[global::System.Obsolete("This requests should not be used")]
		[global::Cpp2ILInjected.Token(Token = "0x4000BF8")]
		RequestMinimum,
		// Token: 0x04000951 RID: 2385
		[global::System.Obsolete("This requests should not be used")]
		[global::Cpp2ILInjected.Token(Token = "0x4000BF9")]
		RequestOptional,
		// Token: 0x04000952 RID: 2386
		[global::System.Obsolete("This requests should not be used")]
		[global::Cpp2ILInjected.Token(Token = "0x4000BFA")]
		RequestRefuse
	}
}
