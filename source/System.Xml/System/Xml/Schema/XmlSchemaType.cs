using System;
using System.Xml.Serialization;
using System.Xml.XPath;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x2000157")]
	public class XmlSchemaType : XmlSchemaAnnotated
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF228", Offset = "0x1DCF228", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(SchemaElementDecl),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(double),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(long),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DatatypeImplementation), Member = "GetSimpleTypeFromTypeCode", MemberParameters = new object[] { typeof(XmlTypeCode) }, ReturnType = typeof(XmlSchemaSimpleType))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode)
		{
			throw null;
		}

		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x1700032F")]
		public XmlQualifiedName QualifiedName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B12")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCF280", Offset = "0x1DCF280", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "FinishBuiltinType", MemberParameters = new object[]
			{
				typeof(XmlSchemaSimpleType),
				typeof(XmlSchemaSimpleType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "GetTypeName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x17000330")]
		public XmlSchemaType BaseXmlSchemaType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B13")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCF298", Offset = "0x1DCF298", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x17000331")]
		public XmlSchemaDatatype Datatype
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B14")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCF2A0", Offset = "0x1DCF2A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x17000332")]
		public virtual bool IsMixed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B15")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCF2A8", Offset = "0x1DCF2A8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x17000333")]
		public XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B16")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCC420", Offset = "0x1DCC420", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(XmlSchemaType),
				typeof(string),
				typeof(IXmlNamespaceResolver)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(XmlSchemaType),
				typeof(object),
				typeof(IXmlNamespaceResolver)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x17000334")]
		internal XmlValueConverter ValueConverter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B17")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCC9DC", Offset = "0x1DCC9DC", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathNavigator), Member = "get_TypedValue", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathNavigator), Member = "get_ValueAsBoolean", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathNavigator), Member = "get_ValueAsDateTime", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathNavigator), Member = "get_ValueAsDouble", ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathNavigator), Member = "get_ValueAsInt", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathNavigator), Member = "get_ValueAsLong", ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathNavigator), Member = "ValueAs", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(IXmlNamespaceResolver)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_List), Member = "CreateValueConverter", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = "get_TypedValue", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = "get_ValueAsBoolean", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = "get_ValueAsDateTime", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = "get_ValueAsDouble", ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = "get_ValueAsInt", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = "get_ValueAsLong", ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = "ValueAs", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(IXmlNamespaceResolver)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = "get_Value", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCD830", Offset = "0x1DCD830", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(XmlSchemaSimpleType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void SetQualifiedName(XmlQualifiedName value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF2AC", Offset = "0x1DCF2AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetBaseSchemaType(XmlSchemaType value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF2B4", Offset = "0x1DCF2B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetDerivedBy(XmlSchemaDerivationMethod value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF2BC", Offset = "0x1DCF2BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetDatatype(XmlSchemaDatatype value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000335")]
		internal SchemaElementDecl ElementDecl
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B1C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCD878", Offset = "0x1DCD878", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new object[]
			{
				typeof(XmlQualifiedName),
				typeof(XmlSchemaDatatype)
			}, ReturnType = typeof(XmlSchemaSimpleType))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCD854", Offset = "0x1DCD854", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new object[]
			{
				typeof(XmlQualifiedName),
				typeof(XmlSchemaDatatype)
			}, ReturnType = typeof(XmlSchemaSimpleType))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF2C4", Offset = "0x1DCF2C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetContentType(XmlSchemaContentType value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCDC90", Offset = "0x1DCDC90", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaSimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public XmlSchemaType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40005BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlSchemaDerivationMethod final;

		[global::Cpp2ILInjected.Token(Token = "0x40005BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private XmlSchemaDerivationMethod derivedBy;

		[global::Cpp2ILInjected.Token(Token = "0x40005BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlSchemaType baseSchemaType;

		[global::Cpp2ILInjected.Token(Token = "0x40005BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XmlSchemaDatatype datatype;

		[global::Cpp2ILInjected.Token(Token = "0x40005BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private SchemaElementDecl elementDecl;

		[global::Cpp2ILInjected.Token(Token = "0x40005C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XmlQualifiedName qname;

		[global::Cpp2ILInjected.Token(Token = "0x40005C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private XmlSchemaContentType contentType;
	}
}
