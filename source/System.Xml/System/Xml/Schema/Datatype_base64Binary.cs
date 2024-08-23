using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000CE RID: 206
	[global::Cpp2ILInjected.Token(Token = "0x20000FA")]
	internal class Datatype_base64Binary : Datatype_anySimpleType
	{
		// Token: 0x0600087D RID: 2173 RVA: 0x000047CF File Offset: 0x000029CF
		[global::Cpp2ILInjected.Token(Token = "0x6000912")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC10D8", Offset = "0x1DC10D8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlMiscConverter), Member = "Create", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x000047D2 File Offset: 0x000029D2
		[global::Cpp2ILInjected.Token(Token = "0x17000256")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000913")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC10E4", Offset = "0x1DC10E4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x000047D5 File Offset: 0x000029D5
		[global::Cpp2ILInjected.Token(Token = "0x17000257")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000914")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC113C", Offset = "0x1DC113C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x000047D8 File Offset: 0x000029D8
		[global::Cpp2ILInjected.Token(Token = "0x17000258")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000915")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC1144", Offset = "0x1DC1144", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x000047DB File Offset: 0x000029DB
		[global::Cpp2ILInjected.Token(Token = "0x17000259")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000916")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC119C", Offset = "0x1DC119C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x000047DE File Offset: 0x000029DE
		[global::Cpp2ILInjected.Token(Token = "0x1700025A")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000917")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC11F4", Offset = "0x1DC11F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x000047E1 File Offset: 0x000029E1
		[global::Cpp2ILInjected.Token(Token = "0x6000918")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC11FC", Offset = "0x1DC11FC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DatatypeImplementation), Member = "Compare", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x000047E4 File Offset: 0x000029E4
		[global::Cpp2ILInjected.Token(Token = "0x6000919")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC12B8", Offset = "0x1DC12B8", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000047E7 File Offset: 0x000029E7
		[global::Cpp2ILInjected.Token(Token = "0x600091A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC144C", Offset = "0x1DC144C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_base64Binary()
		{
			throw null;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000047EA File Offset: 0x000029EA
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600091B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC14A0", Offset = "0x1DC14A0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Datatype_base64Binary()
		{
			throw null;
		}

		// Token: 0x04000369 RID: 873
		[global::Cpp2ILInjected.Token(Token = "0x40004E3")]
		private static readonly Type atomicValueType;

		// Token: 0x0400036A RID: 874
		[global::Cpp2ILInjected.Token(Token = "0x40004E4")]
		private static readonly Type listValueType;
	}
}
