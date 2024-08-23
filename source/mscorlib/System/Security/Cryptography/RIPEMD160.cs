using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000253 RID: 595
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002F0")]
	public abstract class RIPEMD160 : HashAlgorithm
	{
		// Token: 0x06001726 RID: 5926 RVA: 0x00018608 File Offset: 0x00016808
		[global::Cpp2ILInjected.Token(Token = "0x6001940")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B054F8", Offset = "0x1B054F8", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected RIPEMD160()
		{
			throw null;
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x0001860B File Offset: 0x0001680B
		[global::Cpp2ILInjected.Token(Token = "0x6001941")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B05518", Offset = "0x1B05518", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.PKCS1", Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RIPEMD160Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static RIPEMD160 Create()
		{
			throw null;
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x0001860E File Offset: 0x0001680E
		[global::Cpp2ILInjected.Token(Token = "0x6001942")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B05568", Offset = "0x1B05568", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public new static RIPEMD160 Create(string hashName)
		{
			throw null;
		}
	}
}
