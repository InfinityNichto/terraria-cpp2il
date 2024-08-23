using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Security.Cryptography
{
	// Token: 0x02000234 RID: 564
	[global::System.Flags]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002D1")]
	[global::System.Serializable]
	public enum CspProviderFlags
	{
		// Token: 0x040009B8 RID: 2488
		[global::Cpp2ILInjected.Token(Token = "0x4000C92")]
		NoFlags = 0,
		// Token: 0x040009B9 RID: 2489
		[global::Cpp2ILInjected.Token(Token = "0x4000C93")]
		UseMachineKeyStore = 1,
		// Token: 0x040009BA RID: 2490
		[global::Cpp2ILInjected.Token(Token = "0x4000C94")]
		UseDefaultKeyContainer = 2,
		// Token: 0x040009BB RID: 2491
		[global::Cpp2ILInjected.Token(Token = "0x4000C95")]
		UseNonExportableKey = 4,
		// Token: 0x040009BC RID: 2492
		[global::Cpp2ILInjected.Token(Token = "0x4000C96")]
		UseExistingKey = 8,
		// Token: 0x040009BD RID: 2493
		[global::Cpp2ILInjected.Token(Token = "0x4000C97")]
		UseArchivableKey = 16,
		// Token: 0x040009BE RID: 2494
		[global::Cpp2ILInjected.Token(Token = "0x4000C98")]
		UseUserProtectedKey = 32,
		// Token: 0x040009BF RID: 2495
		[global::Cpp2ILInjected.Token(Token = "0x4000C99")]
		NoPrompt = 64,
		// Token: 0x040009C0 RID: 2496
		[global::Cpp2ILInjected.Token(Token = "0x4000C9A")]
		CreateEphemeralKey = 128
	}
}
