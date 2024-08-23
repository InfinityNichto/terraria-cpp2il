using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200023E RID: 574
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002DB")]
	public class HMACMD5 : HMAC
	{
		// Token: 0x0600168F RID: 5775 RVA: 0x0001845B File Offset: 0x0001665B
		[global::Cpp2ILInjected.Token(Token = "0x60018A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE5E4", Offset = "0x1AFE5E4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public HMACMD5()
		{
			throw null;
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x0001845E File Offset: 0x0001665E
		[global::Cpp2ILInjected.Token(Token = "0x60018AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE648", Offset = "0x1AFE648", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2", MemberParameters = new object[]
		{
			"Mono.Security.Protocol.Ntlm.Type2Message",
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD5CryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public HMACMD5(byte[] key)
		{
			throw null;
		}
	}
}
