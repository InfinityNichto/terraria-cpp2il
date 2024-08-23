using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x02000101 RID: 257
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000185")]
	public enum AuthenticationSchemes
	{
		// Token: 0x0400059B RID: 1435
		[global::Cpp2ILInjected.Token(Token = "0x40007A9")]
		None = 0,
		// Token: 0x0400059C RID: 1436
		[global::Cpp2ILInjected.Token(Token = "0x40007AA")]
		Digest = 1,
		// Token: 0x0400059D RID: 1437
		[global::Cpp2ILInjected.Token(Token = "0x40007AB")]
		Negotiate = 2,
		// Token: 0x0400059E RID: 1438
		[global::Cpp2ILInjected.Token(Token = "0x40007AC")]
		Ntlm = 4,
		// Token: 0x0400059F RID: 1439
		[global::Cpp2ILInjected.Token(Token = "0x40007AD")]
		Basic = 8,
		// Token: 0x040005A0 RID: 1440
		[global::Cpp2ILInjected.Token(Token = "0x40007AE")]
		Anonymous = 32768,
		// Token: 0x040005A1 RID: 1441
		[global::Cpp2ILInjected.Token(Token = "0x40007AF")]
		IntegratedWindowsAuthentication = 6
	}
}
