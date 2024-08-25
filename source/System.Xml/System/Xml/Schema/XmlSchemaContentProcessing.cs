using System;
using System.Xml.Serialization;
using Cpp2ILInjected;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x2000142")]
	public enum XmlSchemaContentProcessing
	{
		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x400057F")]
		None,
		[XmlEnum("skip")]
		[global::Cpp2ILInjected.Token(Token = "0x4000580")]
		Skip,
		[XmlEnum("lax")]
		[global::Cpp2ILInjected.Token(Token = "0x4000581")]
		Lax,
		[XmlEnum("strict")]
		[global::Cpp2ILInjected.Token(Token = "0x4000582")]
		Strict
	}
}
