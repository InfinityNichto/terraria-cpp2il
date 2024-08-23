using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x0200012D RID: 301
	[global::Cpp2ILInjected.Token(Token = "0x2000161")]
	internal class XmlBooleanConverter : XmlBaseConverter
	{
		// Token: 0x06000B6E RID: 2926 RVA: 0x00004FB8 File Offset: 0x000031B8
		[global::Cpp2ILInjected.Token(Token = "0x6000C09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDC440", Offset = "0x1DDC440", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBooleanConverter), Member = "Create", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected XmlBooleanConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00004FBB File Offset: 0x000031BB
		[global::Cpp2ILInjected.Token(Token = "0x6000C0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBE62C", Offset = "0x1DBE62C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBooleanConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00004FBE File Offset: 0x000031BE
		[global::Cpp2ILInjected.Token(Token = "0x6000C0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDC4A4", Offset = "0x1DDC4A4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool ToBoolean(string value)
		{
			throw null;
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00004FC1 File Offset: 0x000031C1
		[global::Cpp2ILInjected.Token(Token = "0x6000C0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDC548", Offset = "0x1DDC548", Length = "0x2D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override bool ToBoolean(object value)
		{
			throw null;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00004FC4 File Offset: 0x000031C4
		[global::Cpp2ILInjected.Token(Token = "0x6000C0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDC818", Offset = "0x1DDC818", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString(bool value)
		{
			throw null;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00004FC7 File Offset: 0x000031C7
		[global::Cpp2ILInjected.Token(Token = "0x6000C0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDC870", Offset = "0x1DDC870", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00004FCA File Offset: 0x000031CA
		[global::Cpp2ILInjected.Token(Token = "0x6000C0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDCB38", Offset = "0x1DDCB38", Length = "0x320")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public override object ChangeType(bool value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00004FCD File Offset: 0x000031CD
		[global::Cpp2ILInjected.Token(Token = "0x6000C10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDCE58", Offset = "0x1DDCE58", Length = "0x330")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00004FD0 File Offset: 0x000031D0
		[global::Cpp2ILInjected.Token(Token = "0x6000C11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DDD188", Offset = "0x1DDD188", Length = "0x158C")]
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
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}
	}
}
