using System;
using System.Xml.Schema;
using Cpp2ILInjected;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x2000020")]
	internal interface IValidationEventHandling
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000B0")]
		void SendEvent(Exception exception, XmlSeverityType severity);
	}
}
