using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x0200025E RID: 606
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002FB")]
	public abstract class SHA256 : HashAlgorithm
	{
		// Token: 0x060017BC RID: 6076 RVA: 0x000187C4 File Offset: 0x000169C4
		[global::Cpp2ILInjected.Token(Token = "0x60019D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0DED0", Offset = "0x1B0DED0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		protected SHA256()
		{
			throw null;
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x000187C7 File Offset: 0x000169C7
		[global::Cpp2ILInjected.Token(Token = "0x60019D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0B6EC", Offset = "0x1B0B6EC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "InternalHashToHashAlgorithm", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.PKCS1", Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA256Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static SHA256 Create()
		{
			throw null;
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x000187CA File Offset: 0x000169CA
		[global::Cpp2ILInjected.Token(Token = "0x60019D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0DFD0", Offset = "0x1B0DFD0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public new static SHA256 Create(string hashName)
		{
			throw null;
		}
	}
}
