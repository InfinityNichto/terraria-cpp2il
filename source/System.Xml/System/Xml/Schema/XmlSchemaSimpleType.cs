using System;
using System.Xml.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x0200011E RID: 286
	[global::Cpp2ILInjected.Token(Token = "0x2000152")]
	public class XmlSchemaSimpleType : XmlSchemaType
	{
		// Token: 0x06000A6C RID: 2668 RVA: 0x00004D60 File Offset: 0x00002F60
		[global::Cpp2ILInjected.Token(Token = "0x6000B07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF068", Offset = "0x1DCF068", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(XmlSchemaDatatype)
		}, ReturnType = typeof(XmlSchemaSimpleType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = ".ctor", ReturnType = typeof(void))]
		public XmlSchemaSimpleType()
		{
			throw null;
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00004D63 File Offset: 0x00002F63
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x00004D66 File Offset: 0x00002F66
		[XmlElement("restriction", typeof(XmlSchemaSimpleTypeRestriction))]
		[XmlElement("list", typeof(XmlSchemaSimpleTypeList))]
		[XmlElement("union", typeof(XmlSchemaSimpleTypeUnion))]
		[global::Cpp2ILInjected.Token(Token = "0x1700032B")]
		public XmlSchemaSimpleTypeContent Content
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B08")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCF06C", Offset = "0x1DCF06C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B09")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCF074", Offset = "0x1DCF074", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000422 RID: 1058
		[global::Cpp2ILInjected.Token(Token = "0x40005B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private XmlSchemaSimpleTypeContent content;
	}
}
