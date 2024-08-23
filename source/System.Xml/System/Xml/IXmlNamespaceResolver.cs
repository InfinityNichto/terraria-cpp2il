using System;
using Cpp2ILInjected;

namespace System.Xml
{
	// Token: 0x02000065 RID: 101
	[global::Cpp2ILInjected.Token(Token = "0x2000084")]
	public interface IXmlNamespaceResolver
	{
		// Token: 0x060005B5 RID: 1461
		[global::Cpp2ILInjected.Token(Token = "0x6000637")]
		string LookupNamespace(string prefix);

		// Token: 0x060005B6 RID: 1462
		[global::Cpp2ILInjected.Token(Token = "0x6000638")]
		string LookupPrefix(string namespaceName);
	}
}
