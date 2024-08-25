using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x20000DD")]
	internal abstract class DatatypeImplementation : XmlSchemaDatatype
	{
		[global::Cpp2ILInjected.Token(Token = "0x600086F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB8220", Offset = "0x1DB8220", Length = "0x323C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringFacetsChecker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscFacetsChecker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Numeric2FacetsChecker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryFacetsChecker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFacetsChecker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DurationFacetsChecker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListFacetsChecker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QNameFacetsChecker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnionFacetsChecker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anyURI), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_base64Binary), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_boolean), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_byte), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_char), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_date), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_dateTime), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_dateTimeNoTimeZone), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_dateTimeTimeZone), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_day), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_decimal), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_double), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_doubleXdr), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_duration), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_ENTITY), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DatatypeImplementation), Member = "DeriveByList", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlSchemaType)
		}, ReturnType = typeof(XmlSchemaDatatype))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_ENUMERATION), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_fixed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_float), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_floatXdr), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_hexBinary), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_ID), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_IDREF), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_int), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_integer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_language), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_long), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_month), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_monthDay), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_Name), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_NCName), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_negativeInteger), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_NMTOKEN), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_nonNegativeInteger), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_nonPositiveInteger), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_normalizedString), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_NOTATION), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_positiveInteger), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_QName), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_QNameXdr), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_short), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_time), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_timeNoTimeZone), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_timeTimeZone), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_token), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_unsignedByte), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_unsignedInt), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_unsignedLong), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_unsignedShort), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_uuid), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_year), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_yearMonth), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_normalizedStringV1Compat), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_tokenV1Compat), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anyAtomicType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_dayTimeDuration), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_untypedAtomicType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_yearMonthDuration), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DatatypeImplementation), Member = "CreateBuiltinTypes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 422)]
		static DatatypeImplementation()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700020A")]
		internal static XmlSchemaSimpleType AnySimpleType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000870")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBBCE0", Offset = "0x1DBBCE0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700020B")]
		internal static XmlSchemaSimpleType UntypedAtomicType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000871")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBBD38", Offset = "0x1DBBD38", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000872")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBBD90", Offset = "0x1DBBD90", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaDatatype), Member = "FromXmlTokenizedType", MemberParameters = new object[] { typeof(XmlTokenizedType) }, ReturnType = typeof(XmlSchemaDatatype))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal new static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000873")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBBDF4", Offset = "0x1DBBDF4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "CreateBuiltinTypes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "BinarySearch", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(object),
			typeof(IComparer)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static DatatypeImplementation FromTypeName(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000874")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBBE98", Offset = "0x1DBBE98", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "CreateBuiltinTypes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaSimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "SetQualifiedName", MemberParameters = new object[] { typeof(XmlQualifiedName) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaDatatype) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "set_ElementDecl", MemberParameters = new object[] { typeof(SchemaElementDecl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ElementDecl", ReturnType = typeof(SchemaElementDecl))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000875")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBBF5C", Offset = "0x1DBBF5C", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "CreateBuiltinTypes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaSimpleTypeRestriction), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_QualifiedName", ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaSimpleTypeRestriction), Member = "set_BaseTypeName", MemberParameters = new object[] { typeof(XmlQualifiedName) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaSimpleTypeList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000876")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBB640", Offset = "0x1DBB640", Length = "0x6A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DatatypeImplementation), Member = "FromTypeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DatatypeImplementation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(XmlSchemaSimpleType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DatatypeImplementation), Member = "FinishBuiltinType", MemberParameters = new object[]
		{
			typeof(XmlSchemaSimpleType),
			typeof(XmlSchemaSimpleType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		internal static void CreateBuiltinTypes()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000877")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBC0EC", Offset = "0x1DBC0EC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_List), Member = "CreateValueConverter", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaType), Member = "GetBuiltInSimpleType", MemberParameters = new object[] { typeof(XmlTypeCode) }, ReturnType = typeof(XmlSchemaSimpleType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000878")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBB45C", Offset = "0x1DBB45C", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_List), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DatatypeImplementation),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_union), Member = "HasAtomicMembers", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000879")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBC1C4", Offset = "0x1DBC1C4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override bool IsEqual(object o1, object o2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600087A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBC1E4", Offset = "0x1DBC1E4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700020C")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x600087B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBC1EC", Offset = "0x1DBC1EC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700020D")]
		internal override XmlValueConverter ValueConverter
		{
			[global::Cpp2ILInjected.Token(Token = "0x600087C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBC244", Offset = "0x1DBC244", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700020E")]
		public override XmlTokenizedType TokenizedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600087D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBC278", Offset = "0x1DBC278", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700020F")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600087E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBC280", Offset = "0x1DBC280", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000210")]
		public override XmlSchemaDatatypeVariety Variety
		{
			[global::Cpp2ILInjected.Token(Token = "0x600087F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBC2EC", Offset = "0x1DBC2EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000211")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000880")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBC2F4", Offset = "0x1DBC2F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000212")]
		internal override RestrictionFacets Restriction
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000881")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBC2FC", Offset = "0x1DBC2FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000213")]
		internal abstract Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000882")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000214")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000883")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBC304", Offset = "0x1DBC304", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000884")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBC30C", Offset = "0x1DBC30C", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DatatypeImplementation), Member = "GetTypeName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(Exception),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(XmlSchemaObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000885")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBC4A4", Offset = "0x1DBC4A4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "ParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_QualifiedName", ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaDatatype), Member = "get_TypeCodeString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal string GetTypeName()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000886")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBC510", Offset = "0x1DBC510", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_hexBinary), Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_base64Binary), Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		protected int Compare(byte[] value1, byte[] value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000887")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBC560", Offset = "0x1DBC560", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaDatatype), Member = ".ctor", ReturnType = typeof(void))]
		protected DatatypeImplementation()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000470")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlSchemaDatatypeVariety variety;

		[global::Cpp2ILInjected.Token(Token = "0x4000471")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private RestrictionFacets restriction;

		[global::Cpp2ILInjected.Token(Token = "0x4000472")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private DatatypeImplementation baseType;

		[global::Cpp2ILInjected.Token(Token = "0x4000473")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private XmlValueConverter valueConverter;

		[global::Cpp2ILInjected.Token(Token = "0x4000474")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XmlSchemaType parentSchemaType;

		[global::Cpp2ILInjected.Token(Token = "0x4000475")]
		private static Hashtable builtinTypes;

		[global::Cpp2ILInjected.Token(Token = "0x4000476")]
		private static XmlSchemaSimpleType[] enumToTypeCode;

		[global::Cpp2ILInjected.Token(Token = "0x4000477")]
		private static XmlSchemaSimpleType anySimpleType;

		[global::Cpp2ILInjected.Token(Token = "0x4000478")]
		private static XmlSchemaSimpleType anyAtomicType;

		[global::Cpp2ILInjected.Token(Token = "0x4000479")]
		private static XmlSchemaSimpleType untypedAtomicType;

		[global::Cpp2ILInjected.Token(Token = "0x400047A")]
		private static XmlSchemaSimpleType yearMonthDurationType;

		[global::Cpp2ILInjected.Token(Token = "0x400047B")]
		private static XmlSchemaSimpleType dayTimeDurationType;

		[global::Cpp2ILInjected.Token(Token = "0x400047C")]
		internal static XmlQualifiedName QnAnySimpleType;

		[global::Cpp2ILInjected.Token(Token = "0x400047D")]
		internal static XmlQualifiedName QnAnyType;

		[global::Cpp2ILInjected.Token(Token = "0x400047E")]
		internal static FacetsChecker stringFacetsChecker;

		[global::Cpp2ILInjected.Token(Token = "0x400047F")]
		internal static FacetsChecker miscFacetsChecker;

		[global::Cpp2ILInjected.Token(Token = "0x4000480")]
		internal static FacetsChecker numeric2FacetsChecker;

		[global::Cpp2ILInjected.Token(Token = "0x4000481")]
		internal static FacetsChecker binaryFacetsChecker;

		[global::Cpp2ILInjected.Token(Token = "0x4000482")]
		internal static FacetsChecker dateTimeFacetsChecker;

		[global::Cpp2ILInjected.Token(Token = "0x4000483")]
		internal static FacetsChecker durationFacetsChecker;

		[global::Cpp2ILInjected.Token(Token = "0x4000484")]
		internal static FacetsChecker listFacetsChecker;

		[global::Cpp2ILInjected.Token(Token = "0x4000485")]
		internal static FacetsChecker qnameFacetsChecker;

		[global::Cpp2ILInjected.Token(Token = "0x4000486")]
		internal static FacetsChecker unionFacetsChecker;

		[global::Cpp2ILInjected.Token(Token = "0x4000487")]
		private static readonly DatatypeImplementation c_anySimpleType;

		[global::Cpp2ILInjected.Token(Token = "0x4000488")]
		private static readonly DatatypeImplementation c_anyURI;

		[global::Cpp2ILInjected.Token(Token = "0x4000489")]
		private static readonly DatatypeImplementation c_base64Binary;

		[global::Cpp2ILInjected.Token(Token = "0x400048A")]
		private static readonly DatatypeImplementation c_boolean;

		[global::Cpp2ILInjected.Token(Token = "0x400048B")]
		private static readonly DatatypeImplementation c_byte;

		[global::Cpp2ILInjected.Token(Token = "0x400048C")]
		private static readonly DatatypeImplementation c_char;

		[global::Cpp2ILInjected.Token(Token = "0x400048D")]
		private static readonly DatatypeImplementation c_date;

		[global::Cpp2ILInjected.Token(Token = "0x400048E")]
		private static readonly DatatypeImplementation c_dateTime;

		[global::Cpp2ILInjected.Token(Token = "0x400048F")]
		private static readonly DatatypeImplementation c_dateTimeNoTz;

		[global::Cpp2ILInjected.Token(Token = "0x4000490")]
		private static readonly DatatypeImplementation c_dateTimeTz;

		[global::Cpp2ILInjected.Token(Token = "0x4000491")]
		private static readonly DatatypeImplementation c_day;

		[global::Cpp2ILInjected.Token(Token = "0x4000492")]
		private static readonly DatatypeImplementation c_decimal;

		[global::Cpp2ILInjected.Token(Token = "0x4000493")]
		private static readonly DatatypeImplementation c_double;

		[global::Cpp2ILInjected.Token(Token = "0x4000494")]
		private static readonly DatatypeImplementation c_doubleXdr;

		[global::Cpp2ILInjected.Token(Token = "0x4000495")]
		private static readonly DatatypeImplementation c_duration;

		[global::Cpp2ILInjected.Token(Token = "0x4000496")]
		private static readonly DatatypeImplementation c_ENTITY;

		[global::Cpp2ILInjected.Token(Token = "0x4000497")]
		private static readonly DatatypeImplementation c_ENTITIES;

		[global::Cpp2ILInjected.Token(Token = "0x4000498")]
		private static readonly DatatypeImplementation c_ENUMERATION;

		[global::Cpp2ILInjected.Token(Token = "0x4000499")]
		private static readonly DatatypeImplementation c_fixed;

		[global::Cpp2ILInjected.Token(Token = "0x400049A")]
		private static readonly DatatypeImplementation c_float;

		[global::Cpp2ILInjected.Token(Token = "0x400049B")]
		private static readonly DatatypeImplementation c_floatXdr;

		[global::Cpp2ILInjected.Token(Token = "0x400049C")]
		private static readonly DatatypeImplementation c_hexBinary;

		[global::Cpp2ILInjected.Token(Token = "0x400049D")]
		private static readonly DatatypeImplementation c_ID;

		[global::Cpp2ILInjected.Token(Token = "0x400049E")]
		private static readonly DatatypeImplementation c_IDREF;

		[global::Cpp2ILInjected.Token(Token = "0x400049F")]
		private static readonly DatatypeImplementation c_IDREFS;

		[global::Cpp2ILInjected.Token(Token = "0x40004A0")]
		private static readonly DatatypeImplementation c_int;

		[global::Cpp2ILInjected.Token(Token = "0x40004A1")]
		private static readonly DatatypeImplementation c_integer;

		[global::Cpp2ILInjected.Token(Token = "0x40004A2")]
		private static readonly DatatypeImplementation c_language;

		[global::Cpp2ILInjected.Token(Token = "0x40004A3")]
		private static readonly DatatypeImplementation c_long;

		[global::Cpp2ILInjected.Token(Token = "0x40004A4")]
		private static readonly DatatypeImplementation c_month;

		[global::Cpp2ILInjected.Token(Token = "0x40004A5")]
		private static readonly DatatypeImplementation c_monthDay;

		[global::Cpp2ILInjected.Token(Token = "0x40004A6")]
		private static readonly DatatypeImplementation c_Name;

		[global::Cpp2ILInjected.Token(Token = "0x40004A7")]
		private static readonly DatatypeImplementation c_NCName;

		[global::Cpp2ILInjected.Token(Token = "0x40004A8")]
		private static readonly DatatypeImplementation c_negativeInteger;

		[global::Cpp2ILInjected.Token(Token = "0x40004A9")]
		private static readonly DatatypeImplementation c_NMTOKEN;

		[global::Cpp2ILInjected.Token(Token = "0x40004AA")]
		private static readonly DatatypeImplementation c_NMTOKENS;

		[global::Cpp2ILInjected.Token(Token = "0x40004AB")]
		private static readonly DatatypeImplementation c_nonNegativeInteger;

		[global::Cpp2ILInjected.Token(Token = "0x40004AC")]
		private static readonly DatatypeImplementation c_nonPositiveInteger;

		[global::Cpp2ILInjected.Token(Token = "0x40004AD")]
		private static readonly DatatypeImplementation c_normalizedString;

		[global::Cpp2ILInjected.Token(Token = "0x40004AE")]
		private static readonly DatatypeImplementation c_NOTATION;

		[global::Cpp2ILInjected.Token(Token = "0x40004AF")]
		private static readonly DatatypeImplementation c_positiveInteger;

		[global::Cpp2ILInjected.Token(Token = "0x40004B0")]
		private static readonly DatatypeImplementation c_QName;

		[global::Cpp2ILInjected.Token(Token = "0x40004B1")]
		private static readonly DatatypeImplementation c_QNameXdr;

		[global::Cpp2ILInjected.Token(Token = "0x40004B2")]
		private static readonly DatatypeImplementation c_short;

		[global::Cpp2ILInjected.Token(Token = "0x40004B3")]
		private static readonly DatatypeImplementation c_string;

		[global::Cpp2ILInjected.Token(Token = "0x40004B4")]
		private static readonly DatatypeImplementation c_time;

		[global::Cpp2ILInjected.Token(Token = "0x40004B5")]
		private static readonly DatatypeImplementation c_timeNoTz;

		[global::Cpp2ILInjected.Token(Token = "0x40004B6")]
		private static readonly DatatypeImplementation c_timeTz;

		[global::Cpp2ILInjected.Token(Token = "0x40004B7")]
		private static readonly DatatypeImplementation c_token;

		[global::Cpp2ILInjected.Token(Token = "0x40004B8")]
		private static readonly DatatypeImplementation c_unsignedByte;

		[global::Cpp2ILInjected.Token(Token = "0x40004B9")]
		private static readonly DatatypeImplementation c_unsignedInt;

		[global::Cpp2ILInjected.Token(Token = "0x40004BA")]
		private static readonly DatatypeImplementation c_unsignedLong;

		[global::Cpp2ILInjected.Token(Token = "0x40004BB")]
		private static readonly DatatypeImplementation c_unsignedShort;

		[global::Cpp2ILInjected.Token(Token = "0x40004BC")]
		private static readonly DatatypeImplementation c_uuid;

		[global::Cpp2ILInjected.Token(Token = "0x40004BD")]
		private static readonly DatatypeImplementation c_year;

		[global::Cpp2ILInjected.Token(Token = "0x40004BE")]
		private static readonly DatatypeImplementation c_yearMonth;

		[global::Cpp2ILInjected.Token(Token = "0x40004BF")]
		internal static readonly DatatypeImplementation c_normalizedStringV1Compat;

		[global::Cpp2ILInjected.Token(Token = "0x40004C0")]
		internal static readonly DatatypeImplementation c_tokenV1Compat;

		[global::Cpp2ILInjected.Token(Token = "0x40004C1")]
		private static readonly DatatypeImplementation c_anyAtomicType;

		[global::Cpp2ILInjected.Token(Token = "0x40004C2")]
		private static readonly DatatypeImplementation c_dayTimeDuration;

		[global::Cpp2ILInjected.Token(Token = "0x40004C3")]
		private static readonly DatatypeImplementation c_untypedAtomicType;

		[global::Cpp2ILInjected.Token(Token = "0x40004C4")]
		private static readonly DatatypeImplementation c_yearMonthDuration;

		[global::Cpp2ILInjected.Token(Token = "0x40004C5")]
		private static readonly DatatypeImplementation[] c_tokenizedTypes;

		[global::Cpp2ILInjected.Token(Token = "0x40004C6")]
		private static readonly DatatypeImplementation[] c_tokenizedTypesXsd;

		[global::Cpp2ILInjected.Token(Token = "0x40004C7")]
		private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XdrTypes;

		[global::Cpp2ILInjected.Token(Token = "0x40004C8")]
		private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XsdTypes;

		[global::Cpp2ILInjected.Token(Token = "0x20000DE")]
		private class SchemaDatatypeMap : IComparable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000888")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBB5D8", Offset = "0x1DBB5D8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal SchemaDatatypeMap(string name, DatatypeImplementation type)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000889")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBB604", Offset = "0x1DBB604", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal SchemaDatatypeMap(string name, DatatypeImplementation type, int parentIndex)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600088A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBC568", Offset = "0x1DBC568", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static explicit operator DatatypeImplementation(DatatypeImplementation.SchemaDatatypeMap sdm)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000215")]
			public string Name
			{
				[global::Cpp2ILInjected.Token(Token = "0x600088B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1DBC570", Offset = "0x1DBC570", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000216")]
			public int ParentIndex
			{
				[global::Cpp2ILInjected.Token(Token = "0x600088C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1DBC578", Offset = "0x1DBC578", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x600088D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBC580", Offset = "0x1DBC580", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(StringComparison)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public int CompareTo(object obj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40004C9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string name;

			[global::Cpp2ILInjected.Token(Token = "0x40004CA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private DatatypeImplementation type;

			[global::Cpp2ILInjected.Token(Token = "0x40004CB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int parentIndex;
		}
	}
}
