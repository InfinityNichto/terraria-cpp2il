using System;
using Cpp2ILInjected;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x200001B")]
	internal interface IDtdParser
	{
		[global::Cpp2ILInjected.Token(Token = "0x600008E")]
		IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset);

		[global::Cpp2ILInjected.Token(Token = "0x600008F")]
		IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter);
	}
}
