using System;
using Cpp2ILInjected;

namespace System.Xml
{
	// Token: 0x0200001D RID: 29
	[global::Cpp2ILInjected.Token(Token = "0x200001D")]
	internal interface IDtdParserAdapterWithValidation : IDtdParserAdapter
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A9 RID: 169
		[global::Cpp2ILInjected.Token(Token = "0x1700002C")]
		bool DtdValidation
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A9")]
			get;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000AA RID: 170
		[global::Cpp2ILInjected.Token(Token = "0x1700002D")]
		IValidationEventHandling ValidationEventHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AA")]
			get;
		}
	}
}
