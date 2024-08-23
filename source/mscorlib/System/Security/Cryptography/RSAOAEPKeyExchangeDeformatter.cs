using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000258 RID: 600
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002F5")]
	public class RSAOAEPKeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
	{
		// Token: 0x0600178C RID: 6028 RVA: 0x00018734 File Offset: 0x00016934
		[global::Cpp2ILInjected.Token(Token = "0x60019A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0BE3C", Offset = "0x1B0BE3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricKeyExchangeDeformatter), Member = ".ctor", ReturnType = typeof(void))]
		public RSAOAEPKeyExchangeDeformatter()
		{
			throw null;
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00018737 File Offset: 0x00016937
		[global::Cpp2ILInjected.Token(Token = "0x60019A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0A850", Offset = "0x1B0A850", Length = "0xF4")]
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
		public RSAOAEPKeyExchangeDeformatter(AsymmetricAlgorithm key)
		{
			throw null;
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x0001873A File Offset: 0x0001693A
		// (set) Token: 0x0600178F RID: 6031 RVA: 0x0001873D File Offset: 0x0001693D
		[global::Cpp2ILInjected.Token(Token = "0x170002C2")]
		public override string Parameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0BE44", Offset = "0x1B0BE44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60019A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0BE4C", Offset = "0x1B0BE4C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00018740 File Offset: 0x00016940
		[global::Cpp2ILInjected.Token(Token = "0x60019AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0BE50", Offset = "0x1B0BE50", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAOAEPKeyExchangeDeformatter), Member = "get_OverridesDecrypt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1MaskGenerationMethod), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RsaOaepDecrypt", MemberParameters = new object[]
		{
			typeof(RSA),
			typeof(HashAlgorithm),
			typeof(PKCS1MaskGenerationMethod),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override byte[] DecryptKeyExchange(byte[] rgbData)
		{
			throw null;
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00018743 File Offset: 0x00016943
		[global::Cpp2ILInjected.Token(Token = "0x60019AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0C26C", Offset = "0x1B0C26C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void SetKey(AsymmetricAlgorithm key)
		{
			throw null;
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x00018746 File Offset: 0x00016946
		[global::Cpp2ILInjected.Token(Token = "0x170002C3")]
		private bool OverridesDecrypt
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0BFD4", Offset = "0x1B0BFD4", Length = "0x1D0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAOAEPKeyExchangeDeformatter), Member = "DecryptKeyExchange", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
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

		// Token: 0x04000A2D RID: 2605
		[global::Cpp2ILInjected.Token(Token = "0x4000D07")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RSA _rsaKey;

		// Token: 0x04000A2E RID: 2606
		[global::Cpp2ILInjected.Token(Token = "0x4000D08")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool? _rsaOverridesDecrypt;
	}
}
