using System;
using Cpp2ILInjected;

namespace Newtonsoft.Json.Converters
{
	[global::Cpp2ILInjected.Token(Token = "0x200010E")]
	internal interface IXmlDocument : IXmlNode
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A9D")]
		IXmlNode CreateComment(string text);

		[global::Cpp2ILInjected.Token(Token = "0x6000A9E")]
		IXmlNode CreateTextNode(string text);

		[global::Cpp2ILInjected.Token(Token = "0x6000A9F")]
		IXmlNode CreateCDataSection(string data);

		[global::Cpp2ILInjected.Token(Token = "0x6000AA0")]
		IXmlNode CreateWhitespace(string text);

		[global::Cpp2ILInjected.Token(Token = "0x6000AA1")]
		IXmlNode CreateSignificantWhitespace(string text);

		[global::Cpp2ILInjected.Token(Token = "0x6000AA2")]
		IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

		[global::Cpp2ILInjected.Token(Token = "0x6000AA3")]
		IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);

		[global::Cpp2ILInjected.Token(Token = "0x6000AA4")]
		IXmlNode CreateProcessingInstruction(string target, string data);

		[global::Cpp2ILInjected.Token(Token = "0x6000AA5")]
		IXmlElement CreateElement(string elementName);

		[global::Cpp2ILInjected.Token(Token = "0x6000AA6")]
		IXmlElement CreateElement(string qualifiedName, string namespaceUri);

		[global::Cpp2ILInjected.Token(Token = "0x6000AA7")]
		IXmlNode CreateAttribute(string name, string value);

		[global::Cpp2ILInjected.Token(Token = "0x6000AA8")]
		IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);

		[global::Cpp2ILInjected.Token(Token = "0x170001EC")]
		IXmlElement DocumentElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AA9")]
			get;
		}
	}
}
