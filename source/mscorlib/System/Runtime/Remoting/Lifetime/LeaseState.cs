using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x020002C2 RID: 706
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000363")]
	[global::System.Serializable]
	public enum LeaseState
	{
		// Token: 0x04000BB3 RID: 2995
		[global::Cpp2ILInjected.Token(Token = "0x4000E97")]
		Null,
		// Token: 0x04000BB4 RID: 2996
		[global::Cpp2ILInjected.Token(Token = "0x4000E98")]
		Initial,
		// Token: 0x04000BB5 RID: 2997
		[global::Cpp2ILInjected.Token(Token = "0x4000E99")]
		Active,
		// Token: 0x04000BB6 RID: 2998
		[global::Cpp2ILInjected.Token(Token = "0x4000E9A")]
		Renewing,
		// Token: 0x04000BB7 RID: 2999
		[global::Cpp2ILInjected.Token(Token = "0x4000E9B")]
		Expired
	}
}
