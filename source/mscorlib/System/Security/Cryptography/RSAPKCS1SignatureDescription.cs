using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000265 RID: 613
	[global::Cpp2ILInjected.Token(Token = "0x2000302")]
	internal abstract class RSAPKCS1SignatureDescription : SignatureDescription
	{
		// Token: 0x06001805 RID: 6149 RVA: 0x0001889F File Offset: 0x00016A9F
		[global::Cpp2ILInjected.Token(Token = "0x6001A1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10974", Offset = "0x1B10974", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1SHA1SignatureDescription), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1SHA256SignatureDescription), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1SHA384SignatureDescription), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1SHA512SignatureDescription), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected RSAPKCS1SignatureDescription(string hashAlgorithm, string digestAlgorithm)
		{
			throw null;
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x000188A2 File Offset: 0x00016AA2
		[global::Cpp2ILInjected.Token(Token = "0x6001A20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10A18", Offset = "0x1B10A18", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureDescription), Member = "CreateDeformatter", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(AsymmetricSignatureDeformatter))]
		public sealed override AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key)
		{
			throw null;
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x000188A5 File Offset: 0x00016AA5
		[global::Cpp2ILInjected.Token(Token = "0x6001A21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10A4C", Offset = "0x1B10A4C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureDescription), Member = "CreateFormatter", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(AsymmetricSignatureFormatter))]
		public sealed override AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key)
		{
			throw null;
		}

		// Token: 0x04000A50 RID: 2640
		[global::Cpp2ILInjected.Token(Token = "0x4000D2A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _hashAlgorithm;
	}
}
