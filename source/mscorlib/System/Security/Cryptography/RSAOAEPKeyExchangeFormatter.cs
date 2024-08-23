using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000259 RID: 601
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002F6")]
	public class RSAOAEPKeyExchangeFormatter : AsymmetricKeyExchangeFormatter
	{
		// Token: 0x06001793 RID: 6035 RVA: 0x00018749 File Offset: 0x00016949
		[global::Cpp2ILInjected.Token(Token = "0x60019AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0C448", Offset = "0x1B0C448", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricKeyExchangeFormatter), Member = ".ctor", ReturnType = typeof(void))]
		public RSAOAEPKeyExchangeFormatter()
		{
			throw null;
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x0001874C File Offset: 0x0001694C
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

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x0001874F File Offset: 0x0001694F
		// (set) Token: 0x06001796 RID: 6038 RVA: 0x00018752 File Offset: 0x00016952
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

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x00018755 File Offset: 0x00016955
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

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x00018758 File Offset: 0x00016958
		// (set) Token: 0x06001799 RID: 6041 RVA: 0x0001875B File Offset: 0x0001695B
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

		// Token: 0x0600179A RID: 6042 RVA: 0x0001875E File Offset: 0x0001695E
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

		// Token: 0x0600179B RID: 6043 RVA: 0x00018761 File Offset: 0x00016961
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

		// Token: 0x0600179C RID: 6044 RVA: 0x00018764 File Offset: 0x00016964
		[global::Cpp2ILInjected.Token(Token = "0x60019B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0CA58", Offset = "0x1B0CA58", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override byte[] CreateKeyExchange(byte[] rgbData, global::System.Type symAlgType)
		{
			throw null;
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x00018767 File Offset: 0x00016967
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

		// Token: 0x04000A2F RID: 2607
		[global::Cpp2ILInjected.Token(Token = "0x4000D09")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private byte[] ParameterValue;

		// Token: 0x04000A30 RID: 2608
		[global::Cpp2ILInjected.Token(Token = "0x4000D0A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private RSA _rsaKey;

		// Token: 0x04000A31 RID: 2609
		[global::Cpp2ILInjected.Token(Token = "0x4000D0B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool? _rsaOverridesEncrypt;

		// Token: 0x04000A32 RID: 2610
		[global::Cpp2ILInjected.Token(Token = "0x4000D0C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private RandomNumberGenerator RngValue;
	}
}
