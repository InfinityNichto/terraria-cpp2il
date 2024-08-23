using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200025A RID: 602
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002F7")]
	public class RSAPKCS1KeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
	{
		// Token: 0x0600179E RID: 6046 RVA: 0x0001876A File Offset: 0x0001696A
		[global::Cpp2ILInjected.Token(Token = "0x60019B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0CA64", Offset = "0x1B0CA64", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricKeyExchangeDeformatter), Member = ".ctor", ReturnType = typeof(void))]
		public RSAPKCS1KeyExchangeDeformatter()
		{
			throw null;
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0001876D File Offset: 0x0001696D
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

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x00018770 File Offset: 0x00016970
		// (set) Token: 0x060017A1 RID: 6049 RVA: 0x00018773 File Offset: 0x00016973
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

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x00018776 File Offset: 0x00016976
		// (set) Token: 0x060017A3 RID: 6051 RVA: 0x00018779 File Offset: 0x00016979
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

		// Token: 0x060017A4 RID: 6052 RVA: 0x0001877C File Offset: 0x0001697C
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

		// Token: 0x060017A5 RID: 6053 RVA: 0x0001877F File Offset: 0x0001697F
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

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x00018782 File Offset: 0x00016982
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

		// Token: 0x04000A33 RID: 2611
		[global::Cpp2ILInjected.Token(Token = "0x4000D0D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RSA _rsaKey;

		// Token: 0x04000A34 RID: 2612
		[global::Cpp2ILInjected.Token(Token = "0x4000D0E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool? _rsaOverridesDecrypt;

		// Token: 0x04000A35 RID: 2613
		[global::Cpp2ILInjected.Token(Token = "0x4000D0F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private RandomNumberGenerator RngValue;
	}
}
