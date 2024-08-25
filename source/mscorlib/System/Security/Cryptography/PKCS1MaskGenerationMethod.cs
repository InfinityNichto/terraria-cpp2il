using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002E8")]
	public class PKCS1MaskGenerationMethod : MaskGenerationMethod
	{
		[global::Cpp2ILInjected.Token(Token = "0x60018FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B01190", Offset = "0x1B01190", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAOAEPKeyExchangeDeformatter), Member = "DecryptKeyExchange", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAOAEPKeyExchangeFormatter), Member = "CreateKeyExchange", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public PKCS1MaskGenerationMethod()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002AF")]
		public string HashName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B011E4", Offset = "0x1B011E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60018FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B011EC", Offset = "0x1B011EC", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B01240", Offset = "0x1B01240", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "MGF1", MemberParameters = new object[]
		{
			typeof(HashAlgorithm),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override byte[] GenerateMask(byte[] rgbSeed, int cbReturn)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000CCE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string HashNameValue;
	}
}
