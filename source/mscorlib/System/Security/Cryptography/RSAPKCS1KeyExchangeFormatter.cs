using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200025B RID: 603
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002F8")]
	public class RSAPKCS1KeyExchangeFormatter : AsymmetricKeyExchangeFormatter
	{
		// Token: 0x060017A7 RID: 6055 RVA: 0x00018785 File Offset: 0x00016985
		[global::Cpp2ILInjected.Token(Token = "0x60019C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0CF04", Offset = "0x1B0CF04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricKeyExchangeFormatter), Member = ".ctor", ReturnType = typeof(void))]
		public RSAPKCS1KeyExchangeFormatter()
		{
			throw null;
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00018788 File Offset: 0x00016988
		[global::Cpp2ILInjected.Token(Token = "0x60019C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0ABB4", Offset = "0x1B0ABB4", Length = "0xF4")]
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
		public RSAPKCS1KeyExchangeFormatter(AsymmetricAlgorithm key)
		{
			throw null;
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x0001878B File Offset: 0x0001698B
		[global::Cpp2ILInjected.Token(Token = "0x170002CB")]
		public override string Parameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0CF0C", Offset = "0x1B0CF0C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x0001878E File Offset: 0x0001698E
		// (set) Token: 0x060017AB RID: 6059 RVA: 0x00018791 File Offset: 0x00016991
		[global::Cpp2ILInjected.Token(Token = "0x170002CC")]
		public RandomNumberGenerator Rng
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0CF4C", Offset = "0x1B0CF4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60019C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0CF54", Offset = "0x1B0CF54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00018794 File Offset: 0x00016994
		[global::Cpp2ILInjected.Token(Token = "0x60019C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0CF5C", Offset = "0x1B0CF5C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void SetKey(AsymmetricAlgorithm key)
		{
			throw null;
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x00018797 File Offset: 0x00016997
		[global::Cpp2ILInjected.Token(Token = "0x60019C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D048", Offset = "0x1B0D048", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAPKCS1KeyExchangeFormatter), Member = "get_OverridesEncrypt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public override byte[] CreateKeyExchange(byte[] rgbData)
		{
			throw null;
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x0001879A File Offset: 0x0001699A
		[global::Cpp2ILInjected.Token(Token = "0x60019C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D4DC", Offset = "0x1B0D4DC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override byte[] CreateKeyExchange(byte[] rgbData, global::System.Type symAlgType)
		{
			throw null;
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060017AF RID: 6063 RVA: 0x0001879D File Offset: 0x0001699D
		[global::Cpp2ILInjected.Token(Token = "0x170002CD")]
		private bool OverridesEncrypt
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0D30C", Offset = "0x1B0D30C", Length = "0x1D0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1KeyExchangeFormatter), Member = "CreateKeyExchange", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
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

		// Token: 0x04000A36 RID: 2614
		[global::Cpp2ILInjected.Token(Token = "0x4000D10")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RandomNumberGenerator RngValue;

		// Token: 0x04000A37 RID: 2615
		[global::Cpp2ILInjected.Token(Token = "0x4000D11")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private RSA _rsaKey;

		// Token: 0x04000A38 RID: 2616
		[global::Cpp2ILInjected.Token(Token = "0x4000D12")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool? _rsaOverridesEncrypt;
	}
}
