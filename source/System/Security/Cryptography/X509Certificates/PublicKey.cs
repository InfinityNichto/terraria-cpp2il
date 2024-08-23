using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000A5 RID: 165
	[global::Cpp2ILInjected.Token(Token = "0x2000102")]
	public sealed class PublicKey
	{
		// Token: 0x060004F6 RID: 1270 RVA: 0x00003C6B File Offset: 0x00001E6B
		[global::Cpp2ILInjected.Token(Token = "0x600059B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED059C", Offset = "0x1ED059C", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "get_PublicKey", ReturnType = typeof(PublicKey))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = ".ctor", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public PublicKey(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue)
		{
			throw null;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00003C6E File Offset: 0x00001E6E
		[global::Cpp2ILInjected.Token(Token = "0x17000112")]
		public AsnEncodedData EncodedKeyValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x600059C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED06F4", Offset = "0x1ED06F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00003C71 File Offset: 0x00001E71
		[global::Cpp2ILInjected.Token(Token = "0x17000113")]
		public AsnEncodedData EncodedParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x600059D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED06FC", Offset = "0x1ED06FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00003C74 File Offset: 0x00001E74
		[global::Cpp2ILInjected.Token(Token = "0x17000114")]
		public AsymmetricAlgorithm Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x600059E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED0704", Offset = "0x1ED0704", Length = "0x164")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new object[]
			{
				typeof(X509Certificate2),
				typeof(X509Certificate2),
				typeof(bool)
			}, ReturnType = typeof(X509ChainStatusFlags))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACertificateExtensions), Member = "GetRSAPublicKey", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(RSA))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PublicKey), Member = "DecodeDSA", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(byte[])
			}, ReturnType = typeof(DSA))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00003C77 File Offset: 0x00001E77
		[global::Cpp2ILInjected.Token(Token = "0x17000115")]
		public Oid Oid
		{
			[global::Cpp2ILInjected.Token(Token = "0x600059F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED0FF4", Offset = "0x1ED0FF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00003C7A File Offset: 0x00001E7A
		[global::Cpp2ILInjected.Token(Token = "0x60005A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED0FFC", Offset = "0x1ED0FFC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PublicKey), Member = "DecodeDSA", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PublicKey), Member = "DecodeRSA", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static byte[] GetUnsignedBigInteger(byte[] integer)
		{
			throw null;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00003C7D File Offset: 0x00001E7D
		[global::Cpp2ILInjected.Token(Token = "0x60005A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED0BC4", Offset = "0x1ED0BC4", Length = "0x430")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PublicKey), Member = "get_Key", ReturnType = typeof(AsymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PublicKey), Member = "GetUnsignedBigInteger", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSACryptoServiceProvider), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters)
		{
			throw null;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00003C80 File Offset: 0x00001E80
		[global::Cpp2ILInjected.Token(Token = "0x60005A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED0868", Offset = "0x1ED0868", Length = "0x35C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PublicKey), Member = "GetUnsignedBigInteger", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		internal static RSA DecodeRSA(byte[] rawPublicKey)
		{
			throw null;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00003C83 File Offset: 0x00001E83
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60005A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED1080", Offset = "0x1ED1080", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static PublicKey()
		{
			throw null;
		}

		// Token: 0x04000380 RID: 896
		[global::Cpp2ILInjected.Token(Token = "0x40004E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private AsnEncodedData _keyValue;

		// Token: 0x04000381 RID: 897
		[global::Cpp2ILInjected.Token(Token = "0x40004EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private AsnEncodedData _params;

		// Token: 0x04000382 RID: 898
		[global::Cpp2ILInjected.Token(Token = "0x40004EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Oid _oid;

		// Token: 0x04000383 RID: 899
		[global::Cpp2ILInjected.Token(Token = "0x40004EC")]
		private static byte[] Empty;
	}
}
