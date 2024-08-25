using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.X509
{
	[global::Cpp2ILInjected.Token(Token = "0x2000021")]
	public class X520
	{
		[global::Cpp2ILInjected.Token(Token = "0x600017C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A95D44", Offset = "0x1A95D44", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public X520()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000022")]
		public abstract class AttributeTypeAndValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x600017D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A95D4C", Offset = "0x1A95D4C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected AttributeTypeAndValue(string oid, int upperBound)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600017E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A95D84", Offset = "0x1A95D84", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected AttributeTypeAndValue(string oid, int upperBound, byte encoding)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x6000183")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A95E8C", Offset = "0x1A95E8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "FromString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			internal ASN1 GetASN1()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000184")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A96088", Offset = "0x1A96088", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X520.AttributeTypeAndValue), Member = "GetASN1", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public byte[] GetBytes(byte encoding)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000185")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A960A0", Offset = "0x1A960A0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X520.AttributeTypeAndValue), Member = "GetASN1", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public byte[] GetBytes()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40000B9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string oid;

			[global::Cpp2ILInjected.Token(Token = "0x40000BA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string attrValue;

			[global::Cpp2ILInjected.Token(Token = "0x40000BB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int upperBound;

			[global::Cpp2ILInjected.Token(Token = "0x40000BC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private byte encoding;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000023")]
		public class Name : X520.AttributeTypeAndValue
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x2000024")]
		public class CommonName : X520.AttributeTypeAndValue
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x2000025")]
		public class SerialNumber : X520.AttributeTypeAndValue
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x2000026")]
		public class LocalityName : X520.AttributeTypeAndValue
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x2000027")]
		public class StateOrProvinceName : X520.AttributeTypeAndValue
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x2000028")]
		public class OrganizationName : X520.AttributeTypeAndValue
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x2000029")]
		public class OrganizationalUnitName : X520.AttributeTypeAndValue
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x200002A")]
		public class EmailAddress : X520.AttributeTypeAndValue
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x200002B")]
		public class DomainComponent : X520.AttributeTypeAndValue
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x200002C")]
		public class UserId : X520.AttributeTypeAndValue
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x200002D")]
		public class Oid : X520.AttributeTypeAndValue
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x200002E")]
		public class Title : X520.AttributeTypeAndValue
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x200002F")]
		public class CountryName : X520.AttributeTypeAndValue
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x2000030")]
		public class DnQualifier : X520.AttributeTypeAndValue
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x2000031")]
		public class Surname : X520.AttributeTypeAndValue
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x2000032")]
		public class GivenName : X520.AttributeTypeAndValue
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x2000033")]
		public class Initial : X520.AttributeTypeAndValue
		{
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
