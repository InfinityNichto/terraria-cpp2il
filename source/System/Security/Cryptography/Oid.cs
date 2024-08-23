using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000093 RID: 147
	[global::Cpp2ILInjected.Token(Token = "0x20000F0")]
	public sealed class Oid
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x00003BF0 File Offset: 0x00001DF0
		[global::Cpp2ILInjected.Token(Token = "0x6000572")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECEA3C", Offset = "0x1ECEA3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Oid()
		{
			throw null;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00003BF3 File Offset: 0x00001DF3
		[global::Cpp2ILInjected.Token(Token = "0x6000573")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECEA44", Offset = "0x1ECEA44", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "get_PublicKey", ReturnType = typeof(PublicKey))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(AsnDecodeStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidLookup), Member = "ToOid", MemberParameters = new object[]
		{
			typeof(string),
			typeof(OidGroup),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Oid(string oid)
		{
			throw null;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00003BF6 File Offset: 0x00001DF6
		[global::Cpp2ILInjected.Token(Token = "0x6000574")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECEAD0", Offset = "0x1ECEAD0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsnEncodedData),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(OidCollection),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509KeyUsageExtension), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509KeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsnEncodedData),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509KeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(X509KeyUsageFlags),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509KeyUsageExtension), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsnEncodedData),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PublicKey),
			typeof(X509SubjectKeyIdentifierHashAlgorithm),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Oid(string value, string friendlyName)
		{
			throw null;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00003BF9 File Offset: 0x00001DF9
		[global::Cpp2ILInjected.Token(Token = "0x6000575")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECEAFC", Offset = "0x1ECEAFC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = ".ctor", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = "set_Oid", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PublicKey), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Oid),
			typeof(AsnEncodedData),
			typeof(AsnEncodedData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509BasicConstraintsExtension), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509KeyUsageExtension), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Oid(Oid oid)
		{
			throw null;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00003BFC File Offset: 0x00001DFC
		[global::Cpp2ILInjected.Token(Token = "0x6000576")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECEB7C", Offset = "0x1ECEB7C", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "get_SignatureAlgorithm", ReturnType = typeof(Oid))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidLookup), Member = "ToFriendlyName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(OidGroup),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static Oid FromOidValue(string oidValue, OidGroup group)
		{
			throw null;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00003BFF File Offset: 0x00001DFF
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00003C02 File Offset: 0x00001E02
		[global::Cpp2ILInjected.Token(Token = "0x17000108")]
		public string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000577")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECECE4", Offset = "0x1ECECE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000578")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECECEC", Offset = "0x1ECECEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00003C05 File Offset: 0x00001E05
		[global::Cpp2ILInjected.Token(Token = "0x17000109")]
		public string FriendlyName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000579")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECECF4", Offset = "0x1ECECF4", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidLookup), Member = "ToFriendlyName", MemberParameters = new object[]
			{
				typeof(string),
				typeof(OidGroup),
				typeof(bool)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00003C08 File Offset: 0x00001E08
		[global::Cpp2ILInjected.Token(Token = "0x600057A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECECA8", Offset = "0x1ECECA8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private Oid(string value, string friendlyName, OidGroup group)
		{
			throw null;
		}

		// Token: 0x040002F0 RID: 752
		[global::Cpp2ILInjected.Token(Token = "0x4000459")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _value;

		// Token: 0x040002F1 RID: 753
		[global::Cpp2ILInjected.Token(Token = "0x400045A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _friendlyName;

		// Token: 0x040002F2 RID: 754
		[global::Cpp2ILInjected.Token(Token = "0x400045B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private OidGroup _group;
	}
}
