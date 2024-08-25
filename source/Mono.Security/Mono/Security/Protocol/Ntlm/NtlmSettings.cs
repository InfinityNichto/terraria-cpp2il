using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Protocol.Ntlm
{
	[global::Cpp2ILInjected.Token(Token = "0x200003E")]
	public static class NtlmSettings
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000085")]
		public static NtlmAuthLevel DefaultAuthLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A99F60", Offset = "0x1A99F60", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60001D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A99FB8", Offset = "0x1A99FB8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static NtlmSettings()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40000E8")]
		private static NtlmAuthLevel defaultAuthLevel;
	}
}
