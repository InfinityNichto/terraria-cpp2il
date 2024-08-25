using System;
using System.Xml;
using Cpp2ILInjected;

namespace System.Configuration
{
	[global::Cpp2ILInjected.Token(Token = "0x2000452")]
	public interface IConfigurationSectionHandler
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001E02")]
		object Create(object parent, object configContext, XmlNode section);
	}
}
