using System;
using Cpp2ILInjected;

namespace System.ComponentModel.Design
{
	// Token: 0x020002FC RID: 764
	[global::Cpp2ILInjected.Token(Token = "0x200040F")]
	public interface IDictionaryService
	{
		// Token: 0x0600192E RID: 6446
		[global::Cpp2ILInjected.Token(Token = "0x6001C0C")]
		object GetValue(object key);

		// Token: 0x0600192F RID: 6447
		[global::Cpp2ILInjected.Token(Token = "0x6001C0D")]
		void SetValue(object key, object value);
	}
}
