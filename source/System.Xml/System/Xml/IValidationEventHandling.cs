using System;
using System.Xml.Schema;
using Cpp2ILInjected;

namespace System.Xml
{
	// Token: 0x02000020 RID: 32
	[global::Cpp2ILInjected.Token(Token = "0x2000020")]
	internal interface IValidationEventHandling
	{
		// Token: 0x060000B0 RID: 176
		[global::Cpp2ILInjected.Token(Token = "0x60000B0")]
		void SendEvent(Exception exception, XmlSeverityType severity);
	}
}
