using System;
using Cpp2ILInjected;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001B7")]
	internal interface IAsyncLocal
	{
		[global::Cpp2ILInjected.Token(Token = "0x60010AB")]
		void OnValueChanged(object previousValue, object currentValue, bool contextChanged);
	}
}
