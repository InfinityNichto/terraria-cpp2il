using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20004DC")]
	public enum MethodAttributes
	{
		[global::Cpp2ILInjected.Token(Token = "0x40013BE")]
		MemberAccessMask = 7,
		[global::Cpp2ILInjected.Token(Token = "0x40013BF")]
		PrivateScope = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40013C0")]
		Private = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40013C1")]
		FamANDAssem = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40013C2")]
		Assembly = 3,
		[global::Cpp2ILInjected.Token(Token = "0x40013C3")]
		Family = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40013C4")]
		FamORAssem = 5,
		[global::Cpp2ILInjected.Token(Token = "0x40013C5")]
		Public = 6,
		[global::Cpp2ILInjected.Token(Token = "0x40013C6")]
		Static = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40013C7")]
		Final = 32,
		[global::Cpp2ILInjected.Token(Token = "0x40013C8")]
		Virtual = 64,
		[global::Cpp2ILInjected.Token(Token = "0x40013C9")]
		HideBySig = 128,
		[global::Cpp2ILInjected.Token(Token = "0x40013CA")]
		CheckAccessOnOverride = 512,
		[global::Cpp2ILInjected.Token(Token = "0x40013CB")]
		VtableLayoutMask = 256,
		[global::Cpp2ILInjected.Token(Token = "0x40013CC")]
		ReuseSlot = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40013CD")]
		NewSlot = 256,
		[global::Cpp2ILInjected.Token(Token = "0x40013CE")]
		Abstract = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x40013CF")]
		SpecialName = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x40013D0")]
		PinvokeImpl = 8192,
		[global::Cpp2ILInjected.Token(Token = "0x40013D1")]
		UnmanagedExport = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40013D2")]
		RTSpecialName = 4096,
		[global::Cpp2ILInjected.Token(Token = "0x40013D3")]
		HasSecurity = 16384,
		[global::Cpp2ILInjected.Token(Token = "0x40013D4")]
		RequireSecObject = 32768,
		[global::Cpp2ILInjected.Token(Token = "0x40013D5")]
		ReservedMask = 53248
	}
}
