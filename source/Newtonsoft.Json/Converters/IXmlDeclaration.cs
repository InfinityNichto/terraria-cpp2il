using System;
using Cpp2ILInjected;

namespace Newtonsoft.Json.Converters
{
	[global::Cpp2ILInjected.Token(Token = "0x200010F")]
	internal interface IXmlDeclaration : IXmlNode
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001ED")]
		string Version
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AAA")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001EE")]
		string Encoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AAB")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000AAC")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001EF")]
		string Standalone
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AAD")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000AAE")]
			set;
		}
	}
}
