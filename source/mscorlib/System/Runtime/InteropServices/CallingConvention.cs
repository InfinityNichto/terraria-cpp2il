using System;
using Cpp2ILInjected;

namespace System.Runtime.InteropServices
{
	// Token: 0x020003A2 RID: 930
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200044C")]
	[global::System.Serializable]
	public enum CallingConvention
	{
		// Token: 0x04000F81 RID: 3969
		[global::Cpp2ILInjected.Token(Token = "0x4001276")]
		Winapi = 1,
		// Token: 0x04000F82 RID: 3970
		[global::Cpp2ILInjected.Token(Token = "0x4001277")]
		Cdecl,
		// Token: 0x04000F83 RID: 3971
		[global::Cpp2ILInjected.Token(Token = "0x4001278")]
		StdCall,
		// Token: 0x04000F84 RID: 3972
		[global::Cpp2ILInjected.Token(Token = "0x4001279")]
		ThisCall,
		// Token: 0x04000F85 RID: 3973
		[global::Cpp2ILInjected.Token(Token = "0x400127A")]
		FastCall
	}
}
