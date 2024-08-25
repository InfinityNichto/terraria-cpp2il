using System;
using Cpp2ILInjected;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x200001D")]
	internal interface IDtdParserAdapterWithValidation : IDtdParserAdapter
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700002C")]
		bool DtdValidation
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A9")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700002D")]
		IValidationEventHandling ValidationEventHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AA")]
			get;
		}
	}
}
