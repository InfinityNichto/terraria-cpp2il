using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x02000103 RID: 259
	[global::Cpp2ILInjected.Token(Token = "0x2000133")]
	internal class SchemaInfo : IDtdInfo
	{
		// Token: 0x060009EE RID: 2542 RVA: 0x00004C0D File Offset: 0x00002E0D
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

		// Token: 0x170002CE RID: 718
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x00004C10 File Offset: 0x00002E10
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

		// Token: 0x170002CF RID: 719
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x00004C13 File Offset: 0x00002E13
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

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00004C16 File Offset: 0x00002E16
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

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00004C19 File Offset: 0x00002E19
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

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00004C1C File Offset: 0x00002E1C
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

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00004C1F File Offset: 0x00002E1F
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

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x00004C22 File Offset: 0x00002E22
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x00004C25 File Offset: 0x00002E25
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

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00004C28 File Offset: 0x00002E28
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

		// Token: 0x060009F8 RID: 2552 RVA: 0x00004C2B File Offset: 0x00002E2B
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

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00004C2E File Offset: 0x00002E2E
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

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x00004C31 File Offset: 0x00002E31
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

		// Token: 0x060009FB RID: 2555 RVA: 0x00004C34 File Offset: 0x00002E34
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

		// Token: 0x060009FC RID: 2556 RVA: 0x00004C37 File Offset: 0x00002E37
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

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00004C3A File Offset: 0x00002E3A
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

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x00004C3D File Offset: 0x00002E3D
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

		// Token: 0x040003C4 RID: 964
		[global::Cpp2ILInjected.Token(Token = "0x400054C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls;

		// Token: 0x040003C5 RID: 965
		[global::Cpp2ILInjected.Token(Token = "0x400054D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls;

		// Token: 0x040003C6 RID: 966
		[global::Cpp2ILInjected.Token(Token = "0x400054E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities;

		// Token: 0x040003C7 RID: 967
		[global::Cpp2ILInjected.Token(Token = "0x400054F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities;

		// Token: 0x040003C8 RID: 968
		[global::Cpp2ILInjected.Token(Token = "0x4000550")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XmlQualifiedName docTypeName;

		// Token: 0x040003C9 RID: 969
		[global::Cpp2ILInjected.Token(Token = "0x4000551")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string internalDtdSubset;

		// Token: 0x040003CA RID: 970
		[global::Cpp2ILInjected.Token(Token = "0x4000552")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool hasNonCDataAttributes;

		// Token: 0x040003CB RID: 971
		[global::Cpp2ILInjected.Token(Token = "0x4000553")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		private bool hasDefaultAttributes;

		// Token: 0x040003CC RID: 972
		[global::Cpp2ILInjected.Token(Token = "0x4000554")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Dictionary<string, bool> targetNamespaces;

		// Token: 0x040003CD RID: 973
		[global::Cpp2ILInjected.Token(Token = "0x4000555")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls;

		// Token: 0x040003CE RID: 974
		[global::Cpp2ILInjected.Token(Token = "0x4000556")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private SchemaType schemaType;

		// Token: 0x040003CF RID: 975
		[global::Cpp2ILInjected.Token(Token = "0x4000557")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType;

		// Token: 0x040003D0 RID: 976
		[global::Cpp2ILInjected.Token(Token = "0x4000558")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Dictionary<string, SchemaNotation> notations;
	}
}
