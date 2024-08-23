using System;
using System.Xml.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x02000120 RID: 288
	[global::Cpp2ILInjected.Token(Token = "0x2000154")]
	public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
	{
		// Token: 0x17000306 RID: 774
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x00004D6C File Offset: 0x00002F6C
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

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00004D6F File Offset: 0x00002F6F
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x00004D72 File Offset: 0x00002F72
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

		// Token: 0x06000A73 RID: 2675 RVA: 0x00004D75 File Offset: 0x00002F75
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

		// Token: 0x04000423 RID: 1059
		[global::Cpp2ILInjected.Token(Token = "0x40005B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlQualifiedName itemTypeName;

		// Token: 0x04000424 RID: 1060
		[global::Cpp2ILInjected.Token(Token = "0x40005B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlSchemaSimpleType itemType;

		// Token: 0x04000425 RID: 1061
		[global::Cpp2ILInjected.Token(Token = "0x40005B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XmlSchemaSimpleType baseItemType;
	}
}
