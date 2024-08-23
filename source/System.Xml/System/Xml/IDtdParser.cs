using System;
using Cpp2ILInjected;

namespace System.Xml
{
	// Token: 0x0200001B RID: 27
	[global::Cpp2ILInjected.Token(Token = "0x200001B")]
	internal interface IDtdParser
	{
		// Token: 0x0600008E RID: 142
		[global::Cpp2ILInjected.Token(Token = "0x600008E")]
		IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset);

		// Token: 0x0600008F RID: 143
		[global::Cpp2ILInjected.Token(Token = "0x600008F")]
		IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter);
	}
}
