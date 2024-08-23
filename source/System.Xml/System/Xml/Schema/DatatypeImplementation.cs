using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000B2 RID: 178
	[global::Cpp2ILInjected.Token(Token = "0x20000DD")]
	internal abstract class DatatypeImplementation : XmlSchemaDatatype
	{
		// Token: 0x060007E0 RID: 2016 RVA: 0x000045FB File Offset: 0x000027FB
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

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x000045FE File Offset: 0x000027FE
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

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00004601 File Offset: 0x00002801
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

		// Token: 0x060007E3 RID: 2019 RVA: 0x00004604 File Offset: 0x00002804
		[global::Cpp2ILInjected.Token(Token = "0x6000872")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBBD90", Offset = "0x1DBBD90", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaDatatype), Member = "FromXmlTokenizedType", MemberParameters = new object[] { typeof(XmlTokenizedType) }, ReturnType = typeof(XmlSchemaDatatype))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal new static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token)
		{
			throw null;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00004607 File Offset: 0x00002807
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

		// Token: 0x060007E5 RID: 2021 RVA: 0x0000460A File Offset: 0x0000280A
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

		// Token: 0x060007E6 RID: 2022 RVA: 0x0000460D File Offset: 0x0000280D
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

		// Token: 0x060007E7 RID: 2023 RVA: 0x00004610 File Offset: 0x00002810
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

		// Token: 0x060007E8 RID: 2024 RVA: 0x00004613 File Offset: 0x00002813
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

		// Token: 0x060007E9 RID: 2025 RVA: 0x00004616 File Offset: 0x00002816
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

		// Token: 0x060007EA RID: 2026 RVA: 0x00004619 File Offset: 0x00002819
		[global::Cpp2ILInjected.Token(Token = "0x6000879")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBC1C4", Offset = "0x1DBC1C4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override bool IsEqual(object o1, object o2)
		{
			throw null;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0000461C File Offset: 0x0000281C
		[global::Cpp2ILInjected.Token(Token = "0x600087A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBC1E4", Offset = "0x1DBC1E4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0000461F File Offset: 0x0000281F
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

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00004622 File Offset: 0x00002822
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

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00004625 File Offset: 0x00002825
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

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00004628 File Offset: 0x00002828
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

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x0000462B File Offset: 0x0000282B
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

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x0000462E File Offset: 0x0000282E
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

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00004631 File Offset: 0x00002831
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

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060007F3 RID: 2035
		[global::Cpp2ILInjected.Token(Token = "0x17000213")]
		internal abstract Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000882")]
			get;
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00004634 File Offset: 0x00002834
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

		// Token: 0x060007F5 RID: 2037 RVA: 0x00004637 File Offset: 0x00002837
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

		// Token: 0x060007F6 RID: 2038 RVA: 0x0000463A File Offset: 0x0000283A
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

		// Token: 0x060007F7 RID: 2039 RVA: 0x0000463D File Offset: 0x0000283D
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

		// Token: 0x060007F8 RID: 2040 RVA: 0x00004640 File Offset: 0x00002840
		[global::Cpp2ILInjected.Token(Token = "0x6000887")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBC560", Offset = "0x1DBC560", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaDatatype), Member = ".ctor", ReturnType = typeof(void))]
		protected DatatypeImplementation()
		{
			throw null;
		}

		// Token: 0x040002F9 RID: 761
		[global::Cpp2ILInjected.Token(Token = "0x4000470")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlSchemaDatatypeVariety variety;

		// Token: 0x040002FA RID: 762
		[global::Cpp2ILInjected.Token(Token = "0x4000471")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private RestrictionFacets restriction;

		// Token: 0x040002FB RID: 763
		[global::Cpp2ILInjected.Token(Token = "0x4000472")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private DatatypeImplementation baseType;

		// Token: 0x040002FC RID: 764
		[global::Cpp2ILInjected.Token(Token = "0x4000473")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private XmlValueConverter valueConverter;

		// Token: 0x040002FD RID: 765
		[global::Cpp2ILInjected.Token(Token = "0x4000474")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XmlSchemaType parentSchemaType;

		// Token: 0x040002FE RID: 766
		[global::Cpp2ILInjected.Token(Token = "0x4000475")]
		private static Hashtable builtinTypes;

		// Token: 0x040002FF RID: 767
		[global::Cpp2ILInjected.Token(Token = "0x4000476")]
		private static XmlSchemaSimpleType[] enumToTypeCode;

		// Token: 0x04000300 RID: 768
		[global::Cpp2ILInjected.Token(Token = "0x4000477")]
		private static XmlSchemaSimpleType anySimpleType;

		// Token: 0x04000301 RID: 769
		[global::Cpp2ILInjected.Token(Token = "0x4000478")]
		private static XmlSchemaSimpleType anyAtomicType;

		// Token: 0x04000302 RID: 770
		[global::Cpp2ILInjected.Token(Token = "0x4000479")]
		private static XmlSchemaSimpleType untypedAtomicType;

		// Token: 0x04000303 RID: 771
		[global::Cpp2ILInjected.Token(Token = "0x400047A")]
		private static XmlSchemaSimpleType yearMonthDurationType;

		// Token: 0x04000304 RID: 772
		[global::Cpp2ILInjected.Token(Token = "0x400047B")]
		private static XmlSchemaSimpleType dayTimeDurationType;

		// Token: 0x04000305 RID: 773
		[global::Cpp2ILInjected.Token(Token = "0x400047C")]
		internal static XmlQualifiedName QnAnySimpleType;

		// Token: 0x04000306 RID: 774
		[global::Cpp2ILInjected.Token(Token = "0x400047D")]
		internal static XmlQualifiedName QnAnyType;

		// Token: 0x04000307 RID: 775
		[global::Cpp2ILInjected.Token(Token = "0x400047E")]
		internal static FacetsChecker stringFacetsChecker;

		// Token: 0x04000308 RID: 776
		[global::Cpp2ILInjected.Token(Token = "0x400047F")]
		internal static FacetsChecker miscFacetsChecker;

		// Token: 0x04000309 RID: 777
		[global::Cpp2ILInjected.Token(Token = "0x4000480")]
		internal static FacetsChecker numeric2FacetsChecker;

		// Token: 0x0400030A RID: 778
		[global::Cpp2ILInjected.Token(Token = "0x4000481")]
		internal static FacetsChecker binaryFacetsChecker;

		// Token: 0x0400030B RID: 779
		[global::Cpp2ILInjected.Token(Token = "0x4000482")]
		internal static FacetsChecker dateTimeFacetsChecker;

		// Token: 0x0400030C RID: 780
		[global::Cpp2ILInjected.Token(Token = "0x4000483")]
		internal static FacetsChecker durationFacetsChecker;

		// Token: 0x0400030D RID: 781
		[global::Cpp2ILInjected.Token(Token = "0x4000484")]
		internal static FacetsChecker listFacetsChecker;

		// Token: 0x0400030E RID: 782
		[global::Cpp2ILInjected.Token(Token = "0x4000485")]
		internal static FacetsChecker qnameFacetsChecker;

		// Token: 0x0400030F RID: 783
		[global::Cpp2ILInjected.Token(Token = "0x4000486")]
		internal static FacetsChecker unionFacetsChecker;

		// Token: 0x04000310 RID: 784
		[global::Cpp2ILInjected.Token(Token = "0x4000487")]
		private static readonly DatatypeImplementation c_anySimpleType;

		// Token: 0x04000311 RID: 785
		[global::Cpp2ILInjected.Token(Token = "0x4000488")]
		private static readonly DatatypeImplementation c_anyURI;

		// Token: 0x04000312 RID: 786
		[global::Cpp2ILInjected.Token(Token = "0x4000489")]
		private static readonly DatatypeImplementation c_base64Binary;

		// Token: 0x04000313 RID: 787
		[global::Cpp2ILInjected.Token(Token = "0x400048A")]
		private static readonly DatatypeImplementation c_boolean;

		// Token: 0x04000314 RID: 788
		[global::Cpp2ILInjected.Token(Token = "0x400048B")]
		private static readonly DatatypeImplementation c_byte;

		// Token: 0x04000315 RID: 789
		[global::Cpp2ILInjected.Token(Token = "0x400048C")]
		private static readonly DatatypeImplementation c_char;

		// Token: 0x04000316 RID: 790
		[global::Cpp2ILInjected.Token(Token = "0x400048D")]
		private static readonly DatatypeImplementation c_date;

		// Token: 0x04000317 RID: 791
		[global::Cpp2ILInjected.Token(Token = "0x400048E")]
		private static readonly DatatypeImplementation c_dateTime;

		// Token: 0x04000318 RID: 792
		[global::Cpp2ILInjected.Token(Token = "0x400048F")]
		private static readonly DatatypeImplementation c_dateTimeNoTz;

		// Token: 0x04000319 RID: 793
		[global::Cpp2ILInjected.Token(Token = "0x4000490")]
		private static readonly DatatypeImplementation c_dateTimeTz;

		// Token: 0x0400031A RID: 794
		[global::Cpp2ILInjected.Token(Token = "0x4000491")]
		private static readonly DatatypeImplementation c_day;

		// Token: 0x0400031B RID: 795
		[global::Cpp2ILInjected.Token(Token = "0x4000492")]
		private static readonly DatatypeImplementation c_decimal;

		// Token: 0x0400031C RID: 796
		[global::Cpp2ILInjected.Token(Token = "0x4000493")]
		private static readonly DatatypeImplementation c_double;

		// Token: 0x0400031D RID: 797
		[global::Cpp2ILInjected.Token(Token = "0x4000494")]
		private static readonly DatatypeImplementation c_doubleXdr;

		// Token: 0x0400031E RID: 798
		[global::Cpp2ILInjected.Token(Token = "0x4000495")]
		private static readonly DatatypeImplementation c_duration;

		// Token: 0x0400031F RID: 799
		[global::Cpp2ILInjected.Token(Token = "0x4000496")]
		private static readonly DatatypeImplementation c_ENTITY;

		// Token: 0x04000320 RID: 800
		[global::Cpp2ILInjected.Token(Token = "0x4000497")]
		private static readonly DatatypeImplementation c_ENTITIES;

		// Token: 0x04000321 RID: 801
		[global::Cpp2ILInjected.Token(Token = "0x4000498")]
		private static readonly DatatypeImplementation c_ENUMERATION;

		// Token: 0x04000322 RID: 802
		[global::Cpp2ILInjected.Token(Token = "0x4000499")]
		private static readonly DatatypeImplementation c_fixed;

		// Token: 0x04000323 RID: 803
		[global::Cpp2ILInjected.Token(Token = "0x400049A")]
		private static readonly DatatypeImplementation c_float;

		// Token: 0x04000324 RID: 804
		[global::Cpp2ILInjected.Token(Token = "0x400049B")]
		private static readonly DatatypeImplementation c_floatXdr;

		// Token: 0x04000325 RID: 805
		[global::Cpp2ILInjected.Token(Token = "0x400049C")]
		private static readonly DatatypeImplementation c_hexBinary;

		// Token: 0x04000326 RID: 806
		[global::Cpp2ILInjected.Token(Token = "0x400049D")]
		private static readonly DatatypeImplementation c_ID;

		// Token: 0x04000327 RID: 807
		[global::Cpp2ILInjected.Token(Token = "0x400049E")]
		private static readonly DatatypeImplementation c_IDREF;

		// Token: 0x04000328 RID: 808
		[global::Cpp2ILInjected.Token(Token = "0x400049F")]
		private static readonly DatatypeImplementation c_IDREFS;

		// Token: 0x04000329 RID: 809
		[global::Cpp2ILInjected.Token(Token = "0x40004A0")]
		private static readonly DatatypeImplementation c_int;

		// Token: 0x0400032A RID: 810
		[global::Cpp2ILInjected.Token(Token = "0x40004A1")]
		private static readonly DatatypeImplementation c_integer;

		// Token: 0x0400032B RID: 811
		[global::Cpp2ILInjected.Token(Token = "0x40004A2")]
		private static readonly DatatypeImplementation c_language;

		// Token: 0x0400032C RID: 812
		[global::Cpp2ILInjected.Token(Token = "0x40004A3")]
		private static readonly DatatypeImplementation c_long;

		// Token: 0x0400032D RID: 813
		[global::Cpp2ILInjected.Token(Token = "0x40004A4")]
		private static readonly DatatypeImplementation c_month;

		// Token: 0x0400032E RID: 814
		[global::Cpp2ILInjected.Token(Token = "0x40004A5")]
		private static readonly DatatypeImplementation c_monthDay;

		// Token: 0x0400032F RID: 815
		[global::Cpp2ILInjected.Token(Token = "0x40004A6")]
		private static readonly DatatypeImplementation c_Name;

		// Token: 0x04000330 RID: 816
		[global::Cpp2ILInjected.Token(Token = "0x40004A7")]
		private static readonly DatatypeImplementation c_NCName;

		// Token: 0x04000331 RID: 817
		[global::Cpp2ILInjected.Token(Token = "0x40004A8")]
		private static readonly DatatypeImplementation c_negativeInteger;

		// Token: 0x04000332 RID: 818
		[global::Cpp2ILInjected.Token(Token = "0x40004A9")]
		private static readonly DatatypeImplementation c_NMTOKEN;

		// Token: 0x04000333 RID: 819
		[global::Cpp2ILInjected.Token(Token = "0x40004AA")]
		private static readonly DatatypeImplementation c_NMTOKENS;

		// Token: 0x04000334 RID: 820
		[global::Cpp2ILInjected.Token(Token = "0x40004AB")]
		private static readonly DatatypeImplementation c_nonNegativeInteger;

		// Token: 0x04000335 RID: 821
		[global::Cpp2ILInjected.Token(Token = "0x40004AC")]
		private static readonly DatatypeImplementation c_nonPositiveInteger;

		// Token: 0x04000336 RID: 822
		[global::Cpp2ILInjected.Token(Token = "0x40004AD")]
		private static readonly DatatypeImplementation c_normalizedString;

		// Token: 0x04000337 RID: 823
		[global::Cpp2ILInjected.Token(Token = "0x40004AE")]
		private static readonly DatatypeImplementation c_NOTATION;

		// Token: 0x04000338 RID: 824
		[global::Cpp2ILInjected.Token(Token = "0x40004AF")]
		private static readonly DatatypeImplementation c_positiveInteger;

		// Token: 0x04000339 RID: 825
		[global::Cpp2ILInjected.Token(Token = "0x40004B0")]
		private static readonly DatatypeImplementation c_QName;

		// Token: 0x0400033A RID: 826
		[global::Cpp2ILInjected.Token(Token = "0x40004B1")]
		private static readonly DatatypeImplementation c_QNameXdr;

		// Token: 0x0400033B RID: 827
		[global::Cpp2ILInjected.Token(Token = "0x40004B2")]
		private static readonly DatatypeImplementation c_short;

		// Token: 0x0400033C RID: 828
		[global::Cpp2ILInjected.Token(Token = "0x40004B3")]
		private static readonly DatatypeImplementation c_string;

		// Token: 0x0400033D RID: 829
		[global::Cpp2ILInjected.Token(Token = "0x40004B4")]
		private static readonly DatatypeImplementation c_time;

		// Token: 0x0400033E RID: 830
		[global::Cpp2ILInjected.Token(Token = "0x40004B5")]
		private static readonly DatatypeImplementation c_timeNoTz;

		// Token: 0x0400033F RID: 831
		[global::Cpp2ILInjected.Token(Token = "0x40004B6")]
		private static readonly DatatypeImplementation c_timeTz;

		// Token: 0x04000340 RID: 832
		[global::Cpp2ILInjected.Token(Token = "0x40004B7")]
		private static readonly DatatypeImplementation c_token;

		// Token: 0x04000341 RID: 833
		[global::Cpp2ILInjected.Token(Token = "0x40004B8")]
		private static readonly DatatypeImplementation c_unsignedByte;

		// Token: 0x04000342 RID: 834
		[global::Cpp2ILInjected.Token(Token = "0x40004B9")]
		private static readonly DatatypeImplementation c_unsignedInt;

		// Token: 0x04000343 RID: 835
		[global::Cpp2ILInjected.Token(Token = "0x40004BA")]
		private static readonly DatatypeImplementation c_unsignedLong;

		// Token: 0x04000344 RID: 836
		[global::Cpp2ILInjected.Token(Token = "0x40004BB")]
		private static readonly DatatypeImplementation c_unsignedShort;

		// Token: 0x04000345 RID: 837
		[global::Cpp2ILInjected.Token(Token = "0x40004BC")]
		private static readonly DatatypeImplementation c_uuid;

		// Token: 0x04000346 RID: 838
		[global::Cpp2ILInjected.Token(Token = "0x40004BD")]
		private static readonly DatatypeImplementation c_year;

		// Token: 0x04000347 RID: 839
		[global::Cpp2ILInjected.Token(Token = "0x40004BE")]
		private static readonly DatatypeImplementation c_yearMonth;

		// Token: 0x04000348 RID: 840
		[global::Cpp2ILInjected.Token(Token = "0x40004BF")]
		internal static readonly DatatypeImplementation c_normalizedStringV1Compat;

		// Token: 0x04000349 RID: 841
		[global::Cpp2ILInjected.Token(Token = "0x40004C0")]
		internal static readonly DatatypeImplementation c_tokenV1Compat;

		// Token: 0x0400034A RID: 842
		[global::Cpp2ILInjected.Token(Token = "0x40004C1")]
		private static readonly DatatypeImplementation c_anyAtomicType;

		// Token: 0x0400034B RID: 843
		[global::Cpp2ILInjected.Token(Token = "0x40004C2")]
		private static readonly DatatypeImplementation c_dayTimeDuration;

		// Token: 0x0400034C RID: 844
		[global::Cpp2ILInjected.Token(Token = "0x40004C3")]
		private static readonly DatatypeImplementation c_untypedAtomicType;

		// Token: 0x0400034D RID: 845
		[global::Cpp2ILInjected.Token(Token = "0x40004C4")]
		private static readonly DatatypeImplementation c_yearMonthDuration;

		// Token: 0x0400034E RID: 846
		[global::Cpp2ILInjected.Token(Token = "0x40004C5")]
		private static readonly DatatypeImplementation[] c_tokenizedTypes;

		// Token: 0x0400034F RID: 847
		[global::Cpp2ILInjected.Token(Token = "0x40004C6")]
		private static readonly DatatypeImplementation[] c_tokenizedTypesXsd;

		// Token: 0x04000350 RID: 848
		[global::Cpp2ILInjected.Token(Token = "0x40004C7")]
		private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XdrTypes;

		// Token: 0x04000351 RID: 849
		[global::Cpp2ILInjected.Token(Token = "0x40004C8")]
		private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XsdTypes;

		// Token: 0x02000171 RID: 369
		[global::Cpp2ILInjected.Token(Token = "0x20000DE")]
		private class SchemaDatatypeMap : IComparable
		{
			// Token: 0x06000CC2 RID: 3266 RVA: 0x000053A2 File Offset: 0x000035A2
			[global::Cpp2ILInjected.Token(Token = "0x6000888")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBB5D8", Offset = "0x1DBB5D8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal SchemaDatatypeMap(string name, DatatypeImplementation type)
			{
				throw null;
			}

			// Token: 0x06000CC3 RID: 3267 RVA: 0x000053A5 File Offset: 0x000035A5
			[global::Cpp2ILInjected.Token(Token = "0x6000889")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBB604", Offset = "0x1DBB604", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal SchemaDatatypeMap(string name, DatatypeImplementation type, int parentIndex)
			{
				throw null;
			}

			// Token: 0x06000CC4 RID: 3268 RVA: 0x000053A8 File Offset: 0x000035A8
			[global::Cpp2ILInjected.Token(Token = "0x600088A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBC568", Offset = "0x1DBC568", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static explicit operator DatatypeImplementation(DatatypeImplementation.SchemaDatatypeMap sdm)
			{
				throw null;
			}

			// Token: 0x17000369 RID: 873
			// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x000053AB File Offset: 0x000035AB
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

			// Token: 0x1700036A RID: 874
			// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x000053AE File Offset: 0x000035AE
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

			// Token: 0x06000CC7 RID: 3271 RVA: 0x000053B1 File Offset: 0x000035B1
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

			// Token: 0x04000665 RID: 1637
			[global::Cpp2ILInjected.Token(Token = "0x40004C9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string name;

			// Token: 0x04000666 RID: 1638
			[global::Cpp2ILInjected.Token(Token = "0x40004CA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private DatatypeImplementation type;

			// Token: 0x04000667 RID: 1639
			[global::Cpp2ILInjected.Token(Token = "0x40004CB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int parentIndex;
		}
	}
}
