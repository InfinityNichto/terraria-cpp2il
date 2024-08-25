using System;
using Cpp2ILInjected;

namespace Mono.Security.Protocol.Ntlm
{
	[global::Cpp2ILInjected.Token(Token = "0x200003C")]
	public enum NtlmAuthLevel
	{
		[global::Cpp2ILInjected.Token(Token = "0x40000D9")]
		LM_and_NTLM,
		[global::Cpp2ILInjected.Token(Token = "0x40000DA")]
		LM_and_NTLM_and_try_NTLMv2_Session,
		[global::Cpp2ILInjected.Token(Token = "0x40000DB")]
		NTLM_only,
		[global::Cpp2ILInjected.Token(Token = "0x40000DC")]
		NTLMv2_only
	}
}
