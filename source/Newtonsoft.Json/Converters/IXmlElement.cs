using System;
using Cpp2ILInjected;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000CA RID: 202
	[global::Cpp2ILInjected.Token(Token = "0x2000111")]
	internal interface IXmlElement : IXmlNode
	{
		// Token: 0x06000977 RID: 2423
		[global::Cpp2ILInjected.Token(Token = "0x6000AB3")]
		void SetAttributeNode(IXmlNode attribute);

		// Token: 0x06000978 RID: 2424
		[global::Cpp2ILInjected.Token(Token = "0x6000AB4")]
		string GetPrefixOfNamespace(string namespaceUri);

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000979 RID: 2425
		[global::Cpp2ILInjected.Token(Token = "0x170001F4")]
		bool IsEmpty
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AB5")]
			get;
		}
	}
}
