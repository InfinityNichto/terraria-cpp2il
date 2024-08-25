using System;
using System.Xml.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x2000154")]
	public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
	{
		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		[global::Cpp2ILInjected.Token(Token = "0x1700032C")]
		public XmlSchemaSimpleType ItemType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B0B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCF084", Offset = "0x1DCF084", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x1700032D")]
		public XmlSchemaSimpleType BaseItemType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B0C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCF08C", Offset = "0x1DCF08C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B0D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCF094", Offset = "0x1DCF094", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF09C", Offset = "0x1DCF09C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "FinishBuiltinType", MemberParameters = new object[]
		{
			typeof(XmlSchemaSimpleType),
			typeof(XmlSchemaSimpleType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XmlSchemaSimpleTypeList()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40005B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlQualifiedName itemTypeName;

		[global::Cpp2ILInjected.Token(Token = "0x40005B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlSchemaSimpleType itemType;

		[global::Cpp2ILInjected.Token(Token = "0x40005B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XmlSchemaSimpleType baseItemType;
	}
}
