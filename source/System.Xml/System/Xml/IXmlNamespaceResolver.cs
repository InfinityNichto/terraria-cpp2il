using System;
using Cpp2ILInjected;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x2000084")]
	public interface IXmlNamespaceResolver
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000637")]
		string LookupNamespace(string prefix);

		[global::Cpp2ILInjected.Token(Token = "0x6000638")]
		string LookupPrefix(string namespaceName);
	}
}
