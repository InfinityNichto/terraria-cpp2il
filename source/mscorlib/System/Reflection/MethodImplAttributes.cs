using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x20004DE")]
	public enum MethodImplAttributes
	{
		[global::Cpp2ILInjected.Token(Token = "0x40013D7")]
		CodeTypeMask = 3,
		[global::Cpp2ILInjected.Token(Token = "0x40013D8")]
		IL = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40013D9")]
		Native,
		[global::Cpp2ILInjected.Token(Token = "0x40013DA")]
		OPTIL,
		[global::Cpp2ILInjected.Token(Token = "0x40013DB")]
		Runtime,
		[global::Cpp2ILInjected.Token(Token = "0x40013DC")]
		ManagedMask,
		[global::Cpp2ILInjected.Token(Token = "0x40013DD")]
		Unmanaged = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40013DE")]
		Managed = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40013DF")]
		ForwardRef = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40013E0")]
		PreserveSig = 128,
		[global::Cpp2ILInjected.Token(Token = "0x40013E1")]
		InternalCall = 4096,
		[global::Cpp2ILInjected.Token(Token = "0x40013E2")]
		Synchronized = 32,
		[global::Cpp2ILInjected.Token(Token = "0x40013E3")]
		NoInlining = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40013E4")]
		AggressiveInlining = 256,
		[global::Cpp2ILInjected.Token(Token = "0x40013E5")]
		NoOptimization = 64,
		[global::Cpp2ILInjected.Token(Token = "0x40013E6")]
		MaxMethodImplVal = 65535,
		[global::Cpp2ILInjected.Token(Token = "0x40013E7")]
		SecurityMitigations = 1024
	}
}
