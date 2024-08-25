using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20004FD")]
	[global::System.Serializable]
	internal enum PInvokeAttributes
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001490")]
		NoMangle = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4001491")]
		CharSetMask = 6,
		[global::Cpp2ILInjected.Token(Token = "0x4001492")]
		CharSetNotSpec = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4001493")]
		CharSetAnsi = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4001494")]
		CharSetUnicode = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4001495")]
		CharSetAuto = 6,
		[global::Cpp2ILInjected.Token(Token = "0x4001496")]
		BestFitUseAssem = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4001497")]
		BestFitEnabled = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4001498")]
		BestFitDisabled = 32,
		[global::Cpp2ILInjected.Token(Token = "0x4001499")]
		BestFitMask = 48,
		[global::Cpp2ILInjected.Token(Token = "0x400149A")]
		ThrowOnUnmappableCharUseAssem = 0,
		[global::Cpp2ILInjected.Token(Token = "0x400149B")]
		ThrowOnUnmappableCharEnabled = 4096,
		[global::Cpp2ILInjected.Token(Token = "0x400149C")]
		ThrowOnUnmappableCharDisabled = 8192,
		[global::Cpp2ILInjected.Token(Token = "0x400149D")]
		ThrowOnUnmappableCharMask = 12288,
		[global::Cpp2ILInjected.Token(Token = "0x400149E")]
		SupportsLastError = 64,
		[global::Cpp2ILInjected.Token(Token = "0x400149F")]
		CallConvMask = 1792,
		[global::Cpp2ILInjected.Token(Token = "0x40014A0")]
		CallConvWinapi = 256,
		[global::Cpp2ILInjected.Token(Token = "0x40014A1")]
		CallConvCdecl = 512,
		[global::Cpp2ILInjected.Token(Token = "0x40014A2")]
		CallConvStdcall = 768,
		[global::Cpp2ILInjected.Token(Token = "0x40014A3")]
		CallConvThiscall = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x40014A4")]
		CallConvFastcall = 1280,
		[global::Cpp2ILInjected.Token(Token = "0x40014A5")]
		MaxValue = 65535
	}
}
