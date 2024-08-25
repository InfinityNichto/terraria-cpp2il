using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002F6")]
	public class RSAOAEPKeyExchangeFormatter : AsymmetricKeyExchangeFormatter
	{
		[global::Cpp2ILInjected.Token(Token = "0x60019AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0C448", Offset = "0x1B0C448", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricKeyExchangeFormatter), Member = ".ctor", ReturnType = typeof(void))]
		public RSAOAEPKeyExchangeFormatter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0AAC0", Offset = "0x1B0AAC0", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "Encrypt", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricKeyExchangeFormatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public RSAOAEPKeyExchangeFormatter(AsymmetricAlgorithm key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C4")]
		public byte[] Parameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0C450", Offset = "0x1B0C450", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60019B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0C4C4", Offset = "0x1B0C4C4", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C5")]
		public override string Parameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0C56C", Offset = "0x1B0C56C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C6")]
		public RandomNumberGenerator Rng
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0C574", Offset = "0x1B0C574", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60019B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0C57C", Offset = "0x1B0C57C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0C584", Offset = "0x1B0C584", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void SetKey(AsymmetricAlgorithm key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0C670", Offset = "0x1B0C670", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAOAEPKeyExchangeFormatter), Member = "get_OverridesEncrypt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1MaskGenerationMethod), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RsaOaepEncrypt", MemberParameters = new object[]
		{
			typeof(RSA),
			typeof(HashAlgorithm),
			typeof(PKCS1MaskGenerationMethod),
			typeof(RandomNumberGenerator),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override byte[] CreateKeyExchange(byte[] rgbData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0CA58", Offset = "0x1B0CA58", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override byte[] CreateKeyExchange(byte[] rgbData, global::System.Type symAlgType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C7")]
		private bool OverridesEncrypt
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0C808", Offset = "0x1B0C808", Length = "0x1D0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAOAEPKeyExchangeFormatter), Member = "CreateKeyExchange", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DoesRsaKeyOverride", MemberParameters = new object[]
			{
				typeof(RSA),
				typeof(string),
				typeof(global::System.Type[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Nullable<>), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000D09")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private byte[] ParameterValue;

		[global::Cpp2ILInjected.Token(Token = "0x4000D0A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private RSA _rsaKey;

		[global::Cpp2ILInjected.Token(Token = "0x4000D0B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool? _rsaOverridesEncrypt;

		[global::Cpp2ILInjected.Token(Token = "0x4000D0C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private RandomNumberGenerator RngValue;
	}
}
