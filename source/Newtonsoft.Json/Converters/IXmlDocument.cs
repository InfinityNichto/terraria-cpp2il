using System;
using Cpp2ILInjected;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000C7 RID: 199
	[global::Cpp2ILInjected.Token(Token = "0x200010E")]
	internal interface IXmlDocument : IXmlNode
	{
		// Token: 0x06000961 RID: 2401
		[global::Cpp2ILInjected.Token(Token = "0x6000A9D")]
		IXmlNode CreateComment(string text);

		// Token: 0x06000962 RID: 2402
		[global::Cpp2ILInjected.Token(Token = "0x6000A9E")]
		IXmlNode CreateTextNode(string text);

		// Token: 0x06000963 RID: 2403
		[global::Cpp2ILInjected.Token(Token = "0x6000A9F")]
		IXmlNode CreateCDataSection(string data);

		// Token: 0x06000964 RID: 2404
		[global::Cpp2ILInjected.Token(Token = "0x6000AA0")]
		IXmlNode CreateWhitespace(string text);

		// Token: 0x06000965 RID: 2405
		[global::Cpp2ILInjected.Token(Token = "0x6000AA1")]
		IXmlNode CreateSignificantWhitespace(string text);

		// Token: 0x06000966 RID: 2406
		[global::Cpp2ILInjected.Token(Token = "0x6000AA2")]
		IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

		// Token: 0x06000967 RID: 2407
		[global::Cpp2ILInjected.Token(Token = "0x6000AA3")]
		IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);

		// Token: 0x06000968 RID: 2408
		[global::Cpp2ILInjected.Token(Token = "0x6000AA4")]
		IXmlNode CreateProcessingInstruction(string target, string data);

		// Token: 0x06000969 RID: 2409
		[global::Cpp2ILInjected.Token(Token = "0x6000AA5")]
		IXmlElement CreateElement(string elementName);

		// Token: 0x0600096A RID: 2410
		[global::Cpp2ILInjected.Token(Token = "0x6000AA6")]
		IXmlElement CreateElement(string qualifiedName, string namespaceUri);

		// Token: 0x0600096B RID: 2411
		[global::Cpp2ILInjected.Token(Token = "0x6000AA7")]
		IXmlNode CreateAttribute(string name, string value);

		// Token: 0x0600096C RID: 2412
		[global::Cpp2ILInjected.Token(Token = "0x6000AA8")]
		IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600096D RID: 2413
		[global::Cpp2ILInjected.Token(Token = "0x170001EC")]
		IXmlElement DocumentElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AA9")]
			get;
		}
	}
}
