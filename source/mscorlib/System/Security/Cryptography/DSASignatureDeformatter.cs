using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200023B RID: 571
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002D8")]
	public class DSASignatureDeformatter : AsymmetricSignatureDeformatter
	{
		// Token: 0x06001675 RID: 5749 RVA: 0x0001840D File Offset: 0x0001660D
		[global::Cpp2ILInjected.Token(Token = "0x600188F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFD4A8", Offset = "0x1AFD4A8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSASignatureDeformatter), Member = ".ctor", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "MapNameToOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public DSASignatureDeformatter()
		{
			throw null;
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00018410 File Offset: 0x00016610
		[global::Cpp2ILInjected.Token(Token = "0x6001890")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFD528", Offset = "0x1AFD528", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Crl", Member = "VerifySignature", MemberParameters = new object[] { typeof(DSA) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "VerifySignature", MemberParameters = new object[] { typeof(DSA) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSASignatureDeformatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public DSASignatureDeformatter(AsymmetricAlgorithm key)
		{
			throw null;
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00018413 File Offset: 0x00016613
		[global::Cpp2ILInjected.Token(Token = "0x6001891")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFD618", Offset = "0x1AFD618", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void SetKey(AsymmetricAlgorithm key)
		{
			throw null;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00018416 File Offset: 0x00016616
		[global::Cpp2ILInjected.Token(Token = "0x6001892")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFD700", Offset = "0x1AFD700", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "MapNameToOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void SetHashAlgorithm(string strName)
		{
			throw null;
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00018419 File Offset: 0x00016619
		[global::Cpp2ILInjected.Token(Token = "0x6001893")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFD7C4", Offset = "0x1AFD7C4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			throw null;
		}

		// Token: 0x040009D3 RID: 2515
		[global::Cpp2ILInjected.Token(Token = "0x4000CAD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private DSA _dsaKey;

		// Token: 0x040009D4 RID: 2516
		[global::Cpp2ILInjected.Token(Token = "0x4000CAE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _oid;
	}
}
