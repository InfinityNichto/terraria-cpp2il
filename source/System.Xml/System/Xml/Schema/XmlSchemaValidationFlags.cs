using System;
using Cpp2ILInjected;

namespace System.Xml.Schema
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000158")]
	public enum XmlSchemaValidationFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x40005C3")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40005C4")]
		ProcessInlineSchema = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40005C5")]
		ProcessSchemaLocation = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40005C6")]
		ReportValidationWarnings = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40005C7")]
		ProcessIdentityConstraints = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40005C8")]
		AllowXmlAttributes = 16
	}
}
