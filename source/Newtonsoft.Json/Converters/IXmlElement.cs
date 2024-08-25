using System;
using Cpp2ILInjected;

namespace Newtonsoft.Json.Converters
{
	[global::Cpp2ILInjected.Token(Token = "0x2000111")]
	internal interface IXmlElement : IXmlNode
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000AB3")]
		void SetAttributeNode(IXmlNode attribute);

		[global::Cpp2ILInjected.Token(Token = "0x6000AB4")]
		string GetPrefixOfNamespace(string namespaceUri);

		[global::Cpp2ILInjected.Token(Token = "0x170001F4")]
		bool IsEmpty
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AB5")]
			get;
		}
	}
}
