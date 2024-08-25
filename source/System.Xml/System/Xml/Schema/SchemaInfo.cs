using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x2000133")]
	internal class SchemaInfo : IDtdInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCB74C", Offset = "0x1DCB74C", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "Initialize", MemberParameters = new object[] { typeof(IDtdParserAdapter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, bool>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal SchemaInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F4")]
		public XmlQualifiedName DocTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A86")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB8F0", Offset = "0x1DCB8F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F5")]
		internal string InternalDtdSubset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A87")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB8F8", Offset = "0x1DCB8F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F6")]
		internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A88")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB900", Offset = "0x1DCB900", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F7")]
		internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A89")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB908", Offset = "0x1DCB908", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F8")]
		internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A8A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB910", Offset = "0x1DCB910", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new object[]
			{
				typeof(IDtdInfo),
				typeof(XmlDocumentType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new object[]
			{
				typeof(XmlQualifiedName),
				typeof(bool),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(SchemaEntity))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F9")]
		internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A8B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB988", Offset = "0x1DCB988", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new object[]
			{
				typeof(IDtdInfo),
				typeof(XmlDocumentType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new object[]
			{
				typeof(XmlQualifiedName),
				typeof(bool),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(SchemaEntity))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002FA")]
		internal SchemaType SchemaType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A8C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBA00", Offset = "0x1DCBA00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBA08", Offset = "0x1DCBA08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002FB")]
		internal Dictionary<string, SchemaNotation> Notations
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A8E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBA10", Offset = "0x1DCBA10", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new object[]
			{
				typeof(IDtdInfo),
				typeof(XmlDocumentType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new object[]
			{
				typeof(SchemaAttDef),
				typeof(SchemaElementDecl),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCBA88", Offset = "0x1DCBA88", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal void Finish()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002FC")]
		private bool System.Xml.IDtdInfo.HasDefaultAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A90")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBC20", Offset = "0x1DCBC20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002FD")]
		private bool System.Xml.IDtdInfo.HasNonCDataAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A91")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBC28", Offset = "0x1DCBC28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCBC30", Offset = "0x1DCBC30", Length = "0xBC")]
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
		private IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCBCEC", Offset = "0x1DCBCEC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002FE")]
		private XmlQualifiedName System.Xml.IDtdInfo.Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A94")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBD98", Offset = "0x1DCBD98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002FF")]
		private string System.Xml.IDtdInfo.InternalDtdSubset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A95")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCBDA0", Offset = "0x1DCBDA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x400054C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls;

		[global::Cpp2ILInjected.Token(Token = "0x400054D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls;

		[global::Cpp2ILInjected.Token(Token = "0x400054E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities;

		[global::Cpp2ILInjected.Token(Token = "0x400054F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities;

		[global::Cpp2ILInjected.Token(Token = "0x4000550")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XmlQualifiedName docTypeName;

		[global::Cpp2ILInjected.Token(Token = "0x4000551")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string internalDtdSubset;

		[global::Cpp2ILInjected.Token(Token = "0x4000552")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool hasNonCDataAttributes;

		[global::Cpp2ILInjected.Token(Token = "0x4000553")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		private bool hasDefaultAttributes;

		[global::Cpp2ILInjected.Token(Token = "0x4000554")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Dictionary<string, bool> targetNamespaces;

		[global::Cpp2ILInjected.Token(Token = "0x4000555")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls;

		[global::Cpp2ILInjected.Token(Token = "0x4000556")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private SchemaType schemaType;

		[global::Cpp2ILInjected.Token(Token = "0x4000557")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType;

		[global::Cpp2ILInjected.Token(Token = "0x4000558")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Dictionary<string, SchemaNotation> notations;
	}
}
