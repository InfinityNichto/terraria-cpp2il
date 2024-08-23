using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Internal.Cryptography.Pal
{
	// Token: 0x0200002A RID: 42
	[global::Cpp2ILInjected.Token(Token = "0x2000072")]
	internal struct CertificateData
	{
		// Token: 0x0600012C RID: 300 RVA: 0x0000315E File Offset: 0x0000135E
		[global::Cpp2ILInjected.Token(Token = "0x60001AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D52080", Offset = "0x1D52080", Length = "0x6C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadSequence", ReturnType = typeof(DerSequenceReader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadInteger", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadIntegerBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadOidAsString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "get_HasData", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadNextEncodedValue", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X500DistinguishedName), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadX509Date", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadBitString", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadBoolean", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadOctetString", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Extension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		internal CertificateData(byte[] rawData)
		{
			throw null;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00003161 File Offset: 0x00001361
		[global::Cpp2ILInjected.Token(Token = "0x60001AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D52744", Offset = "0x1D52744", Length = "0x610")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "GetNameInfo", MemberParameters = new object[]
		{
			typeof(X509NameType),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CertificateData), Member = "GetSimpleNameInfo", MemberParameters = new object[] { typeof(X500DistinguishedName) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(GeneralNameType),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CertificateData), Member = "ReadReverseRdns", MemberParameters = new object[] { typeof(X500DistinguishedName) }, ReturnType = typeof(IEnumerable<KeyValuePair<string, string>>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		public string GetNameInfo(X509NameType nameType, bool forIssuer)
		{
			throw null;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00003164 File Offset: 0x00001364
		[global::Cpp2ILInjected.Token(Token = "0x60001AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D52D54", Offset = "0x1D52D54", Length = "0x434")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = "GetNameInfo", MemberParameters = new object[]
		{
			typeof(X509NameType),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CertificateData), Member = "ReadReverseRdns", MemberParameters = new object[] { typeof(X500DistinguishedName) }, ReturnType = typeof(IEnumerable<KeyValuePair<string, string>>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private static string GetSimpleNameInfo(X500DistinguishedName name)
		{
			throw null;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00003167 File Offset: 0x00001367
		[global::Cpp2ILInjected.Token(Token = "0x60001AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D53188", Offset = "0x1D53188", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = "GetNameInfo", MemberParameters = new object[]
		{
			typeof(X509NameType),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "get_HasData", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "SkipValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadSequence", ReturnType = typeof(DerSequenceReader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadOidAsString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadIA5String", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadUtf8String", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static string FindAltNameMatch(byte[] extensionBytes, GeneralNameType matchType, string otherOid)
		{
			throw null;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000316A File Offset: 0x0000136A
		[global::Cpp2ILInjected.Token(Token = "0x60001AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D53338", Offset = "0x1D53338", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = "GetNameInfo", MemberParameters = new object[]
		{
			typeof(X509NameType),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = "GetSimpleNameInfo", MemberParameters = new object[] { typeof(X500DistinguishedName) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static IEnumerable<KeyValuePair<string, string>> ReadReverseRdns(X500DistinguishedName name)
		{
			throw null;
		}

		// Token: 0x0400007F RID: 127
		[global::Cpp2ILInjected.Token(Token = "0x4000146")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal byte[] RawData;

		// Token: 0x04000080 RID: 128
		[global::Cpp2ILInjected.Token(Token = "0x4000147")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal byte[] SubjectPublicKeyInfo;

		// Token: 0x04000081 RID: 129
		[global::Cpp2ILInjected.Token(Token = "0x4000148")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int Version;

		// Token: 0x04000082 RID: 130
		[global::Cpp2ILInjected.Token(Token = "0x4000149")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal byte[] SerialNumber;

		// Token: 0x04000083 RID: 131
		[global::Cpp2ILInjected.Token(Token = "0x400014A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal CertificateData.AlgorithmIdentifier TbsSignature;

		// Token: 0x04000084 RID: 132
		[global::Cpp2ILInjected.Token(Token = "0x400014B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal X500DistinguishedName Issuer;

		// Token: 0x04000085 RID: 133
		[global::Cpp2ILInjected.Token(Token = "0x400014C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal DateTime NotBefore;

		// Token: 0x04000086 RID: 134
		[global::Cpp2ILInjected.Token(Token = "0x400014D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal DateTime NotAfter;

		// Token: 0x04000087 RID: 135
		[global::Cpp2ILInjected.Token(Token = "0x400014E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal X500DistinguishedName Subject;

		// Token: 0x04000088 RID: 136
		[global::Cpp2ILInjected.Token(Token = "0x400014F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal CertificateData.AlgorithmIdentifier PublicKeyAlgorithm;

		// Token: 0x04000089 RID: 137
		[global::Cpp2ILInjected.Token(Token = "0x4000150")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal byte[] PublicKey;

		// Token: 0x0400008A RID: 138
		[global::Cpp2ILInjected.Token(Token = "0x4000151")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal byte[] IssuerUniqueId;

		// Token: 0x0400008B RID: 139
		[global::Cpp2ILInjected.Token(Token = "0x4000152")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal byte[] SubjectUniqueId;

		// Token: 0x0400008C RID: 140
		[global::Cpp2ILInjected.Token(Token = "0x4000153")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal List<X509Extension> Extensions;

		// Token: 0x0400008D RID: 141
		[global::Cpp2ILInjected.Token(Token = "0x4000154")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		internal CertificateData.AlgorithmIdentifier SignatureAlgorithm;

		// Token: 0x0400008E RID: 142
		[global::Cpp2ILInjected.Token(Token = "0x4000155")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		internal byte[] SignatureValue;

		// Token: 0x020003B0 RID: 944
		[global::Cpp2ILInjected.Token(Token = "0x2000073")]
		internal struct AlgorithmIdentifier
		{
			// Token: 0x04001078 RID: 4216
			[global::Cpp2ILInjected.Token(Token = "0x4000156")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal string AlgorithmId;

			// Token: 0x04001079 RID: 4217
			[global::Cpp2ILInjected.Token(Token = "0x4000157")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal byte[] Parameters;
		}

		// Token: 0x020003B1 RID: 945
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000074")]
		private sealed class <ReadReverseRdns>d__21 : IEnumerable<KeyValuePair<string, string>>, IEnumerable, IEnumerator<KeyValuePair<string, string>>, IDisposable, IEnumerator
		{
			// Token: 0x06001D22 RID: 7458 RVA: 0x0000805A File Offset: 0x0000625A
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60001AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D533A8", Offset = "0x1D533A8", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			public <ReadReverseRdns>d__21(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06001D23 RID: 7459 RVA: 0x0000805D File Offset: 0x0000625D
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60001B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D533DC", Offset = "0x1D533DC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06001D24 RID: 7460 RVA: 0x00008060 File Offset: 0x00006260
			[global::Cpp2ILInjected.Token(Token = "0x60001B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D533E0", Offset = "0x1D533E0", Length = "0x270")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "get_HasData", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadSet", ReturnType = typeof(DerSequenceReader))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>), Member = "Push", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>), Member = "Pop", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadSequence", ReturnType = typeof(DerSequenceReader))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadOidAsString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadBMPString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadPrintableString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadT61String", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadIA5String", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadUtf8String", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x17000723 RID: 1827
			// (get) Token: 0x06001D25 RID: 7461 RVA: 0x00008063 File Offset: 0x00006263
			[global::Cpp2ILInjected.Token(Token = "0x1700005D")]
			private KeyValuePair<string, string> prop_KeyValuePair_2_String_String_0
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60001B2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D53650", Offset = "0x1D53650", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001D26 RID: 7462 RVA: 0x00008066 File Offset: 0x00006266
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60001B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5365C", Offset = "0x1D5365C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x06001D27 RID: 7463 RVA: 0x00008069 File Offset: 0x00006269
			[global::Cpp2ILInjected.Token(Token = "0x1700005E")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60001B4")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D53694", Offset = "0x1D53694", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001D28 RID: 7464 RVA: 0x0000806C File Offset: 0x0000626C
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60001B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D536F0", Offset = "0x1D536F0", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData.<ReadReverseRdns>d__21), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<KeyValuePair<string, string>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0()
			{
				throw null;
			}

			// Token: 0x06001D29 RID: 7465 RVA: 0x0000806F File Offset: 0x0000626F
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60001B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5378C", Offset = "0x1D5378C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CertificateData.<ReadReverseRdns>d__21), Member = "System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator", ReturnType = typeof(IEnumerator<KeyValuePair<string, string>>))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x0400107A RID: 4218
			[global::Cpp2ILInjected.Token(Token = "0x4000158")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400107B RID: 4219
			[global::Cpp2ILInjected.Token(Token = "0x4000159")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private KeyValuePair<string, string> <>2__current;

			// Token: 0x0400107C RID: 4220
			[global::Cpp2ILInjected.Token(Token = "0x400015A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int <>l__initialThreadId;

			// Token: 0x0400107D RID: 4221
			[global::Cpp2ILInjected.Token(Token = "0x400015B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private X500DistinguishedName name;

			// Token: 0x0400107E RID: 4222
			[global::Cpp2ILInjected.Token(Token = "0x400015C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public X500DistinguishedName <>3__name;

			// Token: 0x0400107F RID: 4223
			[global::Cpp2ILInjected.Token(Token = "0x400015D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private Stack<DerSequenceReader> <rdnReaders>5__2;

			// Token: 0x04001080 RID: 4224
			[global::Cpp2ILInjected.Token(Token = "0x400015E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private DerSequenceReader <rdnReader>5__3;
		}
	}
}
