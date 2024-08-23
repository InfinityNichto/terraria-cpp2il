using System;
using System.Xml.XPath;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x02000129 RID: 297
	[global::Cpp2ILInjected.Token(Token = "0x200015D")]
	internal abstract class XmlBaseConverter : XmlValueConverter
	{
		// Token: 0x06000AC0 RID: 2752 RVA: 0x00004DAE File Offset: 0x00002FAE
		[global::Cpp2ILInjected.Token(Token = "0x6000B5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF2D4", Offset = "0x1DCF2D4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric2Converter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBooleanConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlStringConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlListConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "GetBuiltInSimpleType", MemberParameters = new object[] { typeof(XmlTypeCode) }, ReturnType = typeof(XmlSchemaSimpleType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_TypeCode", ReturnType = typeof(XmlTypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected XmlBaseConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00004DB1 File Offset: 0x00002FB1
		[global::Cpp2ILInjected.Token(Token = "0x6000B5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF398", Offset = "0x1DCF398", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlTypeCode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected XmlBaseConverter(XmlTypeCode typeCode)
		{
			throw null;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00004DB4 File Offset: 0x00002FB4
		[global::Cpp2ILInjected.Token(Token = "0x6000B5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF460", Offset = "0x1DCF460", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlListConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlBaseConverter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(int)
		}, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		protected XmlBaseConverter(XmlBaseConverter converterAtomic)
		{
			throw null;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00004DB7 File Offset: 0x00002FB7
		[global::Cpp2ILInjected.Token(Token = "0x6000B5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF4B0", Offset = "0x1DCF4B0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlListConverter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlBaseConverter),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected XmlBaseConverter(XmlBaseConverter converterAtomic, Type clrTypeDefault)
		{
			throw null;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00004DBA File Offset: 0x00002FBA
		[global::Cpp2ILInjected.Token(Token = "0x6000B5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF4EC", Offset = "0x1DCF4EC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool ToBoolean(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00004DBD File Offset: 0x00002FBD
		[global::Cpp2ILInjected.Token(Token = "0x6000B60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF5DC", Offset = "0x1DCF5DC", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool ToBoolean(double value)
		{
			throw null;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00004DC0 File Offset: 0x00002FC0
		[global::Cpp2ILInjected.Token(Token = "0x6000B61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF6D4", Offset = "0x1DCF6D4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool ToBoolean(int value)
		{
			throw null;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00004DC3 File Offset: 0x00002FC3
		[global::Cpp2ILInjected.Token(Token = "0x6000B62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF7C4", Offset = "0x1DCF7C4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool ToBoolean(long value)
		{
			throw null;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00004DC6 File Offset: 0x00002FC6
		[global::Cpp2ILInjected.Token(Token = "0x6000B63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF8B4", Offset = "0x1DCF8B4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool ToBoolean(string value)
		{
			throw null;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00004DC9 File Offset: 0x00002FC9
		[global::Cpp2ILInjected.Token(Token = "0x6000B64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF970", Offset = "0x1DCF970", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool ToBoolean(object value)
		{
			throw null;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00004DCC File Offset: 0x00002FCC
		[global::Cpp2ILInjected.Token(Token = "0x6000B65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCFA2C", Offset = "0x1DCFA2C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override DateTime ToDateTime(bool value)
		{
			throw null;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00004DCF File Offset: 0x00002FCF
		[global::Cpp2ILInjected.Token(Token = "0x6000B66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCFB1C", Offset = "0x1DCFB1C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override DateTime ToDateTime(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00004DD2 File Offset: 0x00002FD2
		[global::Cpp2ILInjected.Token(Token = "0x6000B67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCFC18", Offset = "0x1DCFC18", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override DateTime ToDateTime(double value)
		{
			throw null;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00004DD5 File Offset: 0x00002FD5
		[global::Cpp2ILInjected.Token(Token = "0x6000B68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCFD10", Offset = "0x1DCFD10", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override DateTime ToDateTime(int value)
		{
			throw null;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00004DD8 File Offset: 0x00002FD8
		[global::Cpp2ILInjected.Token(Token = "0x6000B69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCFE00", Offset = "0x1DCFE00", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override DateTime ToDateTime(long value)
		{
			throw null;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00004DDB File Offset: 0x00002FDB
		[global::Cpp2ILInjected.Token(Token = "0x6000B6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCFEF0", Offset = "0x1DCFEF0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override DateTime ToDateTime(string value)
		{
			throw null;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00004DDE File Offset: 0x00002FDE
		[global::Cpp2ILInjected.Token(Token = "0x6000B6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCFFAC", Offset = "0x1DCFFAC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override DateTime ToDateTime(object value)
		{
			throw null;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00004DE1 File Offset: 0x00002FE1
		[global::Cpp2ILInjected.Token(Token = "0x6000B6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD0068", Offset = "0x1DD0068", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override DateTimeOffset ToDateTimeOffset(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00004DE4 File Offset: 0x00002FE4
		[global::Cpp2ILInjected.Token(Token = "0x6000B6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD015C", Offset = "0x1DD015C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override DateTimeOffset ToDateTimeOffset(string value)
		{
			throw null;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00004DE7 File Offset: 0x00002FE7
		[global::Cpp2ILInjected.Token(Token = "0x6000B6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD021C", Offset = "0x1DD021C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override DateTimeOffset ToDateTimeOffset(object value)
		{
			throw null;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00004DEA File Offset: 0x00002FEA
		[global::Cpp2ILInjected.Token(Token = "0x6000B6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD02DC", Offset = "0x1DD02DC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override decimal ToDecimal(string value)
		{
			throw null;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00004DED File Offset: 0x00002FED
		[global::Cpp2ILInjected.Token(Token = "0x6000B70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD039C", Offset = "0x1DD039C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override decimal ToDecimal(object value)
		{
			throw null;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00004DF0 File Offset: 0x00002FF0
		[global::Cpp2ILInjected.Token(Token = "0x6000B71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD045C", Offset = "0x1DD045C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override double ToDouble(bool value)
		{
			throw null;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00004DF3 File Offset: 0x00002FF3
		[global::Cpp2ILInjected.Token(Token = "0x6000B72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD054C", Offset = "0x1DD054C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override double ToDouble(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00004DF6 File Offset: 0x00002FF6
		[global::Cpp2ILInjected.Token(Token = "0x6000B73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD063C", Offset = "0x1DD063C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override double ToDouble(int value)
		{
			throw null;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00004DF9 File Offset: 0x00002FF9
		[global::Cpp2ILInjected.Token(Token = "0x6000B74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD072C", Offset = "0x1DD072C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override double ToDouble(long value)
		{
			throw null;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00004DFC File Offset: 0x00002FFC
		[global::Cpp2ILInjected.Token(Token = "0x6000B75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD081C", Offset = "0x1DD081C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override double ToDouble(string value)
		{
			throw null;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00004DFF File Offset: 0x00002FFF
		[global::Cpp2ILInjected.Token(Token = "0x6000B76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD08D8", Offset = "0x1DD08D8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override double ToDouble(object value)
		{
			throw null;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00004E02 File Offset: 0x00003002
		[global::Cpp2ILInjected.Token(Token = "0x6000B77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD0994", Offset = "0x1DD0994", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override int ToInt32(bool value)
		{
			throw null;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00004E05 File Offset: 0x00003005
		[global::Cpp2ILInjected.Token(Token = "0x6000B78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD0A84", Offset = "0x1DD0A84", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override int ToInt32(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00004E08 File Offset: 0x00003008
		[global::Cpp2ILInjected.Token(Token = "0x6000B79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD0B74", Offset = "0x1DD0B74", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override int ToInt32(double value)
		{
			throw null;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00004E0B File Offset: 0x0000300B
		[global::Cpp2ILInjected.Token(Token = "0x6000B7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD0C6C", Offset = "0x1DD0C6C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override int ToInt32(long value)
		{
			throw null;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00004E0E File Offset: 0x0000300E
		[global::Cpp2ILInjected.Token(Token = "0x6000B7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD0D5C", Offset = "0x1DD0D5C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int ToInt32(string value)
		{
			throw null;
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00004E11 File Offset: 0x00003011
		[global::Cpp2ILInjected.Token(Token = "0x6000B7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD0E18", Offset = "0x1DD0E18", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int ToInt32(object value)
		{
			throw null;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00004E14 File Offset: 0x00003014
		[global::Cpp2ILInjected.Token(Token = "0x6000B7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD0ED4", Offset = "0x1DD0ED4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override long ToInt64(bool value)
		{
			throw null;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00004E17 File Offset: 0x00003017
		[global::Cpp2ILInjected.Token(Token = "0x6000B7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD0FC4", Offset = "0x1DD0FC4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override long ToInt64(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00004E1A File Offset: 0x0000301A
		[global::Cpp2ILInjected.Token(Token = "0x6000B7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD10B4", Offset = "0x1DD10B4", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override long ToInt64(double value)
		{
			throw null;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00004E1D File Offset: 0x0000301D
		[global::Cpp2ILInjected.Token(Token = "0x6000B80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD11AC", Offset = "0x1DD11AC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override long ToInt64(int value)
		{
			throw null;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00004E20 File Offset: 0x00003020
		[global::Cpp2ILInjected.Token(Token = "0x6000B81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD129C", Offset = "0x1DD129C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override long ToInt64(string value)
		{
			throw null;
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00004E23 File Offset: 0x00003023
		[global::Cpp2ILInjected.Token(Token = "0x6000B82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD1358", Offset = "0x1DD1358", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override long ToInt64(object value)
		{
			throw null;
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00004E26 File Offset: 0x00003026
		[global::Cpp2ILInjected.Token(Token = "0x6000B83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD1414", Offset = "0x1DD1414", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override float ToSingle(double value)
		{
			throw null;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00004E29 File Offset: 0x00003029
		[global::Cpp2ILInjected.Token(Token = "0x6000B84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD150C", Offset = "0x1DD150C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override float ToSingle(string value)
		{
			throw null;
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00004E2C File Offset: 0x0000302C
		[global::Cpp2ILInjected.Token(Token = "0x6000B85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD15C8", Offset = "0x1DD15C8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override float ToSingle(object value)
		{
			throw null;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00004E2F File Offset: 0x0000302F
		[global::Cpp2ILInjected.Token(Token = "0x6000B86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD1684", Offset = "0x1DD1684", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override string ToString(bool value)
		{
			throw null;
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00004E32 File Offset: 0x00003032
		[global::Cpp2ILInjected.Token(Token = "0x6000B87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD1768", Offset = "0x1DD1768", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override string ToString(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00004E35 File Offset: 0x00003035
		[global::Cpp2ILInjected.Token(Token = "0x6000B88")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD184C", Offset = "0x1DD184C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override string ToString(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00004E38 File Offset: 0x00003038
		[global::Cpp2ILInjected.Token(Token = "0x6000B89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD193C", Offset = "0x1DD193C", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override string ToString(decimal value)
		{
			throw null;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00004E3B File Offset: 0x0000303B
		[global::Cpp2ILInjected.Token(Token = "0x6000B8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD1A4C", Offset = "0x1DD1A4C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override string ToString(double value)
		{
			throw null;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00004E3E File Offset: 0x0000303E
		[global::Cpp2ILInjected.Token(Token = "0x6000B8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD1B38", Offset = "0x1DD1B38", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override string ToString(int value)
		{
			throw null;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00004E41 File Offset: 0x00003041
		[global::Cpp2ILInjected.Token(Token = "0x6000B8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD1C1C", Offset = "0x1DD1C1C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override string ToString(long value)
		{
			throw null;
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00004E44 File Offset: 0x00003044
		[global::Cpp2ILInjected.Token(Token = "0x6000B8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD1D00", Offset = "0x1DD1D00", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override string ToString(float value)
		{
			throw null;
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00004E47 File Offset: 0x00003047
		[global::Cpp2ILInjected.Token(Token = "0x6000B8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD1DEC", Offset = "0x1DD1DEC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00004E4A File Offset: 0x0000304A
		[global::Cpp2ILInjected.Token(Token = "0x6000B8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD1EA0", Offset = "0x1DD1EA0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString(object value)
		{
			throw null;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00004E4D File Offset: 0x0000304D
		[global::Cpp2ILInjected.Token(Token = "0x6000B90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD1EB4", Offset = "0x1DD1EB4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override object ChangeType(bool value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00004E50 File Offset: 0x00003050
		[global::Cpp2ILInjected.Token(Token = "0x6000B91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD1F3C", Offset = "0x1DD1F3C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override object ChangeType(DateTime value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00004E53 File Offset: 0x00003053
		[global::Cpp2ILInjected.Token(Token = "0x6000B92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD1FC4", Offset = "0x1DD1FC4", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override object ChangeType(decimal value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00004E56 File Offset: 0x00003056
		[global::Cpp2ILInjected.Token(Token = "0x6000B93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2078", Offset = "0x1DD2078", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override object ChangeType(double value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00004E59 File Offset: 0x00003059
		[global::Cpp2ILInjected.Token(Token = "0x6000B94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2108", Offset = "0x1DD2108", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override object ChangeType(int value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00004E5C File Offset: 0x0000305C
		[global::Cpp2ILInjected.Token(Token = "0x6000B95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2190", Offset = "0x1DD2190", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override object ChangeType(long value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00004E5F File Offset: 0x0000305F
		[global::Cpp2ILInjected.Token(Token = "0x6000B96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2218", Offset = "0x1DD2218", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00004E62 File Offset: 0x00003062
		[global::Cpp2ILInjected.Token(Token = "0x6000B97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2228", Offset = "0x1DD2228", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override object ChangeType(object value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x00004E65 File Offset: 0x00003065
		[global::Cpp2ILInjected.Token(Token = "0x17000336")]
		protected XmlSchemaType SchemaType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B98")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DD223C", Offset = "0x1DD223C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x00004E68 File Offset: 0x00003068
		[global::Cpp2ILInjected.Token(Token = "0x17000337")]
		protected XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B99")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DD2244", Offset = "0x1DD2244", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00004E6B File Offset: 0x0000306B
		[global::Cpp2ILInjected.Token(Token = "0x17000338")]
		protected string XmlTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DD224C", Offset = "0x1DD224C", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "CreateInvalidClrMappingException", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeListType", MemberParameters = new object[]
			{
				typeof(object),
				typeof(Type),
				typeof(IXmlNamespaceResolver)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlListConverter), Member = "CreateInvalidClrMappingException", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x00004E6E File Offset: 0x0000306E
		[global::Cpp2ILInjected.Token(Token = "0x17000339")]
		protected Type DefaultClrType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DD2470", Offset = "0x1DD2470", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00004E71 File Offset: 0x00003071
		[global::Cpp2ILInjected.Token(Token = "0x6000B9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2478", Offset = "0x1DD2478", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected static bool IsDerivedFrom(Type derivedType, Type baseType)
		{
			throw null;
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00004E74 File Offset: 0x00003074
		[global::Cpp2ILInjected.Token(Token = "0x6000B9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2534", Offset = "0x1DD2534", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "ChangeListType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeListType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAnyConverter), Member = "ToNavigator", MemberParameters = new object[] { typeof(XPathNavigator) }, ReturnType = typeof(XPathNavigator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "get_XmlTypeName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00004E77 File Offset: 0x00003077
		[global::Cpp2ILInjected.Token(Token = "0x6000B9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2360", Offset = "0x1DD2360", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected static string QNameToString(XmlQualifiedName name)
		{
			throw null;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00004E7A File Offset: 0x0000307A
		[global::Cpp2ILInjected.Token(Token = "0x6000B9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2740", Offset = "0x1DD2740", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "CreateInvalidClrMappingException", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00004E7D File Offset: 0x0000307D
		[global::Cpp2ILInjected.Token(Token = "0x6000BA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2788", Offset = "0x1DD2788", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TrimString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected static byte[] StringToBase64Binary(string value)
		{
			throw null;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00004E80 File Offset: 0x00003080
		[global::Cpp2ILInjected.Token(Token = "0x6000BA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2818", Offset = "0x1DD2818", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTime StringToDate(string value)
		{
			throw null;
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00004E83 File Offset: 0x00003083
		[global::Cpp2ILInjected.Token(Token = "0x6000BA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2894", Offset = "0x1DD2894", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTime StringToDateTime(string value)
		{
			throw null;
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00004E86 File Offset: 0x00003086
		[global::Cpp2ILInjected.Token(Token = "0x6000BA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2910", Offset = "0x1DD2910", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDuration.DurationType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = "ToTimeSpan", MemberParameters = new object[] { typeof(XsdDuration.DurationType) }, ReturnType = typeof(TimeSpan))]
		protected static TimeSpan StringToDayTimeDuration(string value)
		{
			throw null;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00004E89 File Offset: 0x00003089
		[global::Cpp2ILInjected.Token(Token = "0x6000BA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2970", Offset = "0x1DD2970", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDuration.DurationType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = "ToTimeSpan", MemberParameters = new object[] { typeof(XsdDuration.DurationType) }, ReturnType = typeof(TimeSpan))]
		protected static TimeSpan StringToDuration(string value)
		{
			throw null;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00004E8C File Offset: 0x0000308C
		[global::Cpp2ILInjected.Token(Token = "0x6000BA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD29D0", Offset = "0x1DD29D0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTime StringToGDay(string value)
		{
			throw null;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00004E8F File Offset: 0x0000308F
		[global::Cpp2ILInjected.Token(Token = "0x6000BA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2A4C", Offset = "0x1DD2A4C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTime StringToGMonth(string value)
		{
			throw null;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00004E92 File Offset: 0x00003092
		[global::Cpp2ILInjected.Token(Token = "0x6000BA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2AC8", Offset = "0x1DD2AC8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTime StringToGMonthDay(string value)
		{
			throw null;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00004E95 File Offset: 0x00003095
		[global::Cpp2ILInjected.Token(Token = "0x6000BA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2B44", Offset = "0x1DD2B44", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTime StringToGYear(string value)
		{
			throw null;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00004E98 File Offset: 0x00003098
		[global::Cpp2ILInjected.Token(Token = "0x6000BA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2BC0", Offset = "0x1DD2BC0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTime StringToGYearMonth(string value)
		{
			throw null;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00004E9B File Offset: 0x0000309B
		[global::Cpp2ILInjected.Token(Token = "0x6000BAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2C3C", Offset = "0x1DD2C3C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTimeOffset StringToDateOffset(string value)
		{
			throw null;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00004E9E File Offset: 0x0000309E
		[global::Cpp2ILInjected.Token(Token = "0x6000BAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2CB8", Offset = "0x1DD2CB8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTimeOffset StringToDateTimeOffset(string value)
		{
			throw null;
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00004EA1 File Offset: 0x000030A1
		[global::Cpp2ILInjected.Token(Token = "0x6000BAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2D34", Offset = "0x1DD2D34", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTimeOffset StringToGDayOffset(string value)
		{
			throw null;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00004EA4 File Offset: 0x000030A4
		[global::Cpp2ILInjected.Token(Token = "0x6000BAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2DB0", Offset = "0x1DD2DB0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTimeOffset StringToGMonthOffset(string value)
		{
			throw null;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00004EA7 File Offset: 0x000030A7
		[global::Cpp2ILInjected.Token(Token = "0x6000BAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2E2C", Offset = "0x1DD2E2C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTimeOffset StringToGMonthDayOffset(string value)
		{
			throw null;
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00004EAA File Offset: 0x000030AA
		[global::Cpp2ILInjected.Token(Token = "0x6000BAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2EA8", Offset = "0x1DD2EA8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTimeOffset StringToGYearOffset(string value)
		{
			throw null;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00004EAD File Offset: 0x000030AD
		[global::Cpp2ILInjected.Token(Token = "0x6000BB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2F24", Offset = "0x1DD2F24", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTimeOffset StringToGYearMonthOffset(string value)
		{
			throw null;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00004EB0 File Offset: 0x000030B0
		[global::Cpp2ILInjected.Token(Token = "0x6000BB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD2FA0", Offset = "0x1DD2FA0", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TrimString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "FromBinHexString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		protected static byte[] StringToHexBinary(string value)
		{
			throw null;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00004EB3 File Offset: 0x000030B3
		[global::Cpp2ILInjected.Token(Token = "0x6000BB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD30CC", Offset = "0x1DD30CC", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidateNames), Member = "ParseQNameThrow", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00004EB6 File Offset: 0x000030B6
		[global::Cpp2ILInjected.Token(Token = "0x6000BB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD334C", Offset = "0x1DD334C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTime StringToTime(string value)
		{
			throw null;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00004EB9 File Offset: 0x000030B9
		[global::Cpp2ILInjected.Token(Token = "0x6000BB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD33C8", Offset = "0x1DD33C8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTimeOffset StringToTimeOffset(string value)
		{
			throw null;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00004EBC File Offset: 0x000030BC
		[global::Cpp2ILInjected.Token(Token = "0x6000BB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD3444", Offset = "0x1DD3444", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDuration.DurationType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = "ToTimeSpan", MemberParameters = new object[] { typeof(XsdDuration.DurationType) }, ReturnType = typeof(TimeSpan))]
		protected static TimeSpan StringToYearMonthDuration(string value)
		{
			throw null;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00004EBF File Offset: 0x000030BF
		[global::Cpp2ILInjected.Token(Token = "0x6000BB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD34A4", Offset = "0x1DD34A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		protected static string AnyUriToString(Uri value)
		{
			throw null;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00004EC2 File Offset: 0x000030C2
		[global::Cpp2ILInjected.Token(Token = "0x6000BB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD34AC", Offset = "0x1DD34AC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static string Base64BinaryToString(byte[] value)
		{
			throw null;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00004EC5 File Offset: 0x000030C5
		[global::Cpp2ILInjected.Token(Token = "0x6000BB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD3504", Offset = "0x1DD3504", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		protected static string DateToString(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00004EC8 File Offset: 0x000030C8
		[global::Cpp2ILInjected.Token(Token = "0x6000BB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD3548", Offset = "0x1DD3548", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		protected static string DateTimeToString(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00004ECB File Offset: 0x000030CB
		[global::Cpp2ILInjected.Token(Token = "0x6000BBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD358C", Offset = "0x1DD358C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(XsdDuration.DurationType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = "ToString", MemberParameters = new object[] { typeof(XsdDuration.DurationType) }, ReturnType = typeof(string))]
		protected static string DayTimeDurationToString(TimeSpan value)
		{
			throw null;
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00004ECE File Offset: 0x000030CE
		[global::Cpp2ILInjected.Token(Token = "0x6000BBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD35EC", Offset = "0x1DD35EC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(XsdDuration.DurationType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = "ToString", MemberParameters = new object[] { typeof(XsdDuration.DurationType) }, ReturnType = typeof(string))]
		protected static string DurationToString(TimeSpan value)
		{
			throw null;
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00004ED1 File Offset: 0x000030D1
		[global::Cpp2ILInjected.Token(Token = "0x6000BBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD364C", Offset = "0x1DD364C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		protected static string GDayToString(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00004ED4 File Offset: 0x000030D4
		[global::Cpp2ILInjected.Token(Token = "0x6000BBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD3690", Offset = "0x1DD3690", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		protected static string GMonthToString(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00004ED7 File Offset: 0x000030D7
		[global::Cpp2ILInjected.Token(Token = "0x6000BBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD36D4", Offset = "0x1DD36D4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		protected static string GMonthDayToString(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00004EDA File Offset: 0x000030DA
		[global::Cpp2ILInjected.Token(Token = "0x6000BBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD3718", Offset = "0x1DD3718", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		protected static string GYearToString(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00004EDD File Offset: 0x000030DD
		[global::Cpp2ILInjected.Token(Token = "0x6000BC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD375C", Offset = "0x1DD375C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		protected static string GYearMonthToString(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00004EE0 File Offset: 0x000030E0
		[global::Cpp2ILInjected.Token(Token = "0x6000BC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD37A0", Offset = "0x1DD37A0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTimeOffset),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		protected static string DateOffsetToString(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00004EE3 File Offset: 0x000030E3
		[global::Cpp2ILInjected.Token(Token = "0x6000BC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD37E8", Offset = "0x1DD37E8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTimeOffset),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		protected static string DateTimeOffsetToString(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00004EE6 File Offset: 0x000030E6
		[global::Cpp2ILInjected.Token(Token = "0x6000BC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD3830", Offset = "0x1DD3830", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTimeOffset),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		protected static string GDayOffsetToString(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00004EE9 File Offset: 0x000030E9
		[global::Cpp2ILInjected.Token(Token = "0x6000BC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD3878", Offset = "0x1DD3878", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTimeOffset),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		protected static string GMonthOffsetToString(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00004EEC File Offset: 0x000030EC
		[global::Cpp2ILInjected.Token(Token = "0x6000BC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD38C0", Offset = "0x1DD38C0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTimeOffset),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		protected static string GMonthDayOffsetToString(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00004EEF File Offset: 0x000030EF
		[global::Cpp2ILInjected.Token(Token = "0x6000BC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD3908", Offset = "0x1DD3908", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTimeOffset),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		protected static string GYearOffsetToString(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00004EF2 File Offset: 0x000030F2
		[global::Cpp2ILInjected.Token(Token = "0x6000BC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD3950", Offset = "0x1DD3950", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTimeOffset),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		protected static string GYearMonthOffsetToString(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00004EF5 File Offset: 0x000030F5
		[global::Cpp2ILInjected.Token(Token = "0x6000BC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD3998", Offset = "0x1DD3998", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00004EF8 File Offset: 0x000030F8
		[global::Cpp2ILInjected.Token(Token = "0x6000BC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD3B6C", Offset = "0x1DD3B6C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		protected static string TimeToString(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00004EFB File Offset: 0x000030FB
		[global::Cpp2ILInjected.Token(Token = "0x6000BCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD3BB0", Offset = "0x1DD3BB0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTimeOffset),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		protected static string TimeOffsetToString(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00004EFE File Offset: 0x000030FE
		[global::Cpp2ILInjected.Token(Token = "0x6000BCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD3BF8", Offset = "0x1DD3BF8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(XsdDuration.DurationType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = "ToString", MemberParameters = new object[] { typeof(XsdDuration.DurationType) }, ReturnType = typeof(string))]
		protected static string YearMonthDurationToString(TimeSpan value)
		{
			throw null;
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00004F01 File Offset: 0x00003101
		[global::Cpp2ILInjected.Token(Token = "0x6000BCC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD3C58", Offset = "0x1DD3C58", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_LocalDateTime", ReturnType = typeof(DateTime))]
		internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00004F04 File Offset: 0x00003104
		[global::Cpp2ILInjected.Token(Token = "0x6000BCD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD3C7C", Offset = "0x1DD3C7C", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt32", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal static int DecimalToInt32(decimal value)
		{
			throw null;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00004F07 File Offset: 0x00003107
		[global::Cpp2ILInjected.Token(Token = "0x6000BCE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD3E50", Offset = "0x1DD3E50", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt64", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt64", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		protected static long DecimalToInt64(decimal value)
		{
			throw null;
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00004F0A File Offset: 0x0000310A
		[global::Cpp2ILInjected.Token(Token = "0x6000BCF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD4024", Offset = "0x1DD4024", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		protected static ulong DecimalToUInt64(decimal value)
		{
			throw null;
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00004F0D File Offset: 0x0000310D
		[global::Cpp2ILInjected.Token(Token = "0x6000BD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD41EC", Offset = "0x1DD41EC", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected static byte Int32ToByte(int value)
		{
			throw null;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00004F10 File Offset: 0x00003110
		[global::Cpp2ILInjected.Token(Token = "0x6000BD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD42CC", Offset = "0x1DD42CC", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected static short Int32ToInt16(int value)
		{
			throw null;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00004F13 File Offset: 0x00003113
		[global::Cpp2ILInjected.Token(Token = "0x6000BD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD43AC", Offset = "0x1DD43AC", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected static sbyte Int32ToSByte(int value)
		{
			throw null;
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00004F16 File Offset: 0x00003116
		[global::Cpp2ILInjected.Token(Token = "0x6000BD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD448C", Offset = "0x1DD448C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected static ushort Int32ToUInt16(int value)
		{
			throw null;
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00004F19 File Offset: 0x00003119
		[global::Cpp2ILInjected.Token(Token = "0x6000BD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD456C", Offset = "0x1DD456C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt32", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt32", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(long),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected static int Int64ToInt32(long value)
		{
			throw null;
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00004F1C File Offset: 0x0000311C
		[global::Cpp2ILInjected.Token(Token = "0x6000BD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD464C", Offset = "0x1DD464C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected static uint Int64ToUInt32(long value)
		{
			throw null;
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00004F1F File Offset: 0x0000311F
		[global::Cpp2ILInjected.Token(Token = "0x6000BD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD472C", Offset = "0x1DD472C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDateTime", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTime UntypedAtomicToDateTime(string value)
		{
			throw null;
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00004F22 File Offset: 0x00003122
		[global::Cpp2ILInjected.Token(Token = "0x6000BD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD47A8", Offset = "0x1DD47A8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDateTimeOffset", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new object[] { typeof(XsdDateTime) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value)
		{
			throw null;
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00004F25 File Offset: 0x00003125
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000BD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DD4824", Offset = "0x1DD4824", Length = "0x588")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		static XmlBaseConverter()
		{
			throw null;
		}

		// Token: 0x04000475 RID: 1141
		[global::Cpp2ILInjected.Token(Token = "0x4000608")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlSchemaType schemaType;

		// Token: 0x04000476 RID: 1142
		[global::Cpp2ILInjected.Token(Token = "0x4000609")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlTypeCode typeCode;

		// Token: 0x04000477 RID: 1143
		[global::Cpp2ILInjected.Token(Token = "0x400060A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Type clrTypeDefault;

		// Token: 0x04000478 RID: 1144
		[global::Cpp2ILInjected.Token(Token = "0x400060B")]
		protected static readonly Type ICollectionType;

		// Token: 0x04000479 RID: 1145
		[global::Cpp2ILInjected.Token(Token = "0x400060C")]
		protected static readonly Type IEnumerableType;

		// Token: 0x0400047A RID: 1146
		[global::Cpp2ILInjected.Token(Token = "0x400060D")]
		protected static readonly Type IListType;

		// Token: 0x0400047B RID: 1147
		[global::Cpp2ILInjected.Token(Token = "0x400060E")]
		protected static readonly Type ObjectArrayType;

		// Token: 0x0400047C RID: 1148
		[global::Cpp2ILInjected.Token(Token = "0x400060F")]
		protected static readonly Type StringArrayType;

		// Token: 0x0400047D RID: 1149
		[global::Cpp2ILInjected.Token(Token = "0x4000610")]
		protected static readonly Type XmlAtomicValueArrayType;

		// Token: 0x0400047E RID: 1150
		[global::Cpp2ILInjected.Token(Token = "0x4000611")]
		protected static readonly Type DecimalType;

		// Token: 0x0400047F RID: 1151
		[global::Cpp2ILInjected.Token(Token = "0x4000612")]
		protected static readonly Type Int32Type;

		// Token: 0x04000480 RID: 1152
		[global::Cpp2ILInjected.Token(Token = "0x4000613")]
		protected static readonly Type Int64Type;

		// Token: 0x04000481 RID: 1153
		[global::Cpp2ILInjected.Token(Token = "0x4000614")]
		protected static readonly Type StringType;

		// Token: 0x04000482 RID: 1154
		[global::Cpp2ILInjected.Token(Token = "0x4000615")]
		protected static readonly Type XmlAtomicValueType;

		// Token: 0x04000483 RID: 1155
		[global::Cpp2ILInjected.Token(Token = "0x4000616")]
		protected static readonly Type ObjectType;

		// Token: 0x04000484 RID: 1156
		[global::Cpp2ILInjected.Token(Token = "0x4000617")]
		protected static readonly Type ByteType;

		// Token: 0x04000485 RID: 1157
		[global::Cpp2ILInjected.Token(Token = "0x4000618")]
		protected static readonly Type Int16Type;

		// Token: 0x04000486 RID: 1158
		[global::Cpp2ILInjected.Token(Token = "0x4000619")]
		protected static readonly Type SByteType;

		// Token: 0x04000487 RID: 1159
		[global::Cpp2ILInjected.Token(Token = "0x400061A")]
		protected static readonly Type UInt16Type;

		// Token: 0x04000488 RID: 1160
		[global::Cpp2ILInjected.Token(Token = "0x400061B")]
		protected static readonly Type UInt32Type;

		// Token: 0x04000489 RID: 1161
		[global::Cpp2ILInjected.Token(Token = "0x400061C")]
		protected static readonly Type UInt64Type;

		// Token: 0x0400048A RID: 1162
		[global::Cpp2ILInjected.Token(Token = "0x400061D")]
		protected static readonly Type XPathItemType;

		// Token: 0x0400048B RID: 1163
		[global::Cpp2ILInjected.Token(Token = "0x400061E")]
		protected static readonly Type DoubleType;

		// Token: 0x0400048C RID: 1164
		[global::Cpp2ILInjected.Token(Token = "0x400061F")]
		protected static readonly Type SingleType;

		// Token: 0x0400048D RID: 1165
		[global::Cpp2ILInjected.Token(Token = "0x4000620")]
		protected static readonly Type DateTimeType;

		// Token: 0x0400048E RID: 1166
		[global::Cpp2ILInjected.Token(Token = "0x4000621")]
		protected static readonly Type DateTimeOffsetType;

		// Token: 0x0400048F RID: 1167
		[global::Cpp2ILInjected.Token(Token = "0x4000622")]
		protected static readonly Type BooleanType;

		// Token: 0x04000490 RID: 1168
		[global::Cpp2ILInjected.Token(Token = "0x4000623")]
		protected static readonly Type ByteArrayType;

		// Token: 0x04000491 RID: 1169
		[global::Cpp2ILInjected.Token(Token = "0x4000624")]
		protected static readonly Type XmlQualifiedNameType;

		// Token: 0x04000492 RID: 1170
		[global::Cpp2ILInjected.Token(Token = "0x4000625")]
		protected static readonly Type UriType;

		// Token: 0x04000493 RID: 1171
		[global::Cpp2ILInjected.Token(Token = "0x4000626")]
		protected static readonly Type TimeSpanType;

		// Token: 0x04000494 RID: 1172
		[global::Cpp2ILInjected.Token(Token = "0x4000627")]
		protected static readonly Type XPathNavigatorType;
	}
}
