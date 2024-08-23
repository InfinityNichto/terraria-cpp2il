using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Security.Cryptography
{
	// Token: 0x0200022F RID: 559
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002CC")]
	[global::System.Serializable]
	public enum CipherMode
	{
		// Token: 0x040009A6 RID: 2470
		[global::Cpp2ILInjected.Token(Token = "0x4000C80")]
		CBC = 1,
		// Token: 0x040009A7 RID: 2471
		[global::Cpp2ILInjected.Token(Token = "0x4000C81")]
		ECB,
		// Token: 0x040009A8 RID: 2472
		[global::Cpp2ILInjected.Token(Token = "0x4000C82")]
		OFB,
		// Token: 0x040009A9 RID: 2473
		[global::Cpp2ILInjected.Token(Token = "0x4000C83")]
		CFB,
		// Token: 0x040009AA RID: 2474
		[global::Cpp2ILInjected.Token(Token = "0x4000C84")]
		CTS
	}
}
