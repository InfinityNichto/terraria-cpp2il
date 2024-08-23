using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x02000100 RID: 256
	[global::Cpp2ILInjected.Token(Token = "0x200012F")]
	internal abstract class SchemaDeclBase
	{
		// Token: 0x060009A5 RID: 2469 RVA: 0x00004B32 File Offset: 0x00002D32
		[global::Cpp2ILInjected.Token(Token = "0x6000A3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCA644", Offset = "0x1DCA644", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected SchemaDeclBase(XmlQualifiedName name, string prefix)
		{
			throw null;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00004B35 File Offset: 0x00002D35
		[global::Cpp2ILInjected.Token(Token = "0x6000A3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCA6D0", Offset = "0x1DCA6D0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SchemaAttDef), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SchemaElementDecl), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaDatatype) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected SchemaDeclBase()
		{
			throw null;
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x00004B38 File Offset: 0x00002D38
		[global::Cpp2ILInjected.Token(Token = "0x170002CB")]
		internal XmlQualifiedName Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A3E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAC20", Offset = "0x1DCAC20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00004B3B File Offset: 0x00002D3B
		[global::Cpp2ILInjected.Token(Token = "0x170002CC")]
		internal string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A3F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCA78C", Offset = "0x1DCA78C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "AddDefaultAttributes", MemberParameters = new object[] { typeof(XmlElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new object[]
			{
				typeof(IDtdInfo),
				typeof(XmlDocumentType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00004B3E File Offset: 0x00002D3E
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x00004B41 File Offset: 0x00002D41
		[global::Cpp2ILInjected.Token(Token = "0x170002CD")]
		internal bool IsDeclaredInExternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A40")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAC28", Offset = "0x1DCAC28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A41")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAC30", Offset = "0x1DCAC30", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00004B44 File Offset: 0x00002D44
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x00004B47 File Offset: 0x00002D47
		[global::Cpp2ILInjected.Token(Token = "0x170002CE")]
		internal SchemaDeclBase.Use Presence
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A42")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAC3C", Offset = "0x1DCAC3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A43")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAC44", Offset = "0x1DCAC44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x00004B4A File Offset: 0x00002D4A
		[global::Cpp2ILInjected.Token(Token = "0x170002CF")]
		internal XmlSchemaType SchemaType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A44")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAC4C", Offset = "0x1DCAC4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00004B4D File Offset: 0x00002D4D
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x00004B50 File Offset: 0x00002D50
		[global::Cpp2ILInjected.Token(Token = "0x170002D0")]
		internal XmlSchemaDatatype Datatype
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A45")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAC54", Offset = "0x1DCAC54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A46")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAC5C", Offset = "0x1DCAC5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00004B53 File Offset: 0x00002D53
		[global::Cpp2ILInjected.Token(Token = "0x6000A47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCAC64", Offset = "0x1DCAC64", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(SchemaElementDecl),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void AddValue(string value)
		{
			throw null;
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00004B56 File Offset: 0x00002D56
		[global::Cpp2ILInjected.Token(Token = "0x170002D1")]
		internal List<string> Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A48")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAD54", Offset = "0x1DCAD54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x00004B59 File Offset: 0x00002D59
		[global::Cpp2ILInjected.Token(Token = "0x170002D2")]
		internal string DefaultValueRaw
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A49")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAD5C", Offset = "0x1DCAD5C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "PrepareDefaultAttribute", MemberParameters = new object[]
			{
				typeof(SchemaAttDef),
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(XmlAttribute))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00004B5C File Offset: 0x00002D5C
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x00004B5F File Offset: 0x00002D5F
		[global::Cpp2ILInjected.Token(Token = "0x170002D3")]
		internal object DefaultValueTyped
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCADB0", Offset = "0x1DCADB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCADB8", Offset = "0x1DCADB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x040003A2 RID: 930
		[global::Cpp2ILInjected.Token(Token = "0x4000524")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected XmlQualifiedName name;

		// Token: 0x040003A3 RID: 931
		[global::Cpp2ILInjected.Token(Token = "0x4000525")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected string prefix;

		// Token: 0x040003A4 RID: 932
		[global::Cpp2ILInjected.Token(Token = "0x4000526")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected bool isDeclaredInExternal;

		// Token: 0x040003A5 RID: 933
		[global::Cpp2ILInjected.Token(Token = "0x4000527")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		protected SchemaDeclBase.Use presence;

		// Token: 0x040003A6 RID: 934
		[global::Cpp2ILInjected.Token(Token = "0x4000528")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected XmlSchemaType schemaType;

		// Token: 0x040003A7 RID: 935
		[global::Cpp2ILInjected.Token(Token = "0x4000529")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected XmlSchemaDatatype datatype;

		// Token: 0x040003A8 RID: 936
		[global::Cpp2ILInjected.Token(Token = "0x400052A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		protected string defaultValueRaw;

		// Token: 0x040003A9 RID: 937
		[global::Cpp2ILInjected.Token(Token = "0x400052B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		protected object defaultValueTyped;

		// Token: 0x040003AA RID: 938
		[global::Cpp2ILInjected.Token(Token = "0x400052C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		protected long maxLength;

		// Token: 0x040003AB RID: 939
		[global::Cpp2ILInjected.Token(Token = "0x400052D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		protected long minLength;

		// Token: 0x040003AC RID: 940
		[global::Cpp2ILInjected.Token(Token = "0x400052E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		protected List<string> values;

		// Token: 0x02000175 RID: 373
		[global::Cpp2ILInjected.Token(Token = "0x2000130")]
		internal enum Use
		{
			// Token: 0x04000671 RID: 1649
			[global::Cpp2ILInjected.Token(Token = "0x4000530")]
			Default,
			// Token: 0x04000672 RID: 1650
			[global::Cpp2ILInjected.Token(Token = "0x4000531")]
			Required,
			// Token: 0x04000673 RID: 1651
			[global::Cpp2ILInjected.Token(Token = "0x4000532")]
			Implied,
			// Token: 0x04000674 RID: 1652
			[global::Cpp2ILInjected.Token(Token = "0x4000533")]
			Fixed,
			// Token: 0x04000675 RID: 1653
			[global::Cpp2ILInjected.Token(Token = "0x4000534")]
			RequiredFixed
		}
	}
}
