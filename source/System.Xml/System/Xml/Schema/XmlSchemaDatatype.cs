using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x02000112 RID: 274
	[global::Cpp2ILInjected.Token(Token = "0x2000144")]
	public abstract class XmlSchemaDatatype
	{
		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000A32 RID: 2610
		[global::Cpp2ILInjected.Token(Token = "0x17000316")]
		public abstract Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ACC")]
			get;
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000A33 RID: 2611
		[global::Cpp2ILInjected.Token(Token = "0x17000317")]
		public abstract XmlTokenizedType TokenizedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ACD")]
			get;
		}

		// Token: 0x06000A34 RID: 2612
		[global::Cpp2ILInjected.Token(Token = "0x6000ACE")]
		public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr);

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00004CD3 File Offset: 0x00002ED3
		[global::Cpp2ILInjected.Token(Token = "0x17000318")]
		public virtual XmlSchemaDatatypeVariety Variety
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ACF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCDD90", Offset = "0x1DCDD90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x00004CD6 File Offset: 0x00002ED6
		[global::Cpp2ILInjected.Token(Token = "0x17000319")]
		public virtual XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AD0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCDD98", Offset = "0x1DCDD98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000A37 RID: 2615
		[global::Cpp2ILInjected.Token(Token = "0x1700031A")]
		internal abstract XmlValueConverter ValueConverter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AD1")]
			get;
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000A38 RID: 2616
		[global::Cpp2ILInjected.Token(Token = "0x1700031B")]
		internal abstract RestrictionFacets Restriction
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AD2")]
			get;
		}

		// Token: 0x06000A39 RID: 2617
		[global::Cpp2ILInjected.Token(Token = "0x6000AD3")]
		internal abstract int Compare(object value1, object value2);

		// Token: 0x06000A3A RID: 2618
		[global::Cpp2ILInjected.Token(Token = "0x6000AD4")]
		internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue);

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000A3B RID: 2619
		[global::Cpp2ILInjected.Token(Token = "0x1700031C")]
		internal abstract FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AD5")]
			get;
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000A3C RID: 2620
		[global::Cpp2ILInjected.Token(Token = "0x1700031D")]
		internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AD6")]
			get;
		}

		// Token: 0x06000A3D RID: 2621
		[global::Cpp2ILInjected.Token(Token = "0x6000AD7")]
		internal abstract bool IsEqual(object o1, object o2);

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00004CD9 File Offset: 0x00002ED9
		[global::Cpp2ILInjected.Token(Token = "0x1700031E")]
		internal string TypeCodeString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AD8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC7940", Offset = "0x1DC7940", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "GetTypeName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Numeric10FacetsChecker), Member = "CheckValueFacets", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(XmlSchemaDatatype)
			}, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaDatatype), Member = "TypeCodeToString", MemberParameters = new object[] { typeof(XmlTypeCode) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00004CDC File Offset: 0x00002EDC
		[global::Cpp2ILInjected.Token(Token = "0x6000AD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCDDA0", Offset = "0x1DCDDA0", Length = "0x4AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaDatatype), Member = "get_TypeCodeString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
		internal string TypeCodeToString(XmlTypeCode typeCode)
		{
			throw null;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00004CDF File Offset: 0x00002EDF
		[global::Cpp2ILInjected.Token(Token = "0x6000ADA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCA918", Offset = "0x1DCA918", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SchemaAttDef), Member = "set_TokenizedType", MemberParameters = new object[] { typeof(XmlTokenizedType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DatatypeImplementation), Member = "FromXmlTokenizedType", MemberParameters = new object[] { typeof(XmlTokenizedType) }, ReturnType = typeof(DatatypeImplementation))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token)
		{
			throw null;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00004CE2 File Offset: 0x00002EE2
		[global::Cpp2ILInjected.Token(Token = "0x6000ADB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCE24C", Offset = "0x1DCE24C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected XmlSchemaDatatype()
		{
			throw null;
		}
	}
}
