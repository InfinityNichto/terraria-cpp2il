using System;
using System.Xml.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x200013F")]
	public class XmlSchemaChoice : XmlSchemaGroupBase
	{
		[XmlElement("any", typeof(XmlSchemaAny))]
		[XmlElement("group", typeof(XmlSchemaGroupRef))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		[XmlElement("element", typeof(XmlSchemaElement))]
		[global::Cpp2ILInjected.Token(Token = "0x17000311")]
		public override XmlSchemaObjectCollection Items
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AC1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCD344", Offset = "0x1DCD344", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000575")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private XmlSchemaObjectCollection items;
	}
}
