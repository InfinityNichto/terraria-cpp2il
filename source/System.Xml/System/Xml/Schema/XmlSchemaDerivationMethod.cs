using System;
using System.Xml.Serialization;
using Cpp2ILInjected;

namespace System.Xml.Schema
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000145")]
	public enum XmlSchemaDerivationMethod
	{
		[XmlEnum(null)]
		[global::Cpp2ILInjected.Token(Token = "0x4000589")]
		Empty = 0,
		[XmlEnum("substitution")]
		[global::Cpp2ILInjected.Token(Token = "0x400058A")]
		Substitution = 1,
		[XmlEnum("extension")]
		[global::Cpp2ILInjected.Token(Token = "0x400058B")]
		Extension = 2,
		[XmlEnum("restriction")]
		[global::Cpp2ILInjected.Token(Token = "0x400058C")]
		Restriction = 4,
		[XmlEnum("list")]
		[global::Cpp2ILInjected.Token(Token = "0x400058D")]
		List = 8,
		[XmlEnum("union")]
		[global::Cpp2ILInjected.Token(Token = "0x400058E")]
		Union = 16,
		[XmlEnum("#all")]
		[global::Cpp2ILInjected.Token(Token = "0x400058F")]
		All = 255,
		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x4000590")]
		None = 256
	}
}
