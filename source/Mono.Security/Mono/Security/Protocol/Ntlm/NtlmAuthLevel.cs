using System;
using Cpp2ILInjected;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000021 RID: 33
	[global::Cpp2ILInjected.Token(Token = "0x200003C")]
	public enum NtlmAuthLevel
	{
		// Token: 0x040000AC RID: 172
		[global::Cpp2ILInjected.Token(Token = "0x40000D9")]
		LM_and_NTLM,
		// Token: 0x040000AD RID: 173
		[global::Cpp2ILInjected.Token(Token = "0x40000DA")]
		LM_and_NTLM_and_try_NTLMv2_Session,
		// Token: 0x040000AE RID: 174
		[global::Cpp2ILInjected.Token(Token = "0x40000DB")]
		NTLM_only,
		// Token: 0x040000AF RID: 175
		[global::Cpp2ILInjected.Token(Token = "0x40000DC")]
		NTLMv2_only
	}
}
