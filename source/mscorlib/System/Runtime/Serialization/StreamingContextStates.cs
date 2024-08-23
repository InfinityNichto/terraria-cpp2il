using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Serialization
{
	// Token: 0x02000347 RID: 839
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20003EF")]
	[global::System.Serializable]
	public enum StreamingContextStates
	{
		// Token: 0x04000CEB RID: 3307
		[global::Cpp2ILInjected.Token(Token = "0x4000FDD")]
		CrossProcess = 1,
		// Token: 0x04000CEC RID: 3308
		[global::Cpp2ILInjected.Token(Token = "0x4000FDE")]
		CrossMachine = 2,
		// Token: 0x04000CED RID: 3309
		[global::Cpp2ILInjected.Token(Token = "0x4000FDF")]
		File = 4,
		// Token: 0x04000CEE RID: 3310
		[global::Cpp2ILInjected.Token(Token = "0x4000FE0")]
		Persistence = 8,
		// Token: 0x04000CEF RID: 3311
		[global::Cpp2ILInjected.Token(Token = "0x4000FE1")]
		Remoting = 16,
		// Token: 0x04000CF0 RID: 3312
		[global::Cpp2ILInjected.Token(Token = "0x4000FE2")]
		Other = 32,
		// Token: 0x04000CF1 RID: 3313
		[global::Cpp2ILInjected.Token(Token = "0x4000FE3")]
		Clone = 64,
		// Token: 0x04000CF2 RID: 3314
		[global::Cpp2ILInjected.Token(Token = "0x4000FE4")]
		CrossAppDomain = 128,
		// Token: 0x04000CF3 RID: 3315
		[global::Cpp2ILInjected.Token(Token = "0x4000FE5")]
		All = 255
	}
}
