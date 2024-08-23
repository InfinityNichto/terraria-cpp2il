using System;
using System.Xml.Serialization;
using Cpp2ILInjected;

namespace System.Xml.Schema
{
	// Token: 0x02000113 RID: 275
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000145")]
	public enum XmlSchemaDerivationMethod
	{
		// Token: 0x040003FA RID: 1018
		[XmlEnum(null)]
		[global::Cpp2ILInjected.Token(Token = "0x4000589")]
		Empty = 0,
		// Token: 0x040003FB RID: 1019
		[XmlEnum("substitution")]
		[global::Cpp2ILInjected.Token(Token = "0x400058A")]
		Substitution = 1,
		// Token: 0x040003FC RID: 1020
		[XmlEnum("extension")]
		[global::Cpp2ILInjected.Token(Token = "0x400058B")]
		Extension = 2,
		// Token: 0x040003FD RID: 1021
		[XmlEnum("restriction")]
		[global::Cpp2ILInjected.Token(Token = "0x400058C")]
		Restriction = 4,
		// Token: 0x040003FE RID: 1022
		[XmlEnum("list")]
		[global::Cpp2ILInjected.Token(Token = "0x400058D")]
		List = 8,
		// Token: 0x040003FF RID: 1023
		[XmlEnum("union")]
		[global::Cpp2ILInjected.Token(Token = "0x400058E")]
		Union = 16,
		// Token: 0x04000400 RID: 1024
		[XmlEnum("#all")]
		[global::Cpp2ILInjected.Token(Token = "0x400058F")]
		All = 255,
		// Token: 0x04000401 RID: 1025
		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x4000590")]
		None = 256
	}
}
