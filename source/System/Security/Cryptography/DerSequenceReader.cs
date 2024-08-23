using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Cryptography.Pal;

namespace System.Security.Cryptography
{
	// Token: 0x02000092 RID: 146
	[global::Cpp2ILInjected.Token(Token = "0x20000ED")]
	internal class DerSequenceReader
	{
		// Token: 0x17000100 RID: 256
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00003B90 File Offset: 0x00001D90
		[global::Cpp2ILInjected.Token(Token = "0x17000106")]
		private int ContentLength
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600054D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECD450", Offset = "0x1ECD450", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00003B93 File Offset: 0x00001D93
		[global::Cpp2ILInjected.Token(Token = "0x600054E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECD458", Offset = "0x1ECD458", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Internal.Cryptography.Pal.CertificateData.<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(GeneralNameType),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DerSequenceReader.DerTag),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal DerSequenceReader(byte[] data)
		{
			throw null;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00003B96 File Offset: 0x00001D96
		[global::Cpp2ILInjected.Token(Token = "0x600054F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECD46C", Offset = "0x1ECD46C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal DerSequenceReader(byte[] data, int offset, int length)
		{
			throw null;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00003B99 File Offset: 0x00001D99
		[global::Cpp2ILInjected.Token(Token = "0x6000550")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECD480", Offset = "0x1ECD480", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadCollectionWithTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(DerSequenceReader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private DerSequenceReader(DerSequenceReader.DerTag tagToEat, byte[] data, int offset, int length)
		{
			throw null;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00003B9C File Offset: 0x00001D9C
		[global::Cpp2ILInjected.Token(Token = "0x17000107")]
		internal bool HasData
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000551")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECD620", Offset = "0x1ECD620", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Internal.Cryptography.Pal.CertificateData.<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(GeneralNameType),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00003B9F File Offset: 0x00001D9F
		[global::Cpp2ILInjected.Token(Token = "0x6000552")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECD630", Offset = "0x1ECD630", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Internal.Cryptography.Pal.CertificateData.<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(GeneralNameType),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "SkipValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadNextEncodedValue", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadX509Date", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal byte PeekTag()
		{
			throw null;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00003BA2 File Offset: 0x00001DA2
		[global::Cpp2ILInjected.Token(Token = "0x6000553")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECD6AC", Offset = "0x1ECD6AC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(GeneralNameType),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		internal void SkipValue()
		{
			throw null;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00003BA5 File Offset: 0x00001DA5
		[global::Cpp2ILInjected.Token(Token = "0x6000554")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECD6FC", Offset = "0x1ECD6FC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal byte[] ReadNextEncodedValue()
		{
			throw null;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00003BA8 File Offset: 0x00001DA8
		[global::Cpp2ILInjected.Token(Token = "0x6000555")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECD8AC", Offset = "0x1ECD8AC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal bool ReadBoolean()
		{
			throw null;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00003BAB File Offset: 0x00001DAB
		[global::Cpp2ILInjected.Token(Token = "0x6000556")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECD95C", Offset = "0x1ECD95C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadContentAsBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Reverse", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new object[] { typeof(BigInteger) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal int ReadInteger()
		{
			throw null;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00003BAE File Offset: 0x00001DAE
		[global::Cpp2ILInjected.Token(Token = "0x6000557")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECDA10", Offset = "0x1ECDA10", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(void))]
		internal byte[] ReadIntegerBytes()
		{
			throw null;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00003BB1 File Offset: 0x00001DB1
		[global::Cpp2ILInjected.Token(Token = "0x6000558")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECDAE0", Offset = "0x1ECDAE0", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal byte[] ReadBitString()
		{
			throw null;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00003BB4 File Offset: 0x00001DB4
		[global::Cpp2ILInjected.Token(Token = "0x6000559")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECDC0C", Offset = "0x1ECDC0C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadContentAsBytes", ReturnType = typeof(byte[]))]
		internal byte[] ReadOctetString()
		{
			throw null;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00003BB7 File Offset: 0x00001DB7
		[global::Cpp2ILInjected.Token(Token = "0x600055A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECDC28", Offset = "0x1ECDC28", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Internal.Cryptography.Pal.CertificateData.<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(GeneralNameType),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_LeftShift", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(BigInteger)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal string ReadOidAsString()
		{
			throw null;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00003BBA File Offset: 0x00001DBA
		[global::Cpp2ILInjected.Token(Token = "0x600055B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECDEB4", Offset = "0x1ECDEB4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Internal.Cryptography.Pal.CertificateData.<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(GeneralNameType),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		internal string ReadUtf8String()
		{
			throw null;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00003BBD File Offset: 0x00001DBD
		[global::Cpp2ILInjected.Token(Token = "0x600055C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECDFA4", Offset = "0x1ECDFA4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadSequence", ReturnType = typeof(DerSequenceReader))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadSet", ReturnType = typeof(DerSequenceReader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "CheckTag", MemberParameters = new object[]
		{
			typeof(DerSequenceReader.DerTag),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DerSequenceReader.DerTag),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private DerSequenceReader ReadCollectionWithTag(DerSequenceReader.DerTag expected)
		{
			throw null;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00003BC0 File Offset: 0x00001DC0
		[global::Cpp2ILInjected.Token(Token = "0x600055D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECE0EC", Offset = "0x1ECE0EC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Internal.Cryptography.Pal.CertificateData.<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(GeneralNameType),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadCollectionWithTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(DerSequenceReader))]
		internal DerSequenceReader ReadSequence()
		{
			throw null;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00003BC3 File Offset: 0x00001DC3
		[global::Cpp2ILInjected.Token(Token = "0x600055E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECE0F4", Offset = "0x1ECE0F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Internal.Cryptography.Pal.CertificateData.<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadCollectionWithTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(DerSequenceReader))]
		internal DerSequenceReader ReadSet()
		{
			throw null;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00003BC6 File Offset: 0x00001DC6
		[global::Cpp2ILInjected.Token(Token = "0x600055F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECE0FC", Offset = "0x1ECE0FC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Internal.Cryptography.Pal.CertificateData.<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "TrimTrailingNulls", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		internal string ReadPrintableString()
		{
			throw null;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00003BC9 File Offset: 0x00001DC9
		[global::Cpp2ILInjected.Token(Token = "0x6000560")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECE174", Offset = "0x1ECE174", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Internal.Cryptography.Pal.CertificateData.<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(GeneralNameType),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "TrimTrailingNulls", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		internal string ReadIA5String()
		{
			throw null;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00003BCC File Offset: 0x00001DCC
		[global::Cpp2ILInjected.Token(Token = "0x6000561")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECE1EC", Offset = "0x1ECE1EC", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Internal.Cryptography.Pal.CertificateData.<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "System.Func`1<T>" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "TrimTrailingNulls", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal string ReadT61String()
		{
			throw null;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00003BCF File Offset: 0x00001DCF
		[global::Cpp2ILInjected.Token(Token = "0x6000562")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECE4B0", Offset = "0x1ECE4B0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadGeneralizedTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal DateTime ReadX509Date()
		{
			throw null;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00003BD2 File Offset: 0x00001DD2
		[global::Cpp2ILInjected.Token(Token = "0x6000563")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECE530", Offset = "0x1ECE530", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ReadTime", MemberParameters = new object[]
		{
			typeof(DerSequenceReader.DerTag),
			typeof(string)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal DateTime ReadUtcTime()
		{
			throw null;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00003BD5 File Offset: 0x00001DD5
		[global::Cpp2ILInjected.Token(Token = "0x6000564")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECE57C", Offset = "0x1ECE57C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadX509Date", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal DateTime ReadGeneralizedTime()
		{
			throw null;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00003BD8 File Offset: 0x00001DD8
		[global::Cpp2ILInjected.Token(Token = "0x6000565")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECE804", Offset = "0x1ECE804", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Internal.Cryptography.Pal.CertificateData.<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "TrimTrailingNulls", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		internal string ReadBMPString()
		{
			throw null;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00003BDB File Offset: 0x00001DDB
		[global::Cpp2ILInjected.Token(Token = "0x6000566")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECDF2C", Offset = "0x1ECDF2C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadPrintableString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadIA5String", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadT61String", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBMPString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		private static string TrimTrailingNulls(string value)
		{
			throw null;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00003BDE File Offset: 0x00001DDE
		[global::Cpp2ILInjected.Token(Token = "0x6000567")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECE5C8", Offset = "0x1ECE5C8", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadUtcTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "System.Func`1<T>" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(IFormatProvider),
			typeof(DateTimeStyles),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private DateTime ReadTime(DerSequenceReader.DerTag timeTag, string formatString)
		{
			throw null;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00003BE1 File Offset: 0x00001DE1
		[global::Cpp2ILInjected.Token(Token = "0x6000568")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECDA2C", Offset = "0x1ECDA2C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadInteger", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadOctetString", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte[] ReadContentAsBytes()
		{
			throw null;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[global::Cpp2ILInjected.Token(Token = "0x6000569")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECD568", Offset = "0x1ECD568", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DerSequenceReader.DerTag),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "SkipValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBoolean", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadInteger", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadIntegerBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBitString", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadOctetString", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadOidAsString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadUtf8String", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadPrintableString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadIA5String", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadT61String", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBMPString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadTime", MemberParameters = new object[]
		{
			typeof(DerSequenceReader.DerTag),
			typeof(string)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "CheckTag", MemberParameters = new object[]
		{
			typeof(DerSequenceReader.DerTag),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void EatTag(DerSequenceReader.DerTag expected)
		{
			throw null;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00003BE7 File Offset: 0x00001DE7
		[global::Cpp2ILInjected.Token(Token = "0x600056A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECE068", Offset = "0x1ECE068", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadCollectionWithTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(DerSequenceReader))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void CheckTag(DerSequenceReader.DerTag expected, byte[] data, int position)
		{
			throw null;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00003BEA File Offset: 0x00001DEA
		[global::Cpp2ILInjected.Token(Token = "0x600056B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECD5E4", Offset = "0x1ECD5E4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		private int EatLength()
		{
			throw null;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00003BED File Offset: 0x00001DED
		[global::Cpp2ILInjected.Token(Token = "0x600056C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECD7B4", Offset = "0x1ECD7B4", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DerSequenceReader.DerTag),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "SkipValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadNextEncodedValue", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBoolean", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBitString", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadOidAsString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadUtf8String", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadCollectionWithTag", MemberParameters = new object[] { typeof(DerSequenceReader.DerTag) }, ReturnType = typeof(DerSequenceReader))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadPrintableString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadIA5String", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadT61String", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBMPString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadTime", MemberParameters = new object[]
		{
			typeof(DerSequenceReader.DerTag),
			typeof(string)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "ReadContentAsBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DerSequenceReader), Member = "EatLength", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static int ScanContentLength(byte[] data, int offset, int end, out int bytesConsumed)
		{
			throw null;
		}

		// Token: 0x040002E9 RID: 745
		[global::Cpp2ILInjected.Token(Token = "0x400043E")]
		internal static DateTimeFormatInfo s_validityDateTimeFormatInfo;

		// Token: 0x040002EA RID: 746
		[global::Cpp2ILInjected.Token(Token = "0x400043F")]
		private static Encoding s_utf8EncodingWithExceptionFallback;

		// Token: 0x040002EB RID: 747
		[global::Cpp2ILInjected.Token(Token = "0x4000440")]
		private static Encoding s_latin1Encoding;

		// Token: 0x040002EC RID: 748
		[global::Cpp2ILInjected.Token(Token = "0x4000441")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly byte[] _data;

		// Token: 0x040002ED RID: 749
		[global::Cpp2ILInjected.Token(Token = "0x4000442")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly int _end;

		// Token: 0x040002EE RID: 750
		[global::Cpp2ILInjected.Token(Token = "0x4000443")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _position;

		// Token: 0x040002EF RID: 751
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000444")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int <ContentLength>k__BackingField;

		// Token: 0x020003C3 RID: 963
		[global::Cpp2ILInjected.Token(Token = "0x20000EE")]
		internal enum DerTag : byte
		{
			// Token: 0x04001107 RID: 4359
			[global::Cpp2ILInjected.Token(Token = "0x4000446")]
			Boolean = 1,
			// Token: 0x04001108 RID: 4360
			[global::Cpp2ILInjected.Token(Token = "0x4000447")]
			Integer,
			// Token: 0x04001109 RID: 4361
			[global::Cpp2ILInjected.Token(Token = "0x4000448")]
			BitString,
			// Token: 0x0400110A RID: 4362
			[global::Cpp2ILInjected.Token(Token = "0x4000449")]
			OctetString,
			// Token: 0x0400110B RID: 4363
			[global::Cpp2ILInjected.Token(Token = "0x400044A")]
			Null,
			// Token: 0x0400110C RID: 4364
			[global::Cpp2ILInjected.Token(Token = "0x400044B")]
			ObjectIdentifier,
			// Token: 0x0400110D RID: 4365
			[global::Cpp2ILInjected.Token(Token = "0x400044C")]
			UTF8String = 12,
			// Token: 0x0400110E RID: 4366
			[global::Cpp2ILInjected.Token(Token = "0x400044D")]
			Sequence = 16,
			// Token: 0x0400110F RID: 4367
			[global::Cpp2ILInjected.Token(Token = "0x400044E")]
			Set,
			// Token: 0x04001110 RID: 4368
			[global::Cpp2ILInjected.Token(Token = "0x400044F")]
			PrintableString = 19,
			// Token: 0x04001111 RID: 4369
			[global::Cpp2ILInjected.Token(Token = "0x4000450")]
			T61String,
			// Token: 0x04001112 RID: 4370
			[global::Cpp2ILInjected.Token(Token = "0x4000451")]
			IA5String = 22,
			// Token: 0x04001113 RID: 4371
			[global::Cpp2ILInjected.Token(Token = "0x4000452")]
			UTCTime,
			// Token: 0x04001114 RID: 4372
			[global::Cpp2ILInjected.Token(Token = "0x4000453")]
			GeneralizedTime,
			// Token: 0x04001115 RID: 4373
			[global::Cpp2ILInjected.Token(Token = "0x4000454")]
			BMPString = 30
		}

		// Token: 0x020003C4 RID: 964
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000EF")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001D44 RID: 7492 RVA: 0x000080C0 File Offset: 0x000062C0
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600056D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECE87C", Offset = "0x1ECE87C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06001D45 RID: 7493 RVA: 0x000080C3 File Offset: 0x000062C3
			[global::Cpp2ILInjected.Token(Token = "0x600056E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECE8D8", Offset = "0x1ECE8D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06001D46 RID: 7494 RVA: 0x000080C6 File Offset: 0x000062C6
			[global::Cpp2ILInjected.Token(Token = "0x600056F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECE8E0", Offset = "0x1ECE8E0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal Encoding <ReadT61String>b__45_0()
			{
				throw null;
			}

			// Token: 0x06001D47 RID: 7495 RVA: 0x000080C9 File Offset: 0x000062C9
			[global::Cpp2ILInjected.Token(Token = "0x6000570")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECE93C", Offset = "0x1ECE93C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal Encoding <ReadT61String>b__45_1()
			{
				throw null;
			}

			// Token: 0x06001D48 RID: 7496 RVA: 0x000080CC File Offset: 0x000062CC
			[global::Cpp2ILInjected.Token(Token = "0x6000571")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECE980", Offset = "0x1ECE980", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal DateTimeFormatInfo <ReadTime>b__51_0()
			{
				throw null;
			}

			// Token: 0x04001116 RID: 4374
			[global::Cpp2ILInjected.Token(Token = "0x4000455")]
			public static readonly DerSequenceReader.<>c <>9;

			// Token: 0x04001117 RID: 4375
			[global::Cpp2ILInjected.Token(Token = "0x4000456")]
			public static Func<Encoding> <>9__45_0;

			// Token: 0x04001118 RID: 4376
			[global::Cpp2ILInjected.Token(Token = "0x4000457")]
			public static Func<Encoding> <>9__45_1;

			// Token: 0x04001119 RID: 4377
			[global::Cpp2ILInjected.Token(Token = "0x4000458")]
			public static Func<DateTimeFormatInfo> <>9__51_0;
		}
	}
}
