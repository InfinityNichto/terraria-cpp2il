using System;
using Cpp2ILInjected;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200039D RID: 925
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000447")]
	public enum DllImportSearchPath
	{
		// Token: 0x04000F6A RID: 3946
		[global::Cpp2ILInjected.Token(Token = "0x400125F")]
		UseDllDirectoryForDependencies = 256,
		// Token: 0x04000F6B RID: 3947
		[global::Cpp2ILInjected.Token(Token = "0x4001260")]
		ApplicationDirectory = 512,
		// Token: 0x04000F6C RID: 3948
		[global::Cpp2ILInjected.Token(Token = "0x4001261")]
		UserDirectories = 1024,
		// Token: 0x04000F6D RID: 3949
		[global::Cpp2ILInjected.Token(Token = "0x4001262")]
		System32 = 2048,
		// Token: 0x04000F6E RID: 3950
		[global::Cpp2ILInjected.Token(Token = "0x4001263")]
		SafeDirectories = 4096,
		// Token: 0x04000F6F RID: 3951
		[global::Cpp2ILInjected.Token(Token = "0x4001264")]
		AssemblyDirectory = 2,
		// Token: 0x04000F70 RID: 3952
		[global::Cpp2ILInjected.Token(Token = "0x4001265")]
		LegacyBehavior = 0
	}
}
