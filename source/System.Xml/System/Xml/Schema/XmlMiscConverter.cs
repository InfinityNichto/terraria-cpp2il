using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x0200012E RID: 302
	[global::Cpp2ILInjected.Token(Token = "0x2000162")]
	internal class XmlMiscConverter : XmlBaseConverter
	{
		// Token: 0x06000B77 RID: 2935 RVA: 0x00004FD3 File Offset: 0x000031D3
		[global::Cpp2ILInjected.Token(Token = "0x6000C12")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDE714", Offset = "0x1DDE714", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "Create", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected XmlMiscConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00004FD6 File Offset: 0x000031D6
		[global::Cpp2ILInjected.Token(Token = "0x6000C13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDE77C", Offset = "0x1DDE77C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_duration), Member = "CreateValueConverter", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_hexBinary), Member = "CreateValueConverter", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_base64Binary), Member = "CreateValueConverter", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_anyURI), Member = "CreateValueConverter", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_QName), Member = "CreateValueConverter", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_NOTATION), Member = "CreateValueConverter", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlMiscConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00004FD9 File Offset: 0x000031D9
		[global::Cpp2ILInjected.Token(Token = "0x6000C14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDE7D4", Offset = "0x1DDE7D4", Length = "0x548")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "Base64BinaryToString", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "IsDerivedFrom", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "AnyUriToString", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "DayTimeDurationToString", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToBinHexString", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "QNameToString", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlMiscConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "YearMonthDurationToString", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "DurationToString", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00004FDC File Offset: 0x000031DC
		[global::Cpp2ILInjected.Token(Token = "0x6000C15")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDEE54", Offset = "0x1DDEE54", Length = "0x504")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToBase64Binary", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToQName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToDayTimeDuration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToHexBinary", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(string),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToYearMonthDuration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToDuration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00004FDF File Offset: 0x000031DF
		[global::Cpp2ILInjected.Token(Token = "0x6000C16")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDF4BC", Offset = "0x1DDF4BC", Length = "0xCEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToBase64Binary", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToQName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "IsDerivedFrom", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToDayTimeDuration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(string),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToHexBinary", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToYearMonthDuration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = "StringToDuration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 82)]
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00004FE2 File Offset: 0x000031E2
		[global::Cpp2ILInjected.Token(Token = "0x6000C17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDED1C", Offset = "0x1DDED1C", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00004FE5 File Offset: 0x000031E5
		[global::Cpp2ILInjected.Token(Token = "0x6000C18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDF358", Offset = "0x1DDF358", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}
	}
}
