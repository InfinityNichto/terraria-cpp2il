using System;
using Cpp2ILInjected;

namespace System.Net
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000124")]
	internal enum ContextFlagsPal
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000550")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000551")]
		Delegate = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000552")]
		MutualAuth = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000553")]
		ReplayDetect = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000554")]
		SequenceDetect = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4000555")]
		Confidentiality = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000556")]
		UseSessionKey = 32,
		[global::Cpp2ILInjected.Token(Token = "0x4000557")]
		AllocateMemory = 256,
		[global::Cpp2ILInjected.Token(Token = "0x4000558")]
		Connection = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x4000559")]
		InitExtendedError = 16384,
		[global::Cpp2ILInjected.Token(Token = "0x400055A")]
		AcceptExtendedError = 32768,
		[global::Cpp2ILInjected.Token(Token = "0x400055B")]
		InitStream = 32768,
		[global::Cpp2ILInjected.Token(Token = "0x400055C")]
		AcceptStream = 65536,
		[global::Cpp2ILInjected.Token(Token = "0x400055D")]
		InitIntegrity = 65536,
		[global::Cpp2ILInjected.Token(Token = "0x400055E")]
		AcceptIntegrity = 131072,
		[global::Cpp2ILInjected.Token(Token = "0x400055F")]
		InitManualCredValidation = 524288,
		[global::Cpp2ILInjected.Token(Token = "0x4000560")]
		InitUseSuppliedCreds = 128,
		[global::Cpp2ILInjected.Token(Token = "0x4000561")]
		InitIdentify = 131072,
		[global::Cpp2ILInjected.Token(Token = "0x4000562")]
		AcceptIdentify = 524288,
		[global::Cpp2ILInjected.Token(Token = "0x4000563")]
		ProxyBindings = 67108864,
		[global::Cpp2ILInjected.Token(Token = "0x4000564")]
		AllowMissingBindings = 268435456,
		[global::Cpp2ILInjected.Token(Token = "0x4000565")]
		UnverifiedTargetName = 536870912
	}
}
