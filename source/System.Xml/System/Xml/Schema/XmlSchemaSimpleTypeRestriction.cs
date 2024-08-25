using System;
using System.Collections;
using System.Xml.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x2000155")]
	public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent
	{
		[XmlAttribute("base")]
		[global::Cpp2ILInjected.Token(Token = "0x1700032E")]
		public XmlQualifiedName BaseTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B0F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCF104", Offset = "0x1DCF104", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "FinishBuiltinType", MemberParameters = new object[]
			{
				typeof(XmlSchemaSimpleType),
				typeof(XmlSchemaSimpleType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(XmlQualifiedName),
				typeof(XmlQualifiedName)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF194", Offset = "0x1DCF194", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "FinishBuiltinType", MemberParameters = new object[]
		{
			typeof(XmlSchemaSimpleType),
			typeof(XmlSchemaSimpleType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public XmlSchemaSimpleTypeRestriction()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40005B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlQualifiedName baseTypeName;

		[global::Cpp2ILInjected.Token(Token = "0x40005BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlSchemaObjectCollection facets;
	}
}
