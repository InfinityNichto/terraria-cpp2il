using System;
using System.Xml.Serialization;
using Cpp2ILInjected;

namespace System.Xml.Schema
{
	// Token: 0x02000110 RID: 272
	[global::Cpp2ILInjected.Token(Token = "0x2000142")]
	public enum XmlSchemaContentProcessing
	{
		// Token: 0x040003F0 RID: 1008
		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x400057F")]
		None,
		// Token: 0x040003F1 RID: 1009
		[XmlEnum("skip")]
		[global::Cpp2ILInjected.Token(Token = "0x4000580")]
		Skip,
		// Token: 0x040003F2 RID: 1010
		[XmlEnum("lax")]
		[global::Cpp2ILInjected.Token(Token = "0x4000581")]
		Lax,
		// Token: 0x040003F3 RID: 1011
		[XmlEnum("strict")]
		[global::Cpp2ILInjected.Token(Token = "0x4000582")]
		Strict
	}
}
