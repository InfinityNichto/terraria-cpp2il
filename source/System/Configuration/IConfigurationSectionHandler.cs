using System;
using System.Xml;
using Cpp2ILInjected;

namespace System.Configuration
{
	// Token: 0x0200031E RID: 798
	[global::Cpp2ILInjected.Token(Token = "0x2000452")]
	public interface IConfigurationSectionHandler
	{
		// Token: 0x06001AA9 RID: 6825
		[global::Cpp2ILInjected.Token(Token = "0x6001E02")]
		object Create(object parent, object configContext, XmlNode section);
	}
}
