using System;
using Cpp2ILInjected;

namespace System.Threading
{
	// Token: 0x02000165 RID: 357
	[global::Cpp2ILInjected.Token(Token = "0x20001B7")]
	internal interface IAsyncLocal
	{
		// Token: 0x06000F79 RID: 3961
		[global::Cpp2ILInjected.Token(Token = "0x60010AB")]
		void OnValueChanged(object previousValue, object currentValue, bool contextChanged);
	}
}
