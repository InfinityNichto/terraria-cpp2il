using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000DC RID: 220
	[global::Cpp2ILInjected.Token(Token = "0x2000108")]
	internal class Datatype_NOTATION : Datatype_anySimpleType
	{
		// Token: 0x060008B8 RID: 2232 RVA: 0x00004880 File Offset: 0x00002A80
		[global::Cpp2ILInjected.Token(Token = "0x600094D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC218C", Offset = "0x1DC218C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlMiscConverter), Member = "Create", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00004883 File Offset: 0x00002A83
		[global::Cpp2ILInjected.Token(Token = "0x17000277")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x600094E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC2198", Offset = "0x1DC2198", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x00004886 File Offset: 0x00002A86
		[global::Cpp2ILInjected.Token(Token = "0x17000278")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600094F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC21F0", Offset = "0x1DC21F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x00004889 File Offset: 0x00002A89
		[global::Cpp2ILInjected.Token(Token = "0x17000279")]
		public override XmlTokenizedType TokenizedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000950")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC21F8", Offset = "0x1DC21F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0000488C File Offset: 0x00002A8C
		[global::Cpp2ILInjected.Token(Token = "0x1700027A")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000951")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC2200", Offset = "0x1DC2200", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0000488F File Offset: 0x00002A8F
		[global::Cpp2ILInjected.Token(Token = "0x1700027B")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000952")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC2258", Offset = "0x1DC2258", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00004892 File Offset: 0x00002A92
		[global::Cpp2ILInjected.Token(Token = "0x1700027C")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000953")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC22B0", Offset = "0x1DC22B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00004895 File Offset: 0x00002A95
		[global::Cpp2ILInjected.Token(Token = "0x6000954")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC22B8", Offset = "0x1DC22B8", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IXmlNamespaceResolver),
			typeof(ref string)
		}, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00004898 File Offset: 0x00002A98
		[global::Cpp2ILInjected.Token(Token = "0x6000955")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC24E0", Offset = "0x1DC24E0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_NOTATION()
		{
			throw null;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0000489B File Offset: 0x00002A9B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000956")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC2534", Offset = "0x1DC2534", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Datatype_NOTATION()
		{
			throw null;
		}

		// Token: 0x0400036F RID: 879
		[global::Cpp2ILInjected.Token(Token = "0x40004E9")]
		private static readonly Type atomicValueType;

		// Token: 0x04000370 RID: 880
		[global::Cpp2ILInjected.Token(Token = "0x40004EA")]
		private static readonly Type listValueType;
	}
}
