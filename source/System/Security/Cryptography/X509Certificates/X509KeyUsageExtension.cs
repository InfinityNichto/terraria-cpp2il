using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000BD RID: 189
	[global::Cpp2ILInjected.Token(Token = "0x200011B")]
	public sealed class X509KeyUsageExtension : X509Extension
	{
		// Token: 0x06000604 RID: 1540 RVA: 0x00003F5F File Offset: 0x0000215F
		[global::Cpp2ILInjected.Token(Token = "0x60006AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDD694", Offset = "0x1EDD694", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "CreateCustomExtensionIfAny", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(X509Extension))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public X509KeyUsageExtension()
		{
			throw null;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00003F62 File Offset: 0x00002162
		[global::Cpp2ILInjected.Token(Token = "0x60006B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDD730", Offset = "0x1EDD730", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = "KeyUsageExtension", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509KeyUsageExtension), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(AsnDecodeStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public X509KeyUsageExtension(AsnEncodedData encodedKeyUsage, bool critical)
		{
			throw null;
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00003F65 File Offset: 0x00002165
		[global::Cpp2ILInjected.Token(Token = "0x60006B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDD96C", Offset = "0x1EDD96C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509KeyUsageExtension), Member = "Encode", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public X509KeyUsageExtension(X509KeyUsageFlags keyUsages, bool critical)
		{
			throw null;
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00003F68 File Offset: 0x00002168
		[global::Cpp2ILInjected.Token(Token = "0x17000173")]
		public X509KeyUsageFlags KeyUsages
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDDB70", Offset = "0x1EDDB70", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new object[]
			{
				typeof(X509FindType),
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new object[]
			{
				typeof(X509Certificate2),
				typeof(X509Certificate2),
				typeof(bool)
			}, ReturnType = typeof(X509ChainStatusFlags))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00003F6B File Offset: 0x0000216B
		[global::Cpp2ILInjected.Token(Token = "0x60006B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDDBD8", Offset = "0x1EDDBD8", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509KeyUsageExtension), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(AsnDecodeStatus))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			throw null;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00003F6E File Offset: 0x0000216E
		[global::Cpp2ILInjected.Token(Token = "0x60006B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDDA44", Offset = "0x1EDDA44", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags)
		{
			throw null;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00003F71 File Offset: 0x00002171
		[global::Cpp2ILInjected.Token(Token = "0x60006B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDD7F8", Offset = "0x1EDD7F8", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509KeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsnEncodedData),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509KeyUsageExtension), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal AsnDecodeStatus Decode(byte[] extension)
		{
			throw null;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00003F74 File Offset: 0x00002174
		[global::Cpp2ILInjected.Token(Token = "0x60006B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDDA54", Offset = "0x1EDDA54", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509KeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(X509KeyUsageFlags),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal byte[] Encode()
		{
			throw null;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00003F77 File Offset: 0x00002177
		[global::Cpp2ILInjected.Token(Token = "0x60006B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDDDA4", Offset = "0x1EDDDA4", Length = "0x520")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Extension), Member = "FormatUnkownData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal override string ToString(bool multiLine)
		{
			throw null;
		}

		// Token: 0x040003C5 RID: 965
		[global::Cpp2ILInjected.Token(Token = "0x400052F")]
		internal const string oid = "2.5.29.15";

		// Token: 0x040003C6 RID: 966
		[global::Cpp2ILInjected.Token(Token = "0x4000530")]
		internal const string friendlyName = "Key Usage";

		// Token: 0x040003C7 RID: 967
		[global::Cpp2ILInjected.Token(Token = "0x4000531")]
		internal const X509KeyUsageFlags all = X509KeyUsageFlags.EncipherOnly | X509KeyUsageFlags.CrlSign | X509KeyUsageFlags.KeyCertSign | X509KeyUsageFlags.KeyAgreement | X509KeyUsageFlags.DataEncipherment | X509KeyUsageFlags.KeyEncipherment | X509KeyUsageFlags.NonRepudiation | X509KeyUsageFlags.DigitalSignature | X509KeyUsageFlags.DecipherOnly;

		// Token: 0x040003C8 RID: 968
		[global::Cpp2ILInjected.Token(Token = "0x4000532")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private X509KeyUsageFlags _keyUsages;

		// Token: 0x040003C9 RID: 969
		[global::Cpp2ILInjected.Token(Token = "0x4000533")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private AsnDecodeStatus _status;
	}
}
