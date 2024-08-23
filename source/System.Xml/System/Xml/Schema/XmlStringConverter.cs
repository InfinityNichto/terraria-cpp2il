using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x0200012F RID: 303
	[global::Cpp2ILInjected.Token(Token = "0x2000163")]
	internal class XmlStringConverter : XmlBaseConverter
	{
		// Token: 0x06000B7E RID: 2942 RVA: 0x00004FE8 File Offset: 0x000031E8
		[global::Cpp2ILInjected.Token(Token = "0x6000C19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE01A8", Offset = "0x1DE01A8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlStringConverter), Member = "Create", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlBaseConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected XmlStringConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00004FEB File Offset: 0x000031EB
		[global::Cpp2ILInjected.Token(Token = "0x6000C1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE0210", Offset = "0x1DE0210", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_string), Member = "CreateValueConverter", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlStringConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00004FEE File Offset: 0x000031EE
		[global::Cpp2ILInjected.Token(Token = "0x6000C1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE0268", Offset = "0x1DE0268", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00004FF1 File Offset: 0x000031F1
		[global::Cpp2ILInjected.Token(Token = "0x6000C1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE0474", Offset = "0x1DE0474", Length = "0x28C")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00004FF4 File Offset: 0x000031F4
		[global::Cpp2ILInjected.Token(Token = "0x6000C1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DE0700", Offset = "0x1DE0700", Length = "0x42C")]
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
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}
	}
}
