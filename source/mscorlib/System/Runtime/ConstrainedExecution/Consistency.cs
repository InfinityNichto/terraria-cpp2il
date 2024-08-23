using System;
using Cpp2ILInjected;

namespace System.Runtime.ConstrainedExecution
{
	// Token: 0x020003B1 RID: 945
	[global::Cpp2ILInjected.Token(Token = "0x200045E")]
	public enum Consistency
	{
		// Token: 0x04000FA5 RID: 4005
		[global::Cpp2ILInjected.Token(Token = "0x400129C")]
		MayCorruptProcess,
		// Token: 0x04000FA6 RID: 4006
		[global::Cpp2ILInjected.Token(Token = "0x400129D")]
		MayCorruptAppDomain,
		// Token: 0x04000FA7 RID: 4007
		[global::Cpp2ILInjected.Token(Token = "0x400129E")]
		MayCorruptInstance,
		// Token: 0x04000FA8 RID: 4008
		[global::Cpp2ILInjected.Token(Token = "0x400129F")]
		WillNotCorruptState
	}
}
