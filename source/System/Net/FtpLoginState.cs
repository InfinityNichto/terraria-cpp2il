using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x020000DF RID: 223
	[global::Cpp2ILInjected.Token(Token = "0x2000149")]
	internal enum FtpLoginState : byte
	{
		// Token: 0x040004E5 RID: 1253
		[global::Cpp2ILInjected.Token(Token = "0x4000678")]
		NotLoggedIn,
		// Token: 0x040004E6 RID: 1254
		[global::Cpp2ILInjected.Token(Token = "0x4000679")]
		LoggedIn,
		// Token: 0x040004E7 RID: 1255
		[global::Cpp2ILInjected.Token(Token = "0x400067A")]
		LoggedInButNeedsRelogin,
		// Token: 0x040004E8 RID: 1256
		[global::Cpp2ILInjected.Token(Token = "0x400067B")]
		ReloginFailed
	}
}
