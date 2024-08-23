using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000262 RID: 610
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002FF")]
	public abstract class SHA512 : HashAlgorithm
	{
		// Token: 0x060017E4 RID: 6116 RVA: 0x0001883C File Offset: 0x00016A3C
		[global::Cpp2ILInjected.Token(Token = "0x60019FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0F914", Offset = "0x1B0F914", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		protected SHA512()
		{
			throw null;
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x0001883F File Offset: 0x00016A3F
		[global::Cpp2ILInjected.Token(Token = "0x60019FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0B78C", Offset = "0x1B0B78C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "InternalHashToHashAlgorithm", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.PKCS1", Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA512Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static SHA512 Create()
		{
			throw null;
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00018842 File Offset: 0x00016A42
		[global::Cpp2ILInjected.Token(Token = "0x6001A00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0FA28", Offset = "0x1B0FA28", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public new static SHA512 Create(string hashName)
		{
			throw null;
		}
	}
}
