using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.X509
{
	// Token: 0x02000018 RID: 24
	[global::Cpp2ILInjected.Token(Token = "0x2000021")]
	public class X520
	{
		// Token: 0x06000141 RID: 321 RVA: 0x00003303 File Offset: 0x00001503
		[global::Cpp2ILInjected.Token(Token = "0x600017C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A95D44", Offset = "0x1A95D44", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public X520()
		{
			throw null;
		}

		// Token: 0x0200005F RID: 95
		[global::Cpp2ILInjected.Token(Token = "0x2000022")]
		public abstract class AttributeTypeAndValue
		{
			// Token: 0x060002BE RID: 702 RVA: 0x0000374D File Offset: 0x0000194D
			[global::Cpp2ILInjected.Token(Token = "0x600017D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A95D4C", Offset = "0x1A95D4C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected AttributeTypeAndValue(string oid, int upperBound)
			{
				throw null;
			}

			// Token: 0x060002BF RID: 703 RVA: 0x00003750 File Offset: 0x00001950
			[global::Cpp2ILInjected.Token(Token = "0x600017E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A95D84", Offset = "0x1A95D84", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected AttributeTypeAndValue(string oid, int upperBound, byte encoding)
			{
				throw null;
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x060002C0 RID: 704 RVA: 0x00003753 File Offset: 0x00001953
			// (set) Token: 0x060002C1 RID: 705 RVA: 0x00003756 File Offset: 0x00001956
			[global::Cpp2ILInjected.Token(Token = "0x17000076")]
			public string Value
			{
				[global::Cpp2ILInjected.Token(Token = "0x600017F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A95DC4", Offset = "0x1A95DC4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000180")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A95DCC", Offset = "0x1A95DCC", Length = "0xB8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "FromString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object)
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x060002C2 RID: 706 RVA: 0x00003759 File Offset: 0x00001959
			[global::Cpp2ILInjected.Token(Token = "0x17000077")]
			public ASN1 ASN1
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000181")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A95E84", Offset = "0x1A95E84", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X520.AttributeTypeAndValue), Member = "GetASN1", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(ASN1))]
				get
				{
					throw null;
				}
			}

			// Token: 0x060002C3 RID: 707 RVA: 0x0000375C File Offset: 0x0000195C
			[global::Cpp2ILInjected.Token(Token = "0x6000182")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A95E94", Offset = "0x1A95E94", Length = "0x178")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X520.AttributeTypeAndValue), Member = "get_ASN1", ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X520.AttributeTypeAndValue), Member = "GetBytes", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X520.AttributeTypeAndValue), Member = "GetBytes", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X520.AttributeTypeAndValue), Member = "SelectBestEncoding", ReturnType = typeof(byte))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal ASN1 GetASN1(byte encoding)
			{
				throw null;
			}

			// Token: 0x060002C4 RID: 708 RVA: 0x0000375F File Offset: 0x0000195F
			[global::Cpp2ILInjected.Token(Token = "0x6000183")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A95E8C", Offset = "0x1A95E8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "FromString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			internal ASN1 GetASN1()
			{
				throw null;
			}

			// Token: 0x060002C5 RID: 709 RVA: 0x00003762 File Offset: 0x00001962
			[global::Cpp2ILInjected.Token(Token = "0x6000184")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A96088", Offset = "0x1A96088", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X520.AttributeTypeAndValue), Member = "GetASN1", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public byte[] GetBytes(byte encoding)
			{
				throw null;
			}

			// Token: 0x060002C6 RID: 710 RVA: 0x00003765 File Offset: 0x00001965
			[global::Cpp2ILInjected.Token(Token = "0x6000185")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A960A0", Offset = "0x1A960A0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X520.AttributeTypeAndValue), Member = "GetASN1", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public byte[] GetBytes()
			{
				throw null;
			}

			// Token: 0x060002C7 RID: 711 RVA: 0x00003768 File Offset: 0x00001968
			[global::Cpp2ILInjected.Token(Token = "0x6000186")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9600C", Offset = "0x1A9600C", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X520.AttributeTypeAndValue), Member = "GetASN1", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			private byte SelectBestEncoding()
			{
				throw null;
			}

			// Token: 0x040002BE RID: 702
			[global::Cpp2ILInjected.Token(Token = "0x40000B9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string oid;

			// Token: 0x040002BF RID: 703
			[global::Cpp2ILInjected.Token(Token = "0x40000BA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string attrValue;

			// Token: 0x040002C0 RID: 704
			[global::Cpp2ILInjected.Token(Token = "0x40000BB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int upperBound;

			// Token: 0x040002C1 RID: 705
			[global::Cpp2ILInjected.Token(Token = "0x40000BC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private byte encoding;
		}

		// Token: 0x02000060 RID: 96
		[global::Cpp2ILInjected.Token(Token = "0x2000023")]
		public class Name : X520.AttributeTypeAndValue
		{
			// Token: 0x060002C8 RID: 712 RVA: 0x0000376B File Offset: 0x0000196B
			[global::Cpp2ILInjected.Token(Token = "0x6000187")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A960BC", Offset = "0x1A960BC", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public Name()
			{
				throw null;
			}
		}

		// Token: 0x02000061 RID: 97
		[global::Cpp2ILInjected.Token(Token = "0x2000024")]
		public class CommonName : X520.AttributeTypeAndValue
		{
			// Token: 0x060002C9 RID: 713 RVA: 0x0000376E File Offset: 0x0000196E
			[global::Cpp2ILInjected.Token(Token = "0x6000188")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A96120", Offset = "0x1A96120", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public CommonName()
			{
				throw null;
			}
		}

		// Token: 0x02000062 RID: 98
		[global::Cpp2ILInjected.Token(Token = "0x2000025")]
		public class SerialNumber : X520.AttributeTypeAndValue
		{
			// Token: 0x060002CA RID: 714 RVA: 0x00003771 File Offset: 0x00001971
			[global::Cpp2ILInjected.Token(Token = "0x6000189")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A96184", Offset = "0x1A96184", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public SerialNumber()
			{
				throw null;
			}
		}

		// Token: 0x02000063 RID: 99
		[global::Cpp2ILInjected.Token(Token = "0x2000026")]
		public class LocalityName : X520.AttributeTypeAndValue
		{
			// Token: 0x060002CB RID: 715 RVA: 0x00003774 File Offset: 0x00001974
			[global::Cpp2ILInjected.Token(Token = "0x600018A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A961E8", Offset = "0x1A961E8", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public LocalityName()
			{
				throw null;
			}
		}

		// Token: 0x02000064 RID: 100
		[global::Cpp2ILInjected.Token(Token = "0x2000027")]
		public class StateOrProvinceName : X520.AttributeTypeAndValue
		{
			// Token: 0x060002CC RID: 716 RVA: 0x00003777 File Offset: 0x00001977
			[global::Cpp2ILInjected.Token(Token = "0x600018B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9624C", Offset = "0x1A9624C", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public StateOrProvinceName()
			{
				throw null;
			}
		}

		// Token: 0x02000065 RID: 101
		[global::Cpp2ILInjected.Token(Token = "0x2000028")]
		public class OrganizationName : X520.AttributeTypeAndValue
		{
			// Token: 0x060002CD RID: 717 RVA: 0x0000377A File Offset: 0x0000197A
			[global::Cpp2ILInjected.Token(Token = "0x600018C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A962B0", Offset = "0x1A962B0", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public OrganizationName()
			{
				throw null;
			}
		}

		// Token: 0x02000066 RID: 102
		[global::Cpp2ILInjected.Token(Token = "0x2000029")]
		public class OrganizationalUnitName : X520.AttributeTypeAndValue
		{
			// Token: 0x060002CE RID: 718 RVA: 0x0000377D File Offset: 0x0000197D
			[global::Cpp2ILInjected.Token(Token = "0x600018D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A96314", Offset = "0x1A96314", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public OrganizationalUnitName()
			{
				throw null;
			}
		}

		// Token: 0x02000067 RID: 103
		[global::Cpp2ILInjected.Token(Token = "0x200002A")]
		public class EmailAddress : X520.AttributeTypeAndValue
		{
			// Token: 0x060002CF RID: 719 RVA: 0x00003780 File Offset: 0x00001980
			[global::Cpp2ILInjected.Token(Token = "0x600018E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A96378", Offset = "0x1A96378", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public EmailAddress()
			{
				throw null;
			}
		}

		// Token: 0x02000068 RID: 104
		[global::Cpp2ILInjected.Token(Token = "0x200002B")]
		public class DomainComponent : X520.AttributeTypeAndValue
		{
			// Token: 0x060002D0 RID: 720 RVA: 0x00003783 File Offset: 0x00001983
			[global::Cpp2ILInjected.Token(Token = "0x600018F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A963DC", Offset = "0x1A963DC", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public DomainComponent()
			{
				throw null;
			}
		}

		// Token: 0x02000069 RID: 105
		[global::Cpp2ILInjected.Token(Token = "0x200002C")]
		public class UserId : X520.AttributeTypeAndValue
		{
			// Token: 0x060002D1 RID: 721 RVA: 0x00003786 File Offset: 0x00001986
			[global::Cpp2ILInjected.Token(Token = "0x6000190")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A96440", Offset = "0x1A96440", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public UserId()
			{
				throw null;
			}
		}

		// Token: 0x0200006A RID: 106
		[global::Cpp2ILInjected.Token(Token = "0x200002D")]
		public class Oid : X520.AttributeTypeAndValue
		{
			// Token: 0x060002D2 RID: 722 RVA: 0x00003789 File Offset: 0x00001989
			[global::Cpp2ILInjected.Token(Token = "0x6000191")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A964A4", Offset = "0x1A964A4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Oid(string oid)
			{
				throw null;
			}
		}

		// Token: 0x0200006B RID: 107
		[global::Cpp2ILInjected.Token(Token = "0x200002E")]
		public class Title : X520.AttributeTypeAndValue
		{
			// Token: 0x060002D3 RID: 723 RVA: 0x0000378C File Offset: 0x0000198C
			[global::Cpp2ILInjected.Token(Token = "0x6000192")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A964DC", Offset = "0x1A964DC", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public Title()
			{
				throw null;
			}
		}

		// Token: 0x0200006C RID: 108
		[global::Cpp2ILInjected.Token(Token = "0x200002F")]
		public class CountryName : X520.AttributeTypeAndValue
		{
			// Token: 0x060002D4 RID: 724 RVA: 0x0000378F File Offset: 0x0000198F
			[global::Cpp2ILInjected.Token(Token = "0x6000193")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A96540", Offset = "0x1A96540", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public CountryName()
			{
				throw null;
			}
		}

		// Token: 0x0200006D RID: 109
		[global::Cpp2ILInjected.Token(Token = "0x2000030")]
		public class DnQualifier : X520.AttributeTypeAndValue
		{
			// Token: 0x060002D5 RID: 725 RVA: 0x00003792 File Offset: 0x00001992
			[global::Cpp2ILInjected.Token(Token = "0x6000194")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A965A4", Offset = "0x1A965A4", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public DnQualifier()
			{
				throw null;
			}
		}

		// Token: 0x0200006E RID: 110
		[global::Cpp2ILInjected.Token(Token = "0x2000031")]
		public class Surname : X520.AttributeTypeAndValue
		{
			// Token: 0x060002D6 RID: 726 RVA: 0x00003795 File Offset: 0x00001995
			[global::Cpp2ILInjected.Token(Token = "0x6000195")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A96608", Offset = "0x1A96608", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public Surname()
			{
				throw null;
			}
		}

		// Token: 0x0200006F RID: 111
		[global::Cpp2ILInjected.Token(Token = "0x2000032")]
		public class GivenName : X520.AttributeTypeAndValue
		{
			// Token: 0x060002D7 RID: 727 RVA: 0x00003798 File Offset: 0x00001998
			[global::Cpp2ILInjected.Token(Token = "0x6000196")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9666C", Offset = "0x1A9666C", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public GivenName()
			{
				throw null;
			}
		}

		// Token: 0x02000070 RID: 112
		[global::Cpp2ILInjected.Token(Token = "0x2000033")]
		public class Initial : X520.AttributeTypeAndValue
		{
			// Token: 0x060002D8 RID: 728 RVA: 0x0000379B File Offset: 0x0000199B
			[global::Cpp2ILInjected.Token(Token = "0x6000197")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A966D0", Offset = "0x1A966D0", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public Initial()
			{
				throw null;
			}
		}
	}
}
