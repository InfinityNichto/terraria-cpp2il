using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000279 RID: 633
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000316")]
	public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
	{
		// Token: 0x060018BC RID: 6332 RVA: 0x00018AAC File Offset: 0x00016CAC
		[global::Cpp2ILInjected.Token(Token = "0x6001AD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1B4E4", Offset = "0x1B1B4E4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricSignatureDeformatter), Member = ".ctor", ReturnType = typeof(void))]
		public RSAPKCS1SignatureDeformatter()
		{
			throw null;
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00018AAF File Offset: 0x00016CAF
		[global::Cpp2ILInjected.Token(Token = "0x6001AD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1B4EC", Offset = "0x1B1B4EC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Crl", Member = "VerifySignature", MemberParameters = new object[] { typeof(RSA) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "VerifySignature", MemberParameters = new object[] { typeof(RSA) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricSignatureDeformatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public RSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key)
		{
			throw null;
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00018AB2 File Offset: 0x00016CB2
		[global::Cpp2ILInjected.Token(Token = "0x6001AD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1B520", Offset = "0x1B1B520", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void SetHashAlgorithm(string strName)
		{
			throw null;
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00018AB5 File Offset: 0x00016CB5
		[global::Cpp2ILInjected.Token(Token = "0x6001AD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1B57C", Offset = "0x1B1B57C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void SetKey(AsymmetricAlgorithm key)
		{
			throw null;
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00018AB8 File Offset: 0x00016CB8
		[global::Cpp2ILInjected.Token(Token = "0x6001ADA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1B664", Offset = "0x1B1B664", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "Verify_v15", MemberParameters = new object[]
		{
			typeof(RSA),
			typeof(string),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			throw null;
		}

		// Token: 0x04000AD0 RID: 2768
		[global::Cpp2ILInjected.Token(Token = "0x4000DAA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RSA rsa;

		// Token: 0x04000AD1 RID: 2769
		[global::Cpp2ILInjected.Token(Token = "0x4000DAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string hashName;
	}
}
