using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x0200027A RID: 634
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000317")]
	public class RSAPKCS1SignatureFormatter : AsymmetricSignatureFormatter
	{
		// Token: 0x060018C1 RID: 6337 RVA: 0x00018ABB File Offset: 0x00016CBB
		[global::Cpp2ILInjected.Token(Token = "0x6001ADB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1B7B4", Offset = "0x1B1B7B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricSignatureFormatter), Member = ".ctor", ReturnType = typeof(void))]
		public RSAPKCS1SignatureFormatter()
		{
			throw null;
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00018ABE File Offset: 0x00016CBE
		[global::Cpp2ILInjected.Token(Token = "0x6001ADC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1B7BC", Offset = "0x1B1B7BC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Builder", Member = "Sign", MemberParameters = new object[] { typeof(RSA) }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricSignatureFormatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public RSAPKCS1SignatureFormatter(AsymmetricAlgorithm key)
		{
			throw null;
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00018AC1 File Offset: 0x00016CC1
		[global::Cpp2ILInjected.Token(Token = "0x6001ADD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1B7F0", Offset = "0x1B1B7F0", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "Sign_v15", MemberParameters = new object[]
		{
			typeof(RSA),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override byte[] CreateSignature(byte[] rgbHash)
		{
			throw null;
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00018AC4 File Offset: 0x00016CC4
		[global::Cpp2ILInjected.Token(Token = "0x6001ADE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1B90C", Offset = "0x1B1B90C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void SetHashAlgorithm(string strName)
		{
			throw null;
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00018AC7 File Offset: 0x00016CC7
		[global::Cpp2ILInjected.Token(Token = "0x6001ADF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1B968", Offset = "0x1B1B968", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void SetKey(AsymmetricAlgorithm key)
		{
			throw null;
		}

		// Token: 0x04000AD2 RID: 2770
		[global::Cpp2ILInjected.Token(Token = "0x4000DAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RSA rsa;

		// Token: 0x04000AD3 RID: 2771
		[global::Cpp2ILInjected.Token(Token = "0x4000DAD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string hash;
	}
}
