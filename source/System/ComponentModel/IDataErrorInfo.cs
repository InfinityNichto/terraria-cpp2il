using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x0200028A RID: 650
	[global::Cpp2ILInjected.Token(Token = "0x2000381")]
	public interface IDataErrorInfo
	{
		// Token: 0x17000532 RID: 1330
		[global::Cpp2ILInjected.Token(Token = "0x1700055C")]
		string this[string columnName]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001795")]
			get;
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600154B RID: 5451
		[global::Cpp2ILInjected.Token(Token = "0x1700055D")]
		string Error
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001796")]
			get;
		}
	}
}
