using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x020000C3 RID: 195
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000124")]
	internal enum ContextFlagsPal
	{
		// Token: 0x040003DB RID: 987
		[global::Cpp2ILInjected.Token(Token = "0x4000550")]
		None = 0,
		// Token: 0x040003DC RID: 988
		[global::Cpp2ILInjected.Token(Token = "0x4000551")]
		Delegate = 1,
		// Token: 0x040003DD RID: 989
		[global::Cpp2ILInjected.Token(Token = "0x4000552")]
		MutualAuth = 2,
		// Token: 0x040003DE RID: 990
		[global::Cpp2ILInjected.Token(Token = "0x4000553")]
		ReplayDetect = 4,
		// Token: 0x040003DF RID: 991
		[global::Cpp2ILInjected.Token(Token = "0x4000554")]
		SequenceDetect = 8,
		// Token: 0x040003E0 RID: 992
		[global::Cpp2ILInjected.Token(Token = "0x4000555")]
		Confidentiality = 16,
		// Token: 0x040003E1 RID: 993
		[global::Cpp2ILInjected.Token(Token = "0x4000556")]
		UseSessionKey = 32,
		// Token: 0x040003E2 RID: 994
		[global::Cpp2ILInjected.Token(Token = "0x4000557")]
		AllocateMemory = 256,
		// Token: 0x040003E3 RID: 995
		[global::Cpp2ILInjected.Token(Token = "0x4000558")]
		Connection = 2048,
		// Token: 0x040003E4 RID: 996
		[global::Cpp2ILInjected.Token(Token = "0x4000559")]
		InitExtendedError = 16384,
		// Token: 0x040003E5 RID: 997
		[global::Cpp2ILInjected.Token(Token = "0x400055A")]
		AcceptExtendedError = 32768,
		// Token: 0x040003E6 RID: 998
		[global::Cpp2ILInjected.Token(Token = "0x400055B")]
		InitStream = 32768,
		// Token: 0x040003E7 RID: 999
		[global::Cpp2ILInjected.Token(Token = "0x400055C")]
		AcceptStream = 65536,
		// Token: 0x040003E8 RID: 1000
		[global::Cpp2ILInjected.Token(Token = "0x400055D")]
		InitIntegrity = 65536,
		// Token: 0x040003E9 RID: 1001
		[global::Cpp2ILInjected.Token(Token = "0x400055E")]
		AcceptIntegrity = 131072,
		// Token: 0x040003EA RID: 1002
		[global::Cpp2ILInjected.Token(Token = "0x400055F")]
		InitManualCredValidation = 524288,
		// Token: 0x040003EB RID: 1003
		[global::Cpp2ILInjected.Token(Token = "0x4000560")]
		InitUseSuppliedCreds = 128,
		// Token: 0x040003EC RID: 1004
		[global::Cpp2ILInjected.Token(Token = "0x4000561")]
		InitIdentify = 131072,
		// Token: 0x040003ED RID: 1005
		[global::Cpp2ILInjected.Token(Token = "0x4000562")]
		AcceptIdentify = 524288,
		// Token: 0x040003EE RID: 1006
		[global::Cpp2ILInjected.Token(Token = "0x4000563")]
		ProxyBindings = 67108864,
		// Token: 0x040003EF RID: 1007
		[global::Cpp2ILInjected.Token(Token = "0x4000564")]
		AllowMissingBindings = 268435456,
		// Token: 0x040003F0 RID: 1008
		[global::Cpp2ILInjected.Token(Token = "0x4000565")]
		UnverifiedTargetName = 536870912
	}
}
