using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000C0 RID: 192
	[global::Cpp2ILInjected.Token(Token = "0x20000EC")]
	internal class Datatype_dateTimeBase : Datatype_anySimpleType
	{
		// Token: 0x06000856 RID: 2134 RVA: 0x0000475A File Offset: 0x0000295A
		[global::Cpp2ILInjected.Token(Token = "0x60008EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC015C", Offset = "0x1DC015C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0000475D File Offset: 0x0000295D
		[global::Cpp2ILInjected.Token(Token = "0x17000245")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC01BC", Offset = "0x1DC01BC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00004760 File Offset: 0x00002960
		[global::Cpp2ILInjected.Token(Token = "0x17000246")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC0214", Offset = "0x1DC0214", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00004763 File Offset: 0x00002963
		[global::Cpp2ILInjected.Token(Token = "0x60008EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC021C", Offset = "0x1DC021C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_dateTimeNoTimeZone), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_dateTimeTimeZone), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_dateTime), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_timeNoTimeZone), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_timeTimeZone), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_time), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_date), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_yearMonth), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_year), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_monthDay), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_day), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_month), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Datatype_dateTimeBase(XsdDateTimeFlags dateTimeFlags)
		{
			throw null;
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00004766 File Offset: 0x00002966
		[global::Cpp2ILInjected.Token(Token = "0x17000247")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC0284", Offset = "0x1DC0284", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00004769 File Offset: 0x00002969
		[global::Cpp2ILInjected.Token(Token = "0x17000248")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC02DC", Offset = "0x1DC02DC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x0000476C File Offset: 0x0000296C
		[global::Cpp2ILInjected.Token(Token = "0x17000249")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC0334", Offset = "0x1DC0334", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0000476F File Offset: 0x0000296F
		[global::Cpp2ILInjected.Token(Token = "0x60008F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC033C", Offset = "0x1DC033C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "CompareTo", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00004772 File Offset: 0x00002972
		[global::Cpp2ILInjected.Token(Token = "0x60008F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC0444", Offset = "0x1DC0444", Length = "0x2F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags),
			typeof(ref XsdDateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00004775 File Offset: 0x00002975
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60008F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC073C", Offset = "0x1DC073C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Datatype_dateTimeBase()
		{
			throw null;
		}

		// Token: 0x04000364 RID: 868
		[global::Cpp2ILInjected.Token(Token = "0x40004DE")]
		private static readonly Type atomicValueType;

		// Token: 0x04000365 RID: 869
		[global::Cpp2ILInjected.Token(Token = "0x40004DF")]
		private static readonly Type listValueType;

		// Token: 0x04000366 RID: 870
		[global::Cpp2ILInjected.Token(Token = "0x40004E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private XsdDateTimeFlags dateTimeFlags;
	}
}
