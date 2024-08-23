using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Cryptography.Pal;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000B9 RID: 185
	[global::Cpp2ILInjected.Token(Token = "0x2000117")]
	public class X509Extension : AsnEncodedData
	{
		// Token: 0x060005E8 RID: 1512 RVA: 0x00003F0B File Offset: 0x0000210B
		[global::Cpp2ILInjected.Token(Token = "0x6000693")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDBE74", Offset = "0x1EDBE74", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509BasicConstraintsExtension), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509BasicConstraintsExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsnEncodedData),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509BasicConstraintsExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = ".ctor", ReturnType = typeof(void))]
		protected X509Extension()
		{
			throw null;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00003F0E File Offset: 0x0000210E
		[global::Cpp2ILInjected.Token(Token = "0x6000694")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDC930", Offset = "0x1EDC930", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		public X509Extension(string oid, byte[] rawData, bool critical)
		{
			throw null;
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x00003F11 File Offset: 0x00002111
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x00003F14 File Offset: 0x00002114
		[global::Cpp2ILInjected.Token(Token = "0x1700016C")]
		public bool Critical
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000695")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDC958", Offset = "0x1EDC958", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000696")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDC960", Offset = "0x1EDC960", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00003F17 File Offset: 0x00002117
		[global::Cpp2ILInjected.Token(Token = "0x6000697")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDC96C", Offset = "0x1EDC96C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			throw null;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00003F1A File Offset: 0x0000211A
		[global::Cpp2ILInjected.Token(Token = "0x6000698")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDC834", Offset = "0x1EDC834", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509BasicConstraintsExtension), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509KeyUsageExtension), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal string FormatUnkownData(byte[] data)
		{
			throw null;
		}

		// Token: 0x040003C1 RID: 961
		[global::Cpp2ILInjected.Token(Token = "0x400052B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool _critical;
	}
}
