using System;
using System.Collections;
using System.Xml.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x0200011C RID: 284
	[global::Cpp2ILInjected.Token(Token = "0x2000150")]
	public class XmlSchemaSequence : XmlSchemaGroupBase
	{
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00004D51 File Offset: 0x00002F51
		[XmlElement("element", typeof(XmlSchemaElement))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		[XmlElement("any", typeof(XmlSchemaAny))]
		[XmlElement("group", typeof(XmlSchemaGroupRef))]
		[global::Cpp2ILInjected.Token(Token = "0x1700032A")]
		public override XmlSchemaObjectCollection Items
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B02")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCED70", Offset = "0x1DCED70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00004D54 File Offset: 0x00002F54
		[global::Cpp2ILInjected.Token(Token = "0x6000B03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCDB7C", Offset = "0x1DCDB7C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaGroupBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XmlSchemaSequence()
		{
			throw null;
		}

		// Token: 0x04000416 RID: 1046
		[global::Cpp2ILInjected.Token(Token = "0x40005A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private XmlSchemaObjectCollection items;
	}
}
