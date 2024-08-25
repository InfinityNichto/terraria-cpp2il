using System;
using Cpp2ILInjected;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x200001E")]
	internal interface IDtdParserAdapterV1 : IDtdParserAdapterWithValidation, IDtdParserAdapter
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700002E")]
		bool V1CompatibilityMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AB")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700002F")]
		bool Normalization
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AC")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000030")]
		bool Namespaces
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AD")]
			get;
		}
	}
}
