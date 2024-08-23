using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x0200012C RID: 300
	[global::Cpp2ILInjected.Token(Token = "0x2000160")]
	internal class XmlDateTimeConverter : XmlBaseConverter
	{
		// Token: 0x06000B60 RID: 2912 RVA: 0x00004F8E File Offset: 0x0000318E
		[global::Cpp2ILInjected.Token(Token = "0x6000BFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDA4D8", Offset = "0x1DDA4D8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDateTimeConverter), Member = "Create", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected XmlDateTimeConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00004F91 File Offset: 0x00003191
		[global::Cpp2ILInjected.Token(Token = "0x6000BFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC0164", Offset = "0x1DC0164", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDateTimeConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00004F94 File Offset: 0x00003194
		[global::Cpp2ILInjected.Token(Token = "0x6000BFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDA53C", Offset = "0x1DDA53C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_LocalDateTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override DateTime ToDateTime(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00004F97 File Offset: 0x00003197
		[global::Cpp2ILInjected.Token(Token = "0x6000BFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDA5B0", Offset = "0x1DDA5B0", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToGMonthDay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToGYearMonth", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToDate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToGYear", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToGDay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToGMonth", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override DateTime ToDateTime(string value)
		{
			throw null;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00004F9A File Offset: 0x0000319A
		[global::Cpp2ILInjected.Token(Token = "0x6000BFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDA75C", Offset = "0x1DDA75C", Length = "0x350")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public override DateTime ToDateTime(object value)
		{
			throw null;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00004F9D File Offset: 0x0000319D
		[global::Cpp2ILInjected.Token(Token = "0x6000C00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDAAAC", Offset = "0x1DDAAAC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		public override DateTimeOffset ToDateTimeOffset(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00004FA0 File Offset: 0x000031A0
		[global::Cpp2ILInjected.Token(Token = "0x6000C01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDAAD4", Offset = "0x1DDAAD4", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToGMonthDayOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToGYearMonthOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToDateOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToGYearOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToGDayOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToGMonthOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override DateTimeOffset ToDateTimeOffset(string value)
		{
			throw null;
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00004FA3 File Offset: 0x000031A3
		[global::Cpp2ILInjected.Token(Token = "0x6000C02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDAC80", Offset = "0x1DDAC80", Length = "0x354")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "op_Implicit", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public override DateTimeOffset ToDateTimeOffset(object value)
		{
			throw null;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00004FA6 File Offset: 0x000031A6
		[global::Cpp2ILInjected.Token(Token = "0x6000C03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDAFD4", Offset = "0x1DDAFD4", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "TimeToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "DateTimeToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "DateToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "GYearMonthToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "GYearToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "GMonthDayToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "GDayToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "GMonthToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override string ToString(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00004FA9 File Offset: 0x000031A9
		[global::Cpp2ILInjected.Token(Token = "0x6000C04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDB134", Offset = "0x1DDB134", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "TimeOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "DateTimeOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "DateOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "GYearMonthOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "GYearOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "GMonthDayOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "GDayOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "GMonthOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override string ToString(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00004FAC File Offset: 0x000031AC
		[global::Cpp2ILInjected.Token(Token = "0x6000C05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDB2DC", Offset = "0x1DDB2DC", Length = "0x354")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00004FAF File Offset: 0x000031AF
		[global::Cpp2ILInjected.Token(Token = "0x6000C06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDB630", Offset = "0x1DDB630", Length = "0x388")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(DateTime)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public override object ChangeType(DateTime value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00004FB2 File Offset: 0x000031B2
		[global::Cpp2ILInjected.Token(Token = "0x6000C07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDB9B8", Offset = "0x1DDB9B8", Length = "0x39C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00004FB5 File Offset: 0x000031B5
		[global::Cpp2ILInjected.Token(Token = "0x6000C08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDBD54", Offset = "0x1DDBD54", Length = "0x6EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(DateTime)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}
	}
}
