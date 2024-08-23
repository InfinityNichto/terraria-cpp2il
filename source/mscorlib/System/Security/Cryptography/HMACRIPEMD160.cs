using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200023F RID: 575
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002DC")]
	public class HMACRIPEMD160 : HMAC
	{
		// Token: 0x06001691 RID: 5777 RVA: 0x00018461 File Offset: 0x00016661
		[global::Cpp2ILInjected.Token(Token = "0x60018AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE704", Offset = "0x1AFE704", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public HMACRIPEMD160()
		{
			throw null;
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00018464 File Offset: 0x00016664
		[global::Cpp2ILInjected.Token(Token = "0x60018AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE768", Offset = "0x1AFE768", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RIPEMD160Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public HMACRIPEMD160(byte[] key)
		{
			throw null;
		}
	}
}
