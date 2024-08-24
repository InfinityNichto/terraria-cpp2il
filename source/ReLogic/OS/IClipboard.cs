using System;
using Cpp2ILInjected;

namespace ReLogic.OS
{
	// Token: 0x02000721 RID: 1825
	[global::Cpp2ILInjected.Token(Token = "0x2000B1F")]
	public interface IClipboard
	{
		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06004690 RID: 18064
		// (set) Token: 0x06004691 RID: 18065
		[global::Cpp2ILInjected.Token(Token = "0x170008F8")]
		string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005343")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6005344")]
			set;
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06004692 RID: 18066
		[global::Cpp2ILInjected.Token(Token = "0x170008F9")]
		string MultiLineValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005345")]
			get;
		}
	}
}
