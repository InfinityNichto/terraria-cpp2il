using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002F7")]
	public class RSAPKCS1KeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
	{
		[global::Cpp2ILInjected.Token(Token = "0x60019B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0CA64", Offset = "0x1B0CA64", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricKeyExchangeDeformatter), Member = ".ctor", ReturnType = typeof(void))]
		public RSAPKCS1KeyExchangeDeformatter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0A944", Offset = "0x1B0A944", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "Decrypt", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricKeyExchangeDeformatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public RSAPKCS1KeyExchangeDeformatter(AsymmetricAlgorithm key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C8")]
		public RandomNumberGenerator RNG
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0CA6C", Offset = "0x1B0CA6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60019BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0CA74", Offset = "0x1B0CA74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C9")]
		public override string Parameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0CA7C", Offset = "0x1B0CA7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60019BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0CA84", Offset = "0x1B0CA84", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0CA88", Offset = "0x1B0CA88", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAPKCS1KeyExchangeDeformatter), Member = "get_OverridesDecrypt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override byte[] DecryptKeyExchange(byte[] rgbIn)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0CE18", Offset = "0x1B0CE18", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void SetKey(AsymmetricAlgorithm key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002CA")]
		private bool OverridesDecrypt
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0CC48", Offset = "0x1B0CC48", Length = "0x1D0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1KeyExchangeDeformatter), Member = "DecryptKeyExchange", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
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

		[global::Cpp2ILInjected.Token(Token = "0x4000D0D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RSA _rsaKey;

		[global::Cpp2ILInjected.Token(Token = "0x4000D0E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool? _rsaOverridesDecrypt;

		[global::Cpp2ILInjected.Token(Token = "0x4000D0F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private RandomNumberGenerator RngValue;
	}
}
