using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x2000131")]
	internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCADC0", Offset = "0x1DCADC0", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SchemaElementDecl), Member = "CreateAnyTypeElementDecl", ReturnType = typeof(SchemaElementDecl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SchemaElementDecl), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaDeclBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal SchemaElementDecl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCAE80", Offset = "0x1DCAE80", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(XmlSchemaSimpleType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaDeclBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal SchemaElementDecl(XmlSchemaDatatype dtype)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCAF88", Offset = "0x1DCAF88", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaDeclBase), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal SchemaElementDecl(XmlQualifiedName name, string prefix)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCB060", Offset = "0x1DCB060", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static SchemaElementDecl CreateAnyTypeElementDecl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002D4")]
		private bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A50")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB118", Offset = "0x1DCB118", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCB120", Offset = "0x1DCB120", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCB1CC", Offset = "0x1DCB1CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002D5")]
		internal bool IsIdDeclared
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A53")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB1D4", Offset = "0x1DCB1D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A54")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB1DC", Offset = "0x1DCB1DC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002D6")]
		internal bool HasNonCDataAttribute
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A55")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB1E8", Offset = "0x1DCB1E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A56")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB1F0", Offset = "0x1DCB1F0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002D7")]
		internal bool IsNotationDeclared
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A57")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB1FC", Offset = "0x1DCB1FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A58")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB204", Offset = "0x1DCB204", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002D8")]
		internal ContentValidator ContentValidator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A59")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB210", Offset = "0x1DCB210", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB218", Offset = "0x1DCB218", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002D9")]
		internal XmlSchemaAnyAttribute AnyAttribute
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB220", Offset = "0x1DCB220", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCB228", Offset = "0x1DCB228", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void AddAttDef(SchemaAttDef attdef)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCB374", Offset = "0x1DCB374", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(SchemaElementDecl),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal SchemaAttDef GetAttDef(XmlQualifiedName qname)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002DA")]
		internal IList<IDtdDefaultAttributeInfo> DefaultAttDefs
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A5E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB3E4", Offset = "0x1DCB3E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002DB")]
		internal Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB3EC", Offset = "0x1DCB3EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000A60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCB3F4", Offset = "0x1DCB3F4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static SchemaElementDecl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000535")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs;

		[global::Cpp2ILInjected.Token(Token = "0x4000536")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private List<IDtdDefaultAttributeInfo> defaultAttdefs;

		[global::Cpp2ILInjected.Token(Token = "0x4000537")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool isIdDeclared;

		[global::Cpp2ILInjected.Token(Token = "0x4000538")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x71")]
		private bool hasNonCDataAttribute;

		[global::Cpp2ILInjected.Token(Token = "0x4000539")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x72")]
		private bool hasRequiredAttribute;

		[global::Cpp2ILInjected.Token(Token = "0x400053A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x73")]
		private bool isNotationDeclared;

		[global::Cpp2ILInjected.Token(Token = "0x400053B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes;

		[global::Cpp2ILInjected.Token(Token = "0x400053C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private ContentValidator contentValidator;

		[global::Cpp2ILInjected.Token(Token = "0x400053D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private XmlSchemaAnyAttribute anyAttribute;

		[global::Cpp2ILInjected.Token(Token = "0x400053E")]
		internal static readonly SchemaElementDecl Empty;
	}
}
