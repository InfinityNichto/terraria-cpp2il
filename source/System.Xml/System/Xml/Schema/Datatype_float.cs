using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000BA RID: 186
	[global::Cpp2ILInjected.Token(Token = "0x20000E6")]
	internal class Datatype_float : Datatype_anySimpleType
	{
		// Token: 0x06000828 RID: 2088 RVA: 0x000046D0 File Offset: 0x000028D0
		[global::Cpp2ILInjected.Token(Token = "0x60008BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBEA38", Offset = "0x1DBEA38", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x000046D3 File Offset: 0x000028D3
		[global::Cpp2ILInjected.Token(Token = "0x1700022F")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBEA98", Offset = "0x1DBEA98", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x000046D6 File Offset: 0x000028D6
		[global::Cpp2ILInjected.Token(Token = "0x17000230")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBEAF0", Offset = "0x1DBEAF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x000046D9 File Offset: 0x000028D9
		[global::Cpp2ILInjected.Token(Token = "0x17000231")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBEAF8", Offset = "0x1DBEAF8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x000046DC File Offset: 0x000028DC
		[global::Cpp2ILInjected.Token(Token = "0x17000232")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBEB50", Offset = "0x1DBEB50", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x000046DF File Offset: 0x000028DF
		[global::Cpp2ILInjected.Token(Token = "0x17000233")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBEBA8", Offset = "0x1DBEBA8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x000046E2 File Offset: 0x000028E2
		[global::Cpp2ILInjected.Token(Token = "0x60008C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBEBB0", Offset = "0x1DBEBB0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x000046E5 File Offset: 0x000028E5
		[global::Cpp2ILInjected.Token(Token = "0x60008C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBEC3C", Offset = "0x1DBEC3C", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToSingle", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref float)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000046E8 File Offset: 0x000028E8
		[global::Cpp2ILInjected.Token(Token = "0x60008C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBED70", Offset = "0x1DBED70", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_floatXdr), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_float()
		{
			throw null;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000046EB File Offset: 0x000028EB
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60008C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBEDC4", Offset = "0x1DBEDC4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Datatype_float()
		{
			throw null;
		}

		// Token: 0x0400035B RID: 859
		[global::Cpp2ILInjected.Token(Token = "0x40004D5")]
		private static readonly Type atomicValueType;

		// Token: 0x0400035C RID: 860
		[global::Cpp2ILInjected.Token(Token = "0x40004D6")]
		private static readonly Type listValueType;
	}
}
