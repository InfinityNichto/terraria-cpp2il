using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000BB RID: 187
	[global::Cpp2ILInjected.Token(Token = "0x20000E7")]
	internal class Datatype_double : Datatype_anySimpleType
	{
		// Token: 0x06000832 RID: 2098 RVA: 0x000046EE File Offset: 0x000028EE
		[global::Cpp2ILInjected.Token(Token = "0x60008C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBEE80", Offset = "0x1DBEE80", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNumeric2Converter), Member = "Create", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x000046F1 File Offset: 0x000028F1
		[global::Cpp2ILInjected.Token(Token = "0x17000234")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBEE88", Offset = "0x1DBEE88", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x000046F4 File Offset: 0x000028F4
		[global::Cpp2ILInjected.Token(Token = "0x17000235")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBEEE0", Offset = "0x1DBEEE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x000046F7 File Offset: 0x000028F7
		[global::Cpp2ILInjected.Token(Token = "0x17000236")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBEEE8", Offset = "0x1DBEEE8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x000046FA File Offset: 0x000028FA
		[global::Cpp2ILInjected.Token(Token = "0x17000237")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBEF40", Offset = "0x1DBEF40", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x000046FD File Offset: 0x000028FD
		[global::Cpp2ILInjected.Token(Token = "0x17000238")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBEF98", Offset = "0x1DBEF98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00004700 File Offset: 0x00002900
		[global::Cpp2ILInjected.Token(Token = "0x60008CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBEFA0", Offset = "0x1DBEFA0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00004703 File Offset: 0x00002903
		[global::Cpp2ILInjected.Token(Token = "0x60008CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBF02C", Offset = "0x1DBF02C", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToDouble", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref double)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00004706 File Offset: 0x00002906
		[global::Cpp2ILInjected.Token(Token = "0x60008CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBF160", Offset = "0x1DBF160", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_doubleXdr), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_double()
		{
			throw null;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00004709 File Offset: 0x00002909
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60008D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBF1B4", Offset = "0x1DBF1B4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Datatype_double()
		{
			throw null;
		}

		// Token: 0x0400035D RID: 861
		[global::Cpp2ILInjected.Token(Token = "0x40004D7")]
		private static readonly Type atomicValueType;

		// Token: 0x0400035E RID: 862
		[global::Cpp2ILInjected.Token(Token = "0x40004D8")]
		private static readonly Type listValueType;
	}
}
