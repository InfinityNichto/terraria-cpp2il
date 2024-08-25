using System;
using System.Collections.Generic;
using System.Xml;
using Cpp2ILInjected;

namespace Newtonsoft.Json.Converters
{
	[global::Cpp2ILInjected.Token(Token = "0x2000112")]
	internal interface IXmlNode
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001F5")]
		XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AB6")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001F6")]
		string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AB7")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001F7")]
		List<IXmlNode> ChildNodes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AB8")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001F8")]
		List<IXmlNode> Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AB9")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001F9")]
		IXmlNode ParentNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ABA")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001FA")]
		string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ABB")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000ABC")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ABD")]
		IXmlNode AppendChild(IXmlNode newChild);

		[global::Cpp2ILInjected.Token(Token = "0x170001FB")]
		string NamespaceUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ABE")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001FC")]
		object WrappedNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ABF")]
			get;
		}
	}
}
