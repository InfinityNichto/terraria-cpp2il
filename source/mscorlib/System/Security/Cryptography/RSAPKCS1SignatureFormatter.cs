using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000317")]
	public class RSAPKCS1SignatureFormatter : AsymmetricSignatureFormatter
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6001ADE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1B90C", Offset = "0x1B1B90C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void SetHashAlgorithm(string strName)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000DAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RSA rsa;

		[global::Cpp2ILInjected.Token(Token = "0x4000DAD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string hash;
	}
}
