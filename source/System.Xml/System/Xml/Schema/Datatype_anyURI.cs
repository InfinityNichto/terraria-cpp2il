using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000CF RID: 207
	[global::Cpp2ILInjected.Token(Token = "0x20000FB")]
	internal class Datatype_anyURI : Datatype_anySimpleType
	{
		// Token: 0x06000887 RID: 2183 RVA: 0x000047ED File Offset: 0x000029ED
		[global::Cpp2ILInjected.Token(Token = "0x600091C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC155C", Offset = "0x1DC155C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlMiscConverter), Member = "Create", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x000047F0 File Offset: 0x000029F0
		[global::Cpp2ILInjected.Token(Token = "0x1700025B")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x600091D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC1568", Offset = "0x1DC1568", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x000047F3 File Offset: 0x000029F3
		[global::Cpp2ILInjected.Token(Token = "0x1700025C")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600091E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC15C0", Offset = "0x1DC15C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x000047F6 File Offset: 0x000029F6
		[global::Cpp2ILInjected.Token(Token = "0x1700025D")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600091F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC15C8", Offset = "0x1DC15C8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x000047F9 File Offset: 0x000029F9
		[global::Cpp2ILInjected.Token(Token = "0x1700025E")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000920")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC1620", Offset = "0x1DC1620", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x000047FC File Offset: 0x000029FC
		[global::Cpp2ILInjected.Token(Token = "0x1700025F")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000921")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC1678", Offset = "0x1DC1678", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x000047FF File Offset: 0x000029FF
		[global::Cpp2ILInjected.Token(Token = "0x6000922")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC1680", Offset = "0x1DC1680", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00004802 File Offset: 0x00002A02
		[global::Cpp2ILInjected.Token(Token = "0x6000923")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC1754", Offset = "0x1DC1754", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToUri", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref Uri)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringFacetsChecker), Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlSchemaDatatype),
			typeof(bool)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00004805 File Offset: 0x00002A05
		[global::Cpp2ILInjected.Token(Token = "0x6000924")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC1A78", Offset = "0x1DC1A78", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_anyURI()
		{
			throw null;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00004808 File Offset: 0x00002A08
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000925")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC1ACC", Offset = "0x1DC1ACC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Datatype_anyURI()
		{
			throw null;
		}

		// Token: 0x0400036B RID: 875
		[global::Cpp2ILInjected.Token(Token = "0x40004E5")]
		private static readonly Type atomicValueType;

		// Token: 0x0400036C RID: 876
		[global::Cpp2ILInjected.Token(Token = "0x40004E6")]
		private static readonly Type listValueType;
	}
}
