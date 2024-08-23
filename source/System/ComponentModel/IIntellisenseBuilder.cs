using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x0200028C RID: 652
	[global::Cpp2ILInjected.Token(Token = "0x2000383")]
	public interface IIntellisenseBuilder
	{
		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x0600154D RID: 5453
		[global::Cpp2ILInjected.Token(Token = "0x1700055E")]
		string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001798")]
			get;
		}

		// Token: 0x0600154E RID: 5454
		[global::Cpp2ILInjected.Token(Token = "0x6001799")]
		bool Show(string language, string value, ref string newValue);
	}
}
