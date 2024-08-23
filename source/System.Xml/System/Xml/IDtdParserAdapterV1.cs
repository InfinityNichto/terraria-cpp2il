using System;
using Cpp2ILInjected;

namespace System.Xml
{
	// Token: 0x0200001E RID: 30
	[global::Cpp2ILInjected.Token(Token = "0x200001E")]
	internal interface IDtdParserAdapterV1 : IDtdParserAdapterWithValidation, IDtdParserAdapter
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000AB RID: 171
		[global::Cpp2ILInjected.Token(Token = "0x1700002E")]
		bool V1CompatibilityMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AB")]
			get;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AC RID: 172
		[global::Cpp2ILInjected.Token(Token = "0x1700002F")]
		bool Normalization
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AC")]
			get;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000AD RID: 173
		[global::Cpp2ILInjected.Token(Token = "0x17000030")]
		bool Namespaces
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AD")]
			get;
		}
	}
}
